
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LightningMesh
// Generated on: čtvrtek 19. února 2026 7:58:53
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LightningMesh")]
public partial class LightningMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Int32 Seed;
public global::System.Int32 Points;
public global::Elements.Assets.SegmentedBuilder.Topology Topology;
public global::Elements.Assets.SegmentedBuilder.Shading Shading;
public global::Elements.Assets.SegmentedBuilder.Ends Ends;
public global::System.Boolean DualSided;
public UnityEngine.Vector3 Point0;
public UnityEngine.Vector3 Point1;
public System.Collections.Generic.List<global::FrooxEngine.LightningMesh.StrikeProperties> StrikeLevels;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Seed", Seed.ToResoniteLinkField());
members.Add("Points", Points.ToResoniteLinkField());
members.Add("Topology", Topology.ToResoniteLinkField());
members.Add("Shading", Shading.ToResoniteLinkField());
members.Add("Ends", Ends.ToResoniteLinkField());
members.Add("DualSided", DualSided.ToResoniteLinkField());
members.Add("Point0", Point0.ToResoniteLinkField());
members.Add("Point1", Point1.ToResoniteLinkField());
members.Add("StrikeLevels", new ResoniteLink.SyncList()
{
    Elements = StrikeLevels.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
