
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PointBrushTool
// Generated on: čtvrtek 19. února 2026 8:00:23
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public UnityEngine.Color MinColor;
public UnityEngine.Color MaxColor;
public global::Renderite.Shared.ColorProfile Profile;
public global::System.Single ColorGap;
public UnityEngine.Vector2 MinSize;
public UnityEngine.Vector2 MaxSize;
public global::System.Single SizeGap;
public global::FrooxEngine.AtlasInfo AtlasInfo;
public global::System.Boolean PressureAffectsSize;
public global::System.Boolean PressureAffectsAlpha;
public global::System.Boolean PressureAffectsIntensity;
public global::System.Boolean UseColor;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinColor", MinColor.ToResoniteLinkField());
members.Add("MaxColor", MaxColor.ToResoniteLinkField());
members.Add("Profile", Profile.ToResoniteLinkField());
members.Add("ColorGap", ColorGap.ToResoniteLinkField());
members.Add("MinSize", MinSize.ToResoniteLinkField());
members.Add("MaxSize", MaxSize.ToResoniteLinkField());
members.Add("SizeGap", SizeGap.ToResoniteLinkField());
members.Add("AtlasInfo", AtlasInfo.ToResoniteReference(context));
members.Add("PressureAffectsSize", PressureAffectsSize.ToResoniteLinkField());
members.Add("PressureAffectsAlpha", PressureAffectsAlpha.ToResoniteLinkField());
members.Add("PressureAffectsIntensity", PressureAffectsIntensity.ToResoniteLinkField());
members.Add("UseColor", UseColor.ToResoniteLinkField());
}

}
}
