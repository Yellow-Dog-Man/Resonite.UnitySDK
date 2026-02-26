
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SphereAligner
// Generated on: čtvrtek 26. února 2026 10:04:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SphereAligner")]
public partial class SphereAligner : global::FrooxEngine.AutoAddChildrenBase

{
    public global::System.Single Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius_Element = new();
public global::System.Single DistributionOffset { get => DistributionOffset_Element.Data; set => DistributionOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DistributionOffset_Element = new();
public global::System.Boolean AlignToNormal { get => AlignToNormal_Element.Data; set => AlignToNormal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AlignToNormal_Element = new();
public UnityEngine.Quaternion RotationOffset { get => RotationOffset_Element.Data; set => RotationOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> RotationOffset_Element = new();
public global::System.Single NormalizedStart { get => NormalizedStart_Element.Data; set => NormalizedStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalizedStart_Element = new();
public global::System.Single NormalizedEnd { get => NormalizedEnd_Element.Data; set => NormalizedEnd_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalizedEnd_Element = new();
public global::System.Single HorizontalStart { get => HorizontalStart_Element.Data; set => HorizontalStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HorizontalStart_Element = new();
public global::System.Single HorizontalEnd { get => HorizontalEnd_Element.Data; set => HorizontalEnd_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HorizontalEnd_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.SphereAligner.Item>, global::FrooxEngine.SphereAligner.Item> Items = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius_Element.Data.ToResoniteLinkField());
members.Add("DistributionOffset", DistributionOffset_Element.Data.ToResoniteLinkField());
members.Add("AlignToNormal", AlignToNormal_Element.Data.ToResoniteLinkField());
members.Add("RotationOffset", RotationOffset_Element.Data.ToResoniteLinkField());
members.Add("NormalizedStart", NormalizedStart_Element.Data.ToResoniteLinkField());
members.Add("NormalizedEnd", NormalizedEnd_Element.Data.ToResoniteLinkField());
members.Add("HorizontalStart", HorizontalStart_Element.Data.ToResoniteLinkField());
members.Add("HorizontalEnd", HorizontalEnd_Element.Data.ToResoniteLinkField());
members.Add("Items", new ResoniteLink.SyncList()
{
    Elements = Items.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
