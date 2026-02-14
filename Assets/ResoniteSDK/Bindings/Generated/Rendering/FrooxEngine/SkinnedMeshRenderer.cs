
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SkinnedMeshRenderer
// Generated on: sobota 14. února 2026 8:58:34
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BoundsComputeMethod", BoundsComputeMethod.ToResoniteLinkField());
members.Add("ProxyBoundsSource", ProxyBoundsSource.ToResoniteReference(context));
members.Add("ExplicitLocalBounds", ExplicitLocalBounds.ToResoniteLinkField());
members.Add("Bones", new ResoniteLink.SyncList()
{
    Elements = Bones.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("BlendShapeWeights", new ResoniteLink.SyncList()
{
    Elements = BlendShapeWeights.ConvertList(m => m.ToResoniteLinkField())
});
}

}
}
