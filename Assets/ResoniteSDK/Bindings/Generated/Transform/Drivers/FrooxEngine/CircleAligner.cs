
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CircleAligner
// Generated on: pátek 13. února 2026 23:23:09
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Axis", Axis.ToResoniteLinkField());
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("Arc", Arc.ToResoniteLinkField());
members.Add("FillWholeArc", FillWholeArc.ToResoniteLinkField());
members.Add("RotationOffset", RotationOffset.ToResoniteLinkField());
members.Add("Items", new ResoniteLink.SyncList()
{
    Elements = Items.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
}

}
}
