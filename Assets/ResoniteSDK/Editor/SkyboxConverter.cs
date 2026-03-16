using System;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

[Serializable]
public class SkyboxConverter
{
    public const string SKYBOX_ROOT_NAME = "__UnitySkybox";

    public GameObject SkyboxRoot;

    public FrooxEngine.SkyboxWrapper Skybox;
    public FrooxEngine.AmbientLightSH2Wrapper AmbientLight;
    public FrooxEngine.ReflectionProbeWrapper ReflectionProbe;
    public FrooxEngine.ReflectionProbeSH2Wrapper ReflectionProbeSH2;
    public FrooxEngine.ValueCopySH_L2_Wrapper ValueCopy;

    public void EnsureRoot()
    {
        if (SkyboxRoot != null)
            return;

        // Try to get the root from the current components if they exist
        SkyboxRoot = Skybox?.gameObject ?? AmbientLight?.gameObject ?? ReflectionProbe?.gameObject;

        if(SkyboxRoot == null)
        {
            // Try to find it in the scene
            var roots = SceneManager.GetActiveScene().GetRootGameObjects();
            SkyboxRoot = roots.FirstOrDefault(r => r.name == SKYBOX_ROOT_NAME);
        }

        // All failed, make one
        if(SkyboxRoot == null)
            SkyboxRoot = new GameObject(SKYBOX_ROOT_NAME);
    }

    // TODO!!! Handle different types of ambient light for conversion
    // Right now this just assumes that reflections and ambient light all come from the skybox
    public void ConvertCurrentSkybox(IConversionContext context)
    {
        EnsureComponent(ref Skybox);
        EnsureComponent(ref AmbientLight);
        EnsureComponent(ref ReflectionProbe);
        EnsureComponent(ref ReflectionProbeSH2);
        EnsureComponent(ref ValueCopy);

        // Setup the skybox material itself
        var skyboxMaterial = context.GetMaterial(RenderSettings.skybox);
        Skybox.Data.Material = skyboxMaterial;

        // Setup reflection probe for the skybox
        // This is used for specular reflections and also to auto-calculate the SH2
        ReflectionProbe.Data.SkyboxOnly = true;
        ReflectionProbe.Data.BoxSize = Vector3.one * 1000000;
        ReflectionProbe.Data.ClearFlags = Renderite.Shared.ReflectionProbeClear.Skybox;
        ReflectionProbe.Data.HDR = true;
        ReflectionProbe.Data.ProbeType = Renderite.Shared.ReflectionProbeType.OnChanges;
        ReflectionProbe.Data.Intensity = 1f;

        while (ReflectionProbe.Data.ChangesSources.Count < 2)
            ReflectionProbe.Data.ChangesSources.Add();

        ReflectionProbe.Data.ChangesSources[0] = Skybox.Data;
        ReflectionProbe.Data.ChangesSources[1] = skyboxMaterial;

        // Assign the reflection probe as source for SH2 computation
        ReflectionProbeSH2.Data.Probe = ReflectionProbe.Data;

        // This should make it look roughly the same as Unity's own calculation
        ReflectionProbeSH2.Data.Order0Scale = 1.5f;
        ReflectionProbeSH2.Data.Order1Scale = 0.5f;
        ReflectionProbeSH2.Data.Order2Scale = 0.5f;

        // Copy the value from the SH2 to AmbientLight
        ValueCopy.Data.Source = ReflectionProbeSH2.Data.AmbientLight_Element.Member;
        ValueCopy.Data.Target = AmbientLight.Data.AmbientLight_Element.Member;
    }

    void EnsureComponent<T>(ref T component)
        where T : ResoniteComponent
    {
        if (component != null)
            return;

        component = SkyboxRoot.GetComponent<T>();

        if (component == null)
            component = SkyboxRoot.AddComponent<T>();
    }
}
