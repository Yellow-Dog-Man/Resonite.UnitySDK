
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CircleAligner
// Generated on: úterý 24. února 2026 18:20:13
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CircleAligner")]
public partial class CircleAligner : global::FrooxEngine.AutoAddChildrenBase

{
    public UnityEngine.Vector3 Axis;
public global::System.Single Radius;
public global::System.Single Offset;
public global::System.Single Arc;
public global::System.Boolean FillWholeArc;
public global::System.Single RotationOffset;
public System.Collections.Generic.List<global::FrooxEngine.CircleAligner.Item> Items;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Axis", Axis.ToResoniteLinkField());
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("Arc", Arc.ToResoniteLinkField());
members.Add("FillWholeArc", FillWholeArc.ToResoniteLinkField());
members.Add("RotationOffset", RotationOffset.ToResoniteLinkField());
members.Add("Items", new ResoniteLink.SyncList()
{
    Elements = Items.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
