
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PointBrushTool
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PointBrushTool")]
public abstract partial class PointBrushTool : global::FrooxEngine.ParticleBrushTool

{
    public UnityEngine.Color MinColor { get => MinColor_Element.Data; set => MinColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Color>, UnityEngine.Color> MinColor_Element = new();
public UnityEngine.Color MaxColor { get => MaxColor_Element.Data; set => MaxColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Color>, UnityEngine.Color> MaxColor_Element = new();
public global::Renderite.Shared.ColorProfile Profile { get => Profile_Element.Data; set => Profile_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ColorProfile>, global::Renderite.Shared.ColorProfile> Profile_Element = new();
public global::System.Single ColorGap { get => ColorGap_Element.Data; set => ColorGap_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ColorGap_Element = new();
public UnityEngine.Vector2 MinSize { get => MinSize_Element.Data; set => MinSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> MinSize_Element = new();
public UnityEngine.Vector2 MaxSize { get => MaxSize_Element.Data; set => MaxSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> MaxSize_Element = new();
public global::System.Single SizeGap { get => SizeGap_Element.Data; set => SizeGap_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SizeGap_Element = new();
public global::FrooxEngine.AtlasInfo AtlasInfo { get => AtlasInfo_Element.Data; set => AtlasInfo_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.AtlasInfo>, global::FrooxEngine.AtlasInfo> AtlasInfo_Element = new();
public global::System.Boolean PressureAffectsSize { get => PressureAffectsSize_Element.Data; set => PressureAffectsSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PressureAffectsSize_Element = new();
public global::System.Boolean PressureAffectsAlpha { get => PressureAffectsAlpha_Element.Data; set => PressureAffectsAlpha_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PressureAffectsAlpha_Element = new();
public global::System.Boolean PressureAffectsIntensity { get => PressureAffectsIntensity_Element.Data; set => PressureAffectsIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PressureAffectsIntensity_Element = new();
public global::System.Boolean UseColor { get => UseColor_Element.Data; set => UseColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinColor", MinColor_Element.ToLinkField(context));
members.Add("MaxColor", MaxColor_Element.ToLinkField(context));
members.Add("Profile", Profile_Element.ToLinkField(context));
members.Add("ColorGap", ColorGap_Element.ToLinkField(context));
members.Add("MinSize", MinSize_Element.ToLinkField(context));
members.Add("MaxSize", MaxSize_Element.ToLinkField(context));
members.Add("SizeGap", SizeGap_Element.ToLinkField(context));
members.Add("AtlasInfo", AtlasInfo_Element.ToLinkReference(context));
members.Add("PressureAffectsSize", PressureAffectsSize_Element.ToLinkField(context));
members.Add("PressureAffectsAlpha", PressureAffectsAlpha_Element.ToLinkField(context));
members.Add("PressureAffectsIntensity", PressureAffectsIntensity_Element.ToLinkField(context));
members.Add("UseColor", UseColor_Element.ToLinkField(context));
}

}
}
