using FrooxEngine;
using UnityEngine;

namespace ResoniteSDK {
    public class PoiyomiAssetCache
    {
        public UnityEngine.Texture2D ShadowRampTexture;
        public ColorSwizzler MetallicSwizzler = new();
        public PoiyomiXiexeTinter ShadowRampTinter = new();
    }
}