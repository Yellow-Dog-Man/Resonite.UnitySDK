
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LightTool
// Generated on: sobota 14. února 2026 8:58:37
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LightTool")]
public partial class LightTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.LightTool.Mode LightMode;
public UnityEngine.ColorX Color;
public global::System.Single Intensity;
public global::Renderite.Shared.ShadowType ShadowType;
public global::System.Single ShadowStrength;
public global::System.Single Range;
public global::System.Single SpotAngle;
public global::FrooxEngine.Slot PointLightVisual;
public global::FrooxEngine.Slot SpotlightVisual;
public global::FrooxEngine.Slot DirectionalLightVisual;
public System.Collections.Generic.List<global::FrooxEngine.IField<UnityEngine.ColorX>> ColorIndicators;
public global::System.Boolean ShowGizmo;
public global::FrooxEngine.LegacySegmentCircleMenuController.Item _pointLightItem;
public global::FrooxEngine.LegacySegmentCircleMenuController.Item _spotLightItem;
public global::FrooxEngine.LegacySegmentCircleMenuController.Item _directionalLightItem;
public global::FrooxEngine.LegacySegmentCircleMenuController.Item _shadowsItem;
public global::FrooxEngine.ColorDialogInterface _colorPicker;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LightMode", LightMode.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("Intensity", Intensity.ToResoniteLinkField());
members.Add("ShadowType", ShadowType.ToResoniteLinkField());
members.Add("ShadowStrength", ShadowStrength.ToResoniteLinkField());
members.Add("Range", Range.ToResoniteLinkField());
members.Add("SpotAngle", SpotAngle.ToResoniteLinkField());
members.Add("PointLightVisual", PointLightVisual.ToResoniteReference(context));
members.Add("SpotlightVisual", SpotlightVisual.ToResoniteReference(context));
members.Add("DirectionalLightVisual", DirectionalLightVisual.ToResoniteReference(context));
members.Add("ColorIndicators", new ResoniteLink.SyncList()
{
    Elements = ColorIndicators.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("ShowGizmo", ShowGizmo.ToResoniteLinkField());
members.Add("_pointLightItem", _pointLightItem.ToResoniteReference(context));
members.Add("_spotLightItem", _spotLightItem.ToResoniteReference(context));
members.Add("_directionalLightItem", _directionalLightItem.ToResoniteReference(context));
members.Add("_shadowsItem", _shadowsItem.ToResoniteReference(context));
members.Add("_colorPicker", _colorPicker.ToResoniteReference(context));
}

}
}
