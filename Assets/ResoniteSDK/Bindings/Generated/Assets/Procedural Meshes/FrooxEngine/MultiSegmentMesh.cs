
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiSegmentMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MultiSegmentMesh")]
public partial class MultiSegmentMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Int32 Sides;
public global::System.Boolean FlipNormalDirection;
public System.Collections.Generic.List<global::FrooxEngine.MultiSegmentMesh.SegmentInfo> Segments;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Sides", Sides.ToResoniteLinkField());
members.Add("FlipNormalDirection", FlipNormalDirection.ToResoniteLinkField());
members.Add("Segments", new ResoniteLink.SyncList()
{
    Elements = Segments.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
