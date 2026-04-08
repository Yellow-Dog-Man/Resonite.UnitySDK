using FrooxEngine;
using UnityEngine;

public class PoiyomiAssetCache
{
    public PoiyomiConverter Converter;

    public PoiyomiAssetCache(PoiyomiConverter Converter)
    {
        this.Converter = Converter;
    }

    public UnityEngine.Texture2D ShadowRampTexture;

    public UnityEngine.Texture2D MatcapTexture;

    private FrooxEngine.SolidColorTextureWrapper _SolidWhiteTexture;
    public FrooxEngine.SolidColorTextureWrapper SolidWhiteTexture
    {
        get
        {
            if (_SolidWhiteTexture == null)
            {
                _SolidWhiteTexture = Converter.gameObject.AddComponent<FrooxEngine.SolidColorTextureWrapper>();
                _SolidWhiteTexture.Data.Color = Color.white.ToColorX_sRGB();
                _SolidWhiteTexture.Data.FilterMode = Renderite.Shared.TextureFilterMode.Bilinear;
                _SolidWhiteTexture.Data.AnisotropicLevel = 8;
                _SolidWhiteTexture.Data.Format = Renderite.Shared.TextureFormat.RGBA32;
                _SolidWhiteTexture.Data.Size = new(4, 4);
            }
            return _SolidWhiteTexture;
        }
    }
}
