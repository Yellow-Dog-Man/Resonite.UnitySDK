using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrooxEngine
{
    public partial class Light
    {
        public void SetFrom(UnityEngine.Light light)
        {
            // Set the basics
            base.SetFrom(light);

            switch (light.type)
            {
                case UnityEngine.LightType.Point:
                    LightType = Renderite.Shared.LightType.Point;
                    break;

                case UnityEngine.LightType.Spot:
                    LightType = Renderite.Shared.LightType.Spot;
                    break;

                case UnityEngine.LightType.Directional:
                    LightType = Renderite.Shared.LightType.Directional;
                    break;

                default:
                    // Not supported, set it to invalid value
                    LightType = (Renderite.Shared.LightType)(255);
                    break;
            }

            Intensity = light.intensity;
            Color = new ColorX(light.color);

            switch (light.shadows)
            {
                case UnityEngine.LightShadows.None:
                    ShadowType = Renderite.Shared.ShadowType.None;
                    break;

                case UnityEngine.LightShadows.Hard:
                    ShadowType = Renderite.Shared.ShadowType.Hard;
                    break;

                case UnityEngine.LightShadows.Soft:
                    ShadowType = Renderite.Shared.ShadowType.Soft;
                    break;
            }

            ShadowStrength = light.shadowStrength;
            ShadowNearPlane = light.shadowNearPlane;
            ShadowMapResolution = light.shadowCustomResolution;
            ShadowBias = light.shadowBias;
            ShadowNormalBias = light.shadowNormalBias;

            Range = light.range;
            SpotAngle = light.spotAngle;

            // TODO!!! Cookie
        }
    }
}

public class LightConverter : ResoniteComponentConverter<Light>
{
    public FrooxEngine.LightWrapper Light;

    protected override void Cleanup()
    {

    }

    protected override void Initialize(Light target)
    {
        base.Initialize(target);

        Light = gameObject.AddComponent<FrooxEngine.LightWrapper>();
    }

    protected override void UpdateConversion(Light target)
    {
        // We just assign the data
        Light.Data.SetFrom(target);
    }
}
