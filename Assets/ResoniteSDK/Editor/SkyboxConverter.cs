using Elements.Core;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

[Serializable]
public class SkyboxConverter
{
    public const string SKYBOX_ROOT_NAME = "__UnitySkybox";

    public GameObject SkyboxRoot;

    public ResRef<FrooxEngine.Skybox> Skybox;
    public ResRef<FrooxEngine.AmbientLightSH2> AmbientLight;
    public ResRef<FrooxEngine.ReflectionProbe> ReflectionProbe;
    public ResRef<FrooxEngine.ReflectionProbeSH2> ReflectionProbeSH2;
    public ResRef<FrooxEngine.ValueCopy<SphericalHarmonicsL2>> ValueCopy;

    public void EnsureRoot()
    {
        if (SkyboxRoot != null)
            return;

        // Try to get the root from the current components if they exist
        SkyboxRoot = Skybox.Container?.gameObject ?? AmbientLight.Container?.gameObject ?? ReflectionProbe.Container?.gameObject;

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
        Skybox.Binding.Material = skyboxMaterial;

        // Setup reflection probe for the skybox
        // This is used for specular reflections and also to auto-calculate the SH2
        ReflectionProbe.Binding.SkyboxOnly = true;
        ReflectionProbe.Binding.BoxSize = Vector3.one * 1000000;
        ReflectionProbe.Binding.ClearFlags = Renderite.Shared.ReflectionProbeClear.Skybox;
        ReflectionProbe.Binding.HDR = true;
        ReflectionProbe.Binding.ProbeType = Renderite.Shared.ReflectionProbeType.OnChanges;
        ReflectionProbe.Binding.Intensity = 1f;

        while (ReflectionProbe.Binding.ChangesSources.Count < 2)
            ReflectionProbe.Binding.ChangesSources.Add();

        ReflectionProbe.Binding.ChangesSources[0] = Skybox.Binding;
        ReflectionProbe.Binding.ChangesSources[1] = skyboxMaterial;

        // Assign the reflection probe as source for SH2 computation
        ReflectionProbeSH2.Binding.Probe = ReflectionProbe.Binding;

        // This should make it look roughly the same as Unity's own calculation
        ReflectionProbeSH2.Binding.Order0Scale = 1.5f;
        ReflectionProbeSH2.Binding.Order1Scale = 0.5f;
        ReflectionProbeSH2.Binding.Order2Scale = 0.5f;

        // Copy the value from the SH2 to AmbientLight
        ValueCopy.Binding.Source = ReflectionProbeSH2.Binding.AmbientLight_Element.Member;
        ValueCopy.Binding.Target = AmbientLight.Binding.AmbientLight_Element.Member;
    }

    void EnsureComponent<T>(ref ResRef<T> component)
        where T : ResoniteObject, FrooxEngine.IWorldElement, new()
    {
        if (component != null)
            return;

        component = SkyboxRoot.GetResoniteComponent<T>();

        if (component == null)
            component = SkyboxRoot.AddResoniteComponent<T>();
    }
}
