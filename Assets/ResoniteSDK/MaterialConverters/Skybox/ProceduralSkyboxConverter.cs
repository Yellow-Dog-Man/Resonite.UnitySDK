using FrooxEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

[MaterialConverter(false, "Skybox/Procedural")]
public class ProceduralSkyboxConverter : ResoniteMaterialConverter
{
    public FrooxEngine.ProceduralSkyMaterialWrapper Sky;

    public override IAssetProvider<FrooxEngine.Material> UpdateConversion(UnityEngine.Material material, IConversionContext context)
    {
        if (Sky == null)
            Sky = gameObject.AddComponent<FrooxEngine.ProceduralSkyMaterialWrapper>();

        var data = Sky.Data;

        if (material.IsKeywordEnabled("_SUNDISK_HIGH_QUALITY"))
            data.SunQuality = ProceduralSkyMaterial.SunType.HighQuality;
        else if (material.IsKeywordEnabled("_SUNDISK_SIMPLE"))
            data.SunQuality = ProceduralSkyMaterial.SunType.Simple;
        else
            data.SunQuality = ProceduralSkyMaterial.SunType.None;

        data.SunSize = material.GetFloat("_SunSize");

        data.AtmosphereThickness = material.GetFloat("_AtmosphereThickness");
        data.SkyTint = material.GetColor("_SkyTint").ToColorX_sRGB();
        data.GroundColor = material.GetColor("_GroundColor").ToColorX_sRGB();
        data.Exposure = material.GetFloat("_Exposure");

        var sun = FindSun();

        if (sun == null)
            data.Sun = null;
        else
        {
            // We defer the conversion here for when the Light itself has been converted. The wrapper might not exist
            // yet, so we don't want to get the conversion too early, otherwise it might miss it
            context.RunOnConverted(sun, () => data.Sun = sun.gameObject.GetComponent<LightWrapper>()?.Data);
        }

        return data;
    }

    UnityEngine.Light FindSun()
    {
        if (RenderSettings.sun != null)
            return RenderSettings.sun;

        UnityEngine.Light bestLight = null;

        foreach(var root in SceneManager.GetActiveScene().GetRootGameObjects())
        {
            foreach(var light in root.GetComponents<UnityEngine.Light>())
            {
                if (light.type != LightType.Directional)
                    continue;

                if (!light.isActiveAndEnabled)
                    continue;

                if (bestLight == null)
                    bestLight = light;
                else if (bestLight.intensity < light.intensity)
                    bestLight = light;
            }
        }

        return bestLight;
    }
}