
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SkinnedMeshRenderer
// Generated on: čtvrtek 26. února 2026 10:04:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SkinnedMeshRenderer")]
public partial class SkinnedMeshRenderer : global::FrooxEngine.MeshRenderer, global::FrooxEngine.ICustomMemberNameSource

{
    public global::FrooxEngine.SkinnedBounds BoundsComputeMethod { get => BoundsComputeMethod_Element.Data; set => BoundsComputeMethod_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.SkinnedBounds>, global::FrooxEngine.SkinnedBounds> BoundsComputeMethod_Element = new();
public global::FrooxEngine.SkinnedMeshRenderer ProxyBoundsSource { get => ProxyBoundsSource_Element.Data; set => ProxyBoundsSource_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SkinnedMeshRenderer>, global::FrooxEngine.SkinnedMeshRenderer> ProxyBoundsSource_Element = new();
public UnityEngine.Bounds ExplicitLocalBounds { get => ExplicitLocalBounds_Element.Data; set => ExplicitLocalBounds_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Bounds>, UnityEngine.Bounds> ExplicitLocalBounds_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.Slot>, global::FrooxEngine.Slot, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot>> Bones = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.Single>, global::System.Single, Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single>> BlendShapeWeights = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BoundsComputeMethod", BoundsComputeMethod_Element.Data.ToResoniteLinkField());
members.Add("ProxyBoundsSource", ProxyBoundsSource_Element.Data.ToResoniteReference(context));
members.Add("ExplicitLocalBounds", ExplicitLocalBounds_Element.Data.ToResoniteLinkField());
members.Add("Bones", new ResoniteLink.SyncList()
{
    Elements = Bones.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("BlendShapeWeights", new ResoniteLink.SyncList()
{
    Elements = BlendShapeWeights.Data.ConvertList(m => m.Data.ToResoniteLinkField())
});
}

}
}
