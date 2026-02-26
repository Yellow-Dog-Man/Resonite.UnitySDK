
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LightningMesh
// Generated on: čtvrtek 26. února 2026 12:26:50
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LightningMesh")]
public partial class LightningMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Int32 Seed { get => Seed_Element.Data; set => Seed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Seed_Element = new();
public global::System.Int32 Points { get => Points_Element.Data; set => Points_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Points_Element = new();
public global::Elements.Assets.SegmentedBuilder.Topology Topology { get => Topology_Element.Data; set => Topology_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.SegmentedBuilder.Topology>, global::Elements.Assets.SegmentedBuilder.Topology> Topology_Element = new();
public global::Elements.Assets.SegmentedBuilder.Shading Shading { get => Shading_Element.Data; set => Shading_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.SegmentedBuilder.Shading>, global::Elements.Assets.SegmentedBuilder.Shading> Shading_Element = new();
public global::Elements.Assets.SegmentedBuilder.Ends Ends { get => Ends_Element.Data; set => Ends_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.SegmentedBuilder.Ends>, global::Elements.Assets.SegmentedBuilder.Ends> Ends_Element = new();
public global::System.Boolean DualSided { get => DualSided_Element.Data; set => DualSided_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DualSided_Element = new();
public UnityEngine.Vector3 Point0 { get => Point0_Element.Data; set => Point0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Point0_Element = new();
public UnityEngine.Vector3 Point1 { get => Point1_Element.Data; set => Point1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Point1_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.LightningMesh.StrikeProperties>, global::FrooxEngine.LightningMesh.StrikeProperties> StrikeLevels = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Seed", Seed_Element.ToLinkField(context));
members.Add("Points", Points_Element.ToLinkField(context));
members.Add("Topology", Topology_Element.ToLinkField(context));
members.Add("Shading", Shading_Element.ToLinkField(context));
members.Add("Ends", Ends_Element.ToLinkField(context));
members.Add("DualSided", DualSided_Element.ToLinkField(context));
members.Add("Point0", Point0_Element.ToLinkField(context));
members.Add("Point1", Point1_Element.ToLinkField(context));
members.Add("StrikeLevels", StrikeLevels.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
