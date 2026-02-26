
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TubeWireMesh
// Generated on: čtvrtek 26. února 2026 12:26:51
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TubeWireMesh")]
public partial class TubeWireMesh : global::FrooxEngine.WireMeshBase

{
    public global::System.Single Radius0 { get => Radius0_Element.Data; set => Radius0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius0_Element = new();
public global::System.Single Radius1 { get => Radius1_Element.Data; set => Radius1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius1_Element = new();
public global::Elements.Assets.SegmentedBuilder.Ends Ends { get => Ends_Element.Data; set => Ends_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.SegmentedBuilder.Ends>, global::Elements.Assets.SegmentedBuilder.Ends> Ends_Element = new();
public global::Elements.Assets.SegmentedBuilder.Shading Shading { get => Shading_Element.Data; set => Shading_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.SegmentedBuilder.Shading>, global::Elements.Assets.SegmentedBuilder.Shading> Shading_Element = new();
public global::System.Int32 Points { get => Points_Element.Data; set => Points_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Points_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius0", Radius0_Element.ToLinkField(context));
members.Add("Radius1", Radius1_Element.ToLinkField(context));
members.Add("Ends", Ends_Element.ToLinkField(context));
members.Add("Shading", Shading_Element.ToLinkField(context));
members.Add("Points", Points_Element.ToLinkField(context));
}

}
}
