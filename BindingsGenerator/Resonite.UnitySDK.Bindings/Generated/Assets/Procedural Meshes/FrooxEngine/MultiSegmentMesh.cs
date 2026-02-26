
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiSegmentMesh
// Generated on: čtvrtek 26. února 2026 10:03:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MultiSegmentMesh")]
public partial class MultiSegmentMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Int32 Sides { get => Sides_Element.Data; set => Sides_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Sides_Element = new();
public global::System.Boolean FlipNormalDirection { get => FlipNormalDirection_Element.Data; set => FlipNormalDirection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FlipNormalDirection_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.MultiSegmentMesh.SegmentInfo>, global::FrooxEngine.MultiSegmentMesh.SegmentInfo> Segments = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Sides", Sides_Element.Data.ToResoniteLinkField());
members.Add("FlipNormalDirection", FlipNormalDirection_Element.Data.ToResoniteLinkField());
members.Add("Segments", new ResoniteLink.SyncList()
{
    Elements = Segments.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
