using FrooxEngine;
using UnityEngine;

namespace ResoniteSDK {
    // This converter maps UniVRM MToon 1.0 materials to Resonite's XiexeToonMaterial.
    //
    // It only reads Unity material properties by name. UniVRM does not need to be
    // referenced by this SDK project for the converter to compile.
    [MaterialConverter(false, "VRM10/MToon10", "VRM10/Universal Render Pipeline/MToon10")]
    public class MToon10Converter : ResoniteMaterialConverter
    {
        private ResRef<FrooxEngine.XiexeToonMaterial> XiexeComponent;

        private ResRef<FrooxEngine.Panner2D> MainTexturePanner;
        private ResRef<FrooxEngine.Panner2D> NormalMapPanner;
        private ResRef<FrooxEngine.Panner2D> EmissionMapPanner;
        private ResRef<FrooxEngine.Panner2D> ShadowRampMaskPanner;

        public override IAssetProvider<FrooxEngine.Material> UpdateConversion(UnityEngine.Material material, IConversionContext context)
        {
            if (XiexeComponent == null)
            {
                XiexeComponent = gameObject.AddResoniteComponent<FrooxEngine.XiexeToonMaterial>();
            }

            var converted = MToon10XiexeConverter.UpdateConversion(XiexeComponent, material, context);
            UpdateUvScrollPanners(material, XiexeComponent);
            return converted;
        }

        private void UpdateUvScrollPanners(UnityEngine.Material material, FrooxEngine.XiexeToonMaterial xiexe)
        {
            var speed = new Vector2(
                material.GetFloat("_UvAnimScrollXSpeed"),
                material.GetFloat("_UvAnimScrollYSpeed"));
            var hasMask = material.GetTexture("_UvAnimMaskTex") != null;
            var hasRotation = !Mathf.Approximately(material.GetFloat("_UvAnimRotationSpeed"), 0);
            var hasScroll = !Mathf.Approximately(speed.sqrMagnitude, 0);
            var canConvertScroll = hasScroll && !hasMask && !hasRotation;
            if (!canConvertScroll)
            {
                return;
            }

            if (xiexe.MainTexture != null)
            {
                UpdatePanner(ref MainTexturePanner, xiexe.MainTextureOffset_Element.Member, speed, xiexe.MainTextureOffset);
            }
            if (xiexe.NormalMap != null)
            {
                UpdatePanner(ref NormalMapPanner, xiexe.NormalMapOffset_Element.Member, speed, xiexe.NormalMapOffset);
            }
            if (xiexe.EmissionMap != null)
            {
                UpdatePanner(ref EmissionMapPanner, xiexe.EmissionMapOffset_Element.Member, speed, xiexe.EmissionMapOffset);
            }
            if (xiexe.ShadowRampMask != null)
            {
                UpdatePanner(ref ShadowRampMaskPanner, xiexe.ShadowRampMaskOffset_Element.Member, speed, xiexe.ShadowRampMaskOffset);
            }
        }

        private void UpdatePanner(
            ref ResRef<FrooxEngine.Panner2D> panner,
            FrooxEngine.IField<Vector2> target,
            Vector2 speed,
            Vector2 offset)
        {
            if (panner == null)
            {
                panner = gameObject.AddResoniteComponent<FrooxEngine.Panner2D>();
            }

            var data = panner.Binding;
            data.Enabled = true;
            data.persistent = true;
            data._target = target;
            data._speed = speed;
            data._offset = offset;
            data._repeat = new Vector2(float.PositiveInfinity, float.PositiveInfinity);
        }

    }
}