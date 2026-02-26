
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CircleAligner
// Generated on: čtvrtek 26. února 2026 12:28:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CircleAligner")]
public partial class CircleAligner : global::FrooxEngine.AutoAddChildrenBase

{
    public UnityEngine.Vector3 Axis { get => Axis_Element.Data; set => Axis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Axis_Element = new();
public global::System.Single Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius_Element = new();
public global::System.Single Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Offset_Element = new();
public global::System.Single Arc { get => Arc_Element.Data; set => Arc_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Arc_Element = new();
public global::System.Boolean FillWholeArc { get => FillWholeArc_Element.Data; set => FillWholeArc_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FillWholeArc_Element = new();
public global::System.Single RotationOffset { get => RotationOffset_Element.Data; set => RotationOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RotationOffset_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.CircleAligner.Item>, global::FrooxEngine.CircleAligner.Item> Items = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Axis", Axis_Element.ToLinkField(context));
members.Add("Radius", Radius_Element.ToLinkField(context));
members.Add("Offset", Offset_Element.ToLinkField(context));
members.Add("Arc", Arc_Element.ToLinkField(context));
members.Add("FillWholeArc", FillWholeArc_Element.ToLinkField(context));
members.Add("RotationOffset", RotationOffset_Element.ToLinkField(context));
members.Add("Items", Items.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
