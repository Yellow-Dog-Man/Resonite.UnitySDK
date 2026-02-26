
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LightTool
// Generated on: čtvrtek 26. února 2026 12:28:06
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.LightTool.Mode LightMode { get => LightMode_Element.Data; set => LightMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.LightTool.Mode>, global::FrooxEngine.LightTool.Mode> LightMode_Element = new();
public UnityEngine.ColorX Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color_Element = new();
public global::System.Single Intensity { get => Intensity_Element.Data; set => Intensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Intensity_Element = new();
public global::Renderite.Shared.ShadowType ShadowType { get => ShadowType_Element.Data; set => ShadowType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ShadowType>, global::Renderite.Shared.ShadowType> ShadowType_Element = new();
public global::System.Single ShadowStrength { get => ShadowStrength_Element.Data; set => ShadowStrength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ShadowStrength_Element = new();
public global::System.Single Range { get => Range_Element.Data; set => Range_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Range_Element = new();
public global::System.Single SpotAngle { get => SpotAngle_Element.Data; set => SpotAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SpotAngle_Element = new();
public global::FrooxEngine.Slot PointLightVisual { get => PointLightVisual_Element.Data; set => PointLightVisual_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> PointLightVisual_Element = new();
public global::FrooxEngine.Slot SpotlightVisual { get => SpotlightVisual_Element.Data; set => SpotlightVisual_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> SpotlightVisual_Element = new();
public global::FrooxEngine.Slot DirectionalLightVisual { get => DirectionalLightVisual_Element.Data; set => DirectionalLightVisual_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> DirectionalLightVisual_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>>, global::FrooxEngine.IField<UnityEngine.ColorX>, Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>>> ColorIndicators = new();
public global::System.Boolean ShowGizmo { get => ShowGizmo_Element.Data; set => ShowGizmo_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowGizmo_Element = new();
public global::FrooxEngine.LegacySegmentCircleMenuController.Item _pointLightItem { get => _pointLightItem_Element.Data; set => _pointLightItem_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacySegmentCircleMenuController.Item>, global::FrooxEngine.LegacySegmentCircleMenuController.Item> _pointLightItem_Element = new();
public global::FrooxEngine.LegacySegmentCircleMenuController.Item _spotLightItem { get => _spotLightItem_Element.Data; set => _spotLightItem_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacySegmentCircleMenuController.Item>, global::FrooxEngine.LegacySegmentCircleMenuController.Item> _spotLightItem_Element = new();
public global::FrooxEngine.LegacySegmentCircleMenuController.Item _directionalLightItem { get => _directionalLightItem_Element.Data; set => _directionalLightItem_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacySegmentCircleMenuController.Item>, global::FrooxEngine.LegacySegmentCircleMenuController.Item> _directionalLightItem_Element = new();
public global::FrooxEngine.LegacySegmentCircleMenuController.Item _shadowsItem { get => _shadowsItem_Element.Data; set => _shadowsItem_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacySegmentCircleMenuController.Item>, global::FrooxEngine.LegacySegmentCircleMenuController.Item> _shadowsItem_Element = new();
public global::FrooxEngine.ColorDialogInterface _colorPicker { get => _colorPicker_Element.Data; set => _colorPicker_Element.Data = value; }
public Field<global::FrooxEngine.SlotCleanupRef<global::FrooxEngine.ColorDialogInterface>, global::FrooxEngine.ColorDialogInterface> _colorPicker_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LightMode", LightMode_Element.ToLinkField(context));
members.Add("Color", Color_Element.ToLinkField(context));
members.Add("Intensity", Intensity_Element.ToLinkField(context));
members.Add("ShadowType", ShadowType_Element.ToLinkField(context));
members.Add("ShadowStrength", ShadowStrength_Element.ToLinkField(context));
members.Add("Range", Range_Element.ToLinkField(context));
members.Add("SpotAngle", SpotAngle_Element.ToLinkField(context));
members.Add("PointLightVisual", PointLightVisual_Element.ToLinkReference(context));
members.Add("SpotlightVisual", SpotlightVisual_Element.ToLinkReference(context));
members.Add("DirectionalLightVisual", DirectionalLightVisual_Element.ToLinkReference(context));
members.Add("ColorIndicators", ColorIndicators.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("ShowGizmo", ShowGizmo_Element.ToLinkField(context));
members.Add("_pointLightItem", _pointLightItem_Element.ToLinkReference(context));
members.Add("_spotLightItem", _spotLightItem_Element.ToLinkReference(context));
members.Add("_directionalLightItem", _directionalLightItem_Element.ToLinkReference(context));
members.Add("_shadowsItem", _shadowsItem_Element.ToLinkReference(context));
members.Add("_colorPicker", _colorPicker_Element.ToLinkReference(context));
}

}
}
