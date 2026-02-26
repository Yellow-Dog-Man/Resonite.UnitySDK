
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SnapGrid
// Generated on: čtvrtek 26. února 2026 12:28:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SnapGrid")]
public partial class SnapGrid : global::FrooxEngine.Component, global::FrooxEngine.IPointSnappable

{
    public UnityEngine.Vector3 BoundsSize { get => BoundsSize_Element.Data; set => BoundsSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> BoundsSize_Element = new();
public UnityEngine.Vector3 GridSize { get => GridSize_Element.Data; set => GridSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> GridSize_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> ColliderSize { get => ColliderSize_Element.Data; set => ColliderSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> ColliderSize_Element = new();
public global::FrooxEngine.Slot SnapParent { get => SnapParent_Element.Data; set => SnapParent_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> SnapParent_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BoundsSize", BoundsSize_Element.ToLinkField(context));
members.Add("GridSize", GridSize_Element.ToLinkField(context));
members.Add("ColliderSize", ColliderSize_Element.ToLinkReference(context));
members.Add("SnapParent", SnapParent_Element.ToLinkReference(context));
}

}
}
