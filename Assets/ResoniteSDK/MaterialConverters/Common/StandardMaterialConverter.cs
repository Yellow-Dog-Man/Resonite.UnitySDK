using FrooxEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[MaterialConverter(false, "Standard")]
public class StandardMaterialConverter : ResoniteMaterialConverter
{
    public FrooxEngine.PBS_MetallicWrapper PBS;

    public override IAssetProvider<FrooxEngine.Material> UpdateConversion(UnityEngine.Material material, IConversionContext context)
    {
        if (PBS == null)
            PBS = gameObject.AddComponent<FrooxEngine.PBS_MetallicWrapper>();

        var data = PBS.Data;

        data.AlbedoColor = material.GetColor("_Color").ToColorX_Auto();

        data.AlphaCutoff = material.GetFloat("_Cutoff");
        data.Smoothness = material.GetFloat("_Glossiness");

        data.Metallic = material.GetFloat("_Metallic");

        data.NormalScale = material.GetFloat("_BumpScale");

        data.HeightScale = material.GetFloat("_Parallax");

        if(material.IsKeywordEnabled("_EMISSION"))
        {
            data.EmissiveColor = material.GetColor("_EmissionColor").ToColorX_Linear();
        }
        else
        {
            // There's no actual toggle for emission on the Resonite version, so just set it to black
            data.EmissiveColor = Color.black.ToColorX_Linear();
        }

        return data;
    }
}
