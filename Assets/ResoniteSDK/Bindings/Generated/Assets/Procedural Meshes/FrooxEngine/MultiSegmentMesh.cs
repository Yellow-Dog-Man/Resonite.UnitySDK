
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiSegmentMesh
// Generated on: pátek 13. února 2026 23:21:35
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Sides", Sides.ToResoniteLinkField());
members.Add("FlipNormalDirection", FlipNormalDirection.ToResoniteLinkField());
members.Add("Segments", new ResoniteLink.SyncList()
{
    Elements = Segments.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
}

}
}
