using FrooxEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[MaterialConverter(false, "Standard (Specular setup)")]
public class StandardSpecularConverter : StandardBaseConverter<PBS_SpecularWrapper, PBS_Specular>
{
    public override IAssetProvider<FrooxEngine.Material> UpdateConversion(UnityEngine.Material material, IConversionContext context)
    {
        var provider = base.UpdateConversion(material, context);

        var data = PBS.Data;

        var specColor = material.GetColor("_SpecColor");

        // Resonite uses the alpha channel to determine the glossiness
        specColor.a = material.GetFloat("_Glossiness");

        data.SpecularColor = specColor.ToColorX_Linear();
        data.SpecularMap = context.GetTextureAuto(material.GetTexture("_SpecGlossMap"));

        return provider;
    }
}
