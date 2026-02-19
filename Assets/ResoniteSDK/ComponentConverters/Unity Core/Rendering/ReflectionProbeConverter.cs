using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrooxEngine
{
    public partial class ReflectionProbe
    {
        public void SetFrom(UnityEngine.ReflectionProbe probe, IConversionContext context)
        {
            base.SetFrom(probe);

            switch(probe.mode)
            {
                case UnityEngine.Rendering.ReflectionProbeMode.Baked:
                    ProbeType = Renderite.Shared.ReflectionProbeType.Baked;
                    break;

                case UnityEngine.Rendering.ReflectionProbeMode.Realtime:
                    ProbeType = Renderite.Shared.ReflectionProbeType.Realtime;
                    break;

                case UnityEngine.Rendering.ReflectionProbeMode.Custom:
                    // This is the closest equivalent, but whatever logic is triggering the custom one won't likely
                    // translate, so this might need additional work
                    ProbeType = Renderite.Shared.ReflectionProbeType.OnChanges;
                    break;
            }

            switch(probe.timeSlicingMode)
            {
                case UnityEngine.Rendering.ReflectionProbeTimeSlicingMode.NoTimeSlicing:
                    TimeSlicing = Renderite.Shared.ReflectionProbeTimeSlicingMode.NoTimeSlicing;
                    break;

                case UnityEngine.Rendering.ReflectionProbeTimeSlicingMode.IndividualFaces:
                    TimeSlicing = Renderite.Shared.ReflectionProbeTimeSlicingMode.IndividualFaces;
                    break;

                case UnityEngine.Rendering.ReflectionProbeTimeSlicingMode.AllFacesAtOnce:
                    TimeSlicing = Renderite.Shared.ReflectionProbeTimeSlicingMode.AllFacesAtOnce;
                    break;
            }

            Importance = probe.importance;
            Intensity = probe.intensity;

            BlendDistance = probe.blendDistance;
            BoxSize = probe.size;
            BoxProjection = probe.boxProjection;

            Resolution = probe.resolution;
            HDR = probe.hdr;

            ShadowDistance = probe.shadowDistance;

            ClearFlags = probe.clearFlags.ToResoniteLink();
            BackgroundColor = probe.backgroundColor.ToColorX_Auto();

            NearClip = probe.nearClipPlane;
            FarClip = probe.farClipPlane;

            // If the probe has everything culled, then we can consider it skybox only
            SkyboxOnly = probe.cullingMask == 0;

            if (ProbeType == Renderite.Shared.ReflectionProbeType.Baked)
                BakedCubemap = context.GetCubemap(probe.bakedTexture as UnityEngine.Cubemap ?? probe.customBakedTexture as UnityEngine.Cubemap);
            else
                BakedCubemap = null;
        }
    }
}


public class ReflectionProbeConverter : ResoniteSingleComponentConverter<ReflectionProbe, FrooxEngine.ReflectionProbeWrapper>
{
    protected override void UpdateConversion(ReflectionProbe target, IConversionContext context)
    {
        Binding.Data.SetFrom(target, context);
    }
}