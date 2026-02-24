
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CircleSegmentShaderMesh
// Generated on: úterý 24. února 2026 18:17:39
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CircleSegmentShaderMesh")]
public partial class CircleSegmentShaderMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single RadiusStart;
public global::System.Single Thickness;
public global::System.Single AngleStart;
public global::System.Single ArcLength;
public UnityEngine.ColorX FillColor;
public UnityEngine.ColorX BorderColor;
public global::System.Single BorderSize;
public global::System.Single RoundedCornerRadius;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RadiusStart", RadiusStart.ToResoniteLinkField());
members.Add("Thickness", Thickness.ToResoniteLinkField());
members.Add("AngleStart", AngleStart.ToResoniteLinkField());
members.Add("ArcLength", ArcLength.ToResoniteLinkField());
members.Add("FillColor", FillColor.ToResoniteLinkField());
members.Add("BorderColor", BorderColor.ToResoniteLinkField());
members.Add("BorderSize", BorderSize.ToResoniteLinkField());
members.Add("RoundedCornerRadius", RoundedCornerRadius.ToResoniteLinkField());
}

}
}
