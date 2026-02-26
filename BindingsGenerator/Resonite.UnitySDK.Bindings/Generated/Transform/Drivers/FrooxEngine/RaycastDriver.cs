
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RaycastDriver
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RaycastDriver")]
public partial class RaycastDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot IgnoreHierarchy { get => IgnoreHierarchy_Element.Data; set => IgnoreHierarchy_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> IgnoreHierarchy_Element = new();
public global::System.Single FilterDistance { get => FilterDistance_Element.Data; set => FilterDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FilterDistance_Element = new();
public global::FrooxEngine.Slot Origin { get => Origin_Element.Data; set => Origin_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Origin_Element = new();
public UnityEngine.Vector3 Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Offset_Element = new();
public UnityEngine.Vector3 Direction { get => Direction_Element.Data; set => Direction_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Direction_Element = new();
public global::System.Single MaxDistance { get => MaxDistance_Element.Data; set => MaxDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxDistance_Element = new();
public global::System.Single NoHitDistance { get => NoHitDistance_Element.Data; set => NoHitDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NoHitDistance_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _positionDrive { get => _positionDrive_Element.Data; set => _positionDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _positionDrive_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotationDrive { get => _rotationDrive_Element.Data; set => _rotationDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rotationDrive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IgnoreHierarchy", IgnoreHierarchy_Element.ToLinkReference(context));
members.Add("FilterDistance", FilterDistance_Element.ToLinkField(context));
members.Add("Origin", Origin_Element.ToLinkReference(context));
members.Add("Offset", Offset_Element.ToLinkField(context));
members.Add("Direction", Direction_Element.ToLinkField(context));
members.Add("MaxDistance", MaxDistance_Element.ToLinkField(context));
members.Add("NoHitDistance", NoHitDistance_Element.ToLinkField(context));
members.Add("_positionDrive", _positionDrive_Element.ToLinkReference(context));
members.Add("_rotationDrive", _rotationDrive_Element.ToLinkReference(context));
}

}
}
