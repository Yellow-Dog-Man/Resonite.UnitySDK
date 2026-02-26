
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlotGizmo+AnchorInfo
// Generated on: čtvrtek 26. února 2026 12:28:13
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
    public partial class SlotGizmo
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SlotGizmo+AnchorInfo")]
public partial class AnchorInfo : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.PointAnchor anchor { get => anchor_Element.Data; set => anchor_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PointAnchor>, global::FrooxEngine.PointAnchor> anchor_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> posDrive { get => posDrive_Element.Data; set => posDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> posDrive_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> scaleDrive { get => scaleDrive_Element.Data; set => scaleDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> scaleDrive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("anchor", anchor_Element.ToLinkReference(context));
members.Add("posDrive", posDrive_Element.ToLinkReference(context));
members.Add("scaleDrive", scaleDrive_Element.ToLinkReference(context));
}

}
            }
}
