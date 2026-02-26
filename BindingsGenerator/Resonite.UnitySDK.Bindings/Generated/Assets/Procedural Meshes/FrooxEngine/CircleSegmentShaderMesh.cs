
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CircleSegmentShaderMesh
// Generated on: čtvrtek 26. února 2026 10:03:35
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CircleSegmentShaderMesh")]
public partial class CircleSegmentShaderMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single RadiusStart { get => RadiusStart_Element.Data; set => RadiusStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RadiusStart_Element = new();
public global::System.Single Thickness { get => Thickness_Element.Data; set => Thickness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Thickness_Element = new();
public global::System.Single AngleStart { get => AngleStart_Element.Data; set => AngleStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AngleStart_Element = new();
public global::System.Single ArcLength { get => ArcLength_Element.Data; set => ArcLength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ArcLength_Element = new();
public UnityEngine.ColorX FillColor { get => FillColor_Element.Data; set => FillColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> FillColor_Element = new();
public UnityEngine.ColorX BorderColor { get => BorderColor_Element.Data; set => BorderColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> BorderColor_Element = new();
public global::System.Single BorderSize { get => BorderSize_Element.Data; set => BorderSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BorderSize_Element = new();
public global::System.Single RoundedCornerRadius { get => RoundedCornerRadius_Element.Data; set => RoundedCornerRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RoundedCornerRadius_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RadiusStart", RadiusStart_Element.Data.ToResoniteLinkField());
members.Add("Thickness", Thickness_Element.Data.ToResoniteLinkField());
members.Add("AngleStart", AngleStart_Element.Data.ToResoniteLinkField());
members.Add("ArcLength", ArcLength_Element.Data.ToResoniteLinkField());
members.Add("FillColor", FillColor_Element.Data.ToResoniteLinkField());
members.Add("BorderColor", BorderColor_Element.Data.ToResoniteLinkField());
members.Add("BorderSize", BorderSize_Element.Data.ToResoniteLinkField());
members.Add("RoundedCornerRadius", RoundedCornerRadius_Element.Data.ToResoniteLinkField());
}

}
}
