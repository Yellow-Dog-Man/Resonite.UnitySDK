
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PointAnchor
// Generated on: čtvrtek 26. února 2026 12:28:05
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PointAnchor")]
public partial class PointAnchor : global::FrooxEngine.Component, global::FrooxEngine.IPointSnappable

{
    public global::FrooxEngine.Slot OwnerRoot { get => OwnerRoot_Element.Data; set => OwnerRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> OwnerRoot_Element = new();
public global::FrooxEngine.Slot SnapParent { get => SnapParent_Element.Data; set => SnapParent_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> SnapParent_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OwnerRoot", OwnerRoot_Element.ToLinkReference(context));
members.Add("SnapParent", SnapParent_Element.ToLinkReference(context));
}

}
}
