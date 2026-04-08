using FrooxEngine;
using UnityEngine;

// This converter is a prototype meant to convert materials using
// the Poiyomi Toon family of shaders into a Resonite material.
// It will use either Xiexe or PBS depending on the material's lighting mode.
//
// Poiyomi Toon shaders are freely available under the MIT license.
// Documentation and download links are available at https://www.poiyomi.com/
//
// However, this converter only uses the material's named properties.
// So neither the Poiyomi Toon shaders nor its source code
// need to be available in the Unity project for the converter to work.
[MaterialConverter(true)]
public class PoiyomiConverter : ResoniteMaterialConverter
{
    private FrooxEngine.XiexeToonMaterialWrapper XiexeComponent;

    private FrooxEngine.PBS_MetallicWrapper PbsComponent;

    private PoiyomiAssetCache _AssetCache;
    private PoiyomiAssetCache AssetCache
    {
        get
        {
            if (_AssetCache == null)
            {
                _AssetCache = new(this);
            }
            return _AssetCache;
        }
    }

    public static float? EvaluateHeuristicConversion(UnityEngine.Material material)
    {
        if (!material.shader.name.StartsWith(".poiyomi/"))
        {
            return null;
        }
        // TODO: Maybe add more robusts checks, i.e. on the shader's version number or on its "variants"?
        return 0;
    }

    public override IAssetProvider<FrooxEngine.Material> UpdateConversion(UnityEngine.Material material, IConversionContext context)
    {
        if (material.GetFloat("_ShadingEnabled") == 0)
        {
            // Flat shading
            // TODO: see if there is a way to alert the mesh renderer
            // that it should set its ShadowCastMode to Off
            return UpdateXiexeConversion(material, context);
        }

        PoiyomiLightingMode lightingMode = (PoiyomiLightingMode)material.GetFloat("_LightingMode");
        if (lightingMode.IsPhysicallyBased())
        {
            // Use Poiyomi PBS converter in priority
            return UpdatePbsConversion(material, context);
        }

        return UpdateXiexeConversion(material, context);
    }

    private IAssetProvider<FrooxEngine.Material> UpdatePbsConversion(UnityEngine.Material material, IConversionContext context)
    {
        if (PbsComponent == null)
        {
            PbsComponent = gameObject.AddComponent<FrooxEngine.PBS_MetallicWrapper>();
        }
        return new PoiyomiPbsConverter(PbsComponent.Data, material, context).UpdateConversion();
    }

    private IAssetProvider<FrooxEngine.Material> UpdateXiexeConversion(UnityEngine.Material material, IConversionContext context)
    {
        if (XiexeComponent == null)
        {
            XiexeComponent = gameObject.AddComponent<FrooxEngine.XiexeToonMaterialWrapper>();
            // A few properties should be initialized at non-default values to look right
            var Xiexe = XiexeComponent.Data;
            Xiexe.ShadowSharpness = 0.5f;
            Xiexe.ShadowRampMaskScale = new(1, 1);
        }
        return new PoiyomiXiexeConverter(XiexeComponent.Data, material, context, AssetCache).UpdateConversion();
    }
}
