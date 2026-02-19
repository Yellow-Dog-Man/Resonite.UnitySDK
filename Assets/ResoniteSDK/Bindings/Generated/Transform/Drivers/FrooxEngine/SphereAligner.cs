
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SphereAligner
// Generated on: čtvrtek 19. února 2026 8:00:24
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SphereAligner")]
public partial class SphereAligner : global::FrooxEngine.AutoAddChildrenBase

{
    public global::System.Single Radius;
public global::System.Single DistributionOffset;
public global::System.Boolean AlignToNormal;
public UnityEngine.Quaternion RotationOffset;
public global::System.Single NormalizedStart;
public global::System.Single NormalizedEnd;
public global::System.Single HorizontalStart;
public global::System.Single HorizontalEnd;
public System.Collections.Generic.List<global::FrooxEngine.SphereAligner.Item> Items;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("DistributionOffset", DistributionOffset.ToResoniteLinkField());
members.Add("AlignToNormal", AlignToNormal.ToResoniteLinkField());
members.Add("RotationOffset", RotationOffset.ToResoniteLinkField());
members.Add("NormalizedStart", NormalizedStart.ToResoniteLinkField());
members.Add("NormalizedEnd", NormalizedEnd.ToResoniteLinkField());
members.Add("HorizontalStart", HorizontalStart.ToResoniteLinkField());
members.Add("HorizontalEnd", HorizontalEnd.ToResoniteLinkField());
members.Add("Items", new ResoniteLink.SyncList()
{
    Elements = Items.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
