
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SkinnedMeshRenderer
// Generated on: pátek 13. února 2026 5:52:21
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SkinnedMeshRenderer")]
public partial class SkinnedMeshRenderer : global::FrooxEngine.MeshRenderer, global::FrooxEngine.ICustomMemberNameSource

{
    public global::FrooxEngine.SkinnedBounds BoundsComputeMethod;
public global::FrooxEngine.SkinnedMeshRenderer ProxyBoundsSource;
public global::Elements.Core.BoundingBox ExplicitLocalBounds;
public System.Collections.Generic.List<global::FrooxEngine.Slot> Bones;
public System.Collections.Generic.List<global::System.Single> BlendShapeWeights;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("BoundsComputeMethod", BoundsComputeMethod.ToResoniteLinkField());
members.Add("ProxyBoundsSource", new ResoniteLink.Reference() { });
members.Add("ExplicitLocalBounds", ExplicitLocalBounds.ToResoniteLinkField());
members.Add("Bones", new ResoniteLink.SyncList()
{
    Elements = Bones.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("BlendShapeWeights", new ResoniteLink.SyncList()
{
    Elements = BlendShapeWeights.Select(m => m.ToResoniteLinkField()).ToList<ResoniteLink.Member>()
});
}

}
}
