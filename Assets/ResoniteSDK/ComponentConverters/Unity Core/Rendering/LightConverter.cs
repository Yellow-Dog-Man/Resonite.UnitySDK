using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        Light.Data.Enabled = true;
        Light.Data.persistent = true;

        switch (target.type)
        {
            case LightType.Point:
                Light.Data.LightType = Renderite.Shared.LightType.Point;
                break;

            case LightType.Spot:
                Light.Data.LightType = Renderite.Shared.LightType.Spot;
                break;

            case LightType.Directional:
                Light.Data.LightType = Renderite.Shared.LightType.Directional;
                break;

            default:
                // Not supported, set it to invalid value
                Light.Data.LightType = (Renderite.Shared.LightType)(255);
                break;
        }

        Light.Data.Intensity = target.intensity;
        Light.Data.Color = new ColorX(target.color);

        switch (target.shadows)
        {
            case LightShadows.None:
                Light.Data.ShadowType = Renderite.Shared.ShadowType.None;
                break;

            case LightShadows.Hard:
                Light.Data.ShadowType = Renderite.Shared.ShadowType.Hard;
                break;

            case LightShadows.Soft:
                Light.Data.ShadowType = Renderite.Shared.ShadowType.Soft;
                break;
        }

        Light.Data.ShadowStrength = target.shadowStrength;
        Light.Data.ShadowNearPlane = target.shadowNearPlane;
        Light.Data.ShadowMapResolution = target.shadowCustomResolution;
        Light.Data.ShadowBias = target.shadowBias;
        Light.Data.ShadowNormalBias = target.shadowNormalBias;

        Light.Data.Range = target.range;
        Light.Data.SpotAngle = target.spotAngle;

        // TODO!!! Cookie
    }
}
