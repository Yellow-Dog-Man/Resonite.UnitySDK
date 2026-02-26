
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RemoteConnectionPointDriver
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RemoteConnectionPointDriver")]
public partial class RemoteConnectionPointDriver : global::FrooxEngine.Component

{
    public global::System.Single FilterThreshold { get => FilterThreshold_Element.Data; set => FilterThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FilterThreshold_Element = new();
public global::FrooxEngine.Slot TargetPoint { get => TargetPoint_Element.Data; set => TargetPoint_Element.Data = value; }
public Field<global::FrooxEngine.TransformRelayRef, global::FrooxEngine.Slot> TargetPoint_Element = new();
public UnityEngine.Vector3 TargetVector { get => TargetVector_Element.Data; set => TargetVector_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> TargetVector_Element = new();
public global::System.Single TargetSize { get => TargetSize_Element.Data; set => TargetSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TargetSize_Element = new();
public UnityEngine.Quaternion TargetOrientation { get => TargetOrientation_Element.Data; set => TargetOrientation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> TargetOrientation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> LocalPoint { get => LocalPoint_Element.Data; set => LocalPoint_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> LocalPoint_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> LocalVector { get => LocalVector_Element.Data; set => LocalVector_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> LocalVector_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> LocalOrientation { get => LocalOrientation_Element.Data; set => LocalOrientation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> LocalOrientation_Element = new();
public global::FrooxEngine.IField<global::System.Single> LocalSize { get => LocalSize_Element.Data; set => LocalSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> LocalSize_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FilterThreshold", FilterThreshold_Element.ToLinkField(context));
members.Add("TargetPoint", TargetPoint_Element.ToLinkReference(context));
members.Add("TargetVector", TargetVector_Element.ToLinkField(context));
members.Add("TargetSize", TargetSize_Element.ToLinkField(context));
members.Add("TargetOrientation", TargetOrientation_Element.ToLinkField(context));
members.Add("LocalPoint", LocalPoint_Element.ToLinkReference(context));
members.Add("LocalVector", LocalVector_Element.ToLinkReference(context));
members.Add("LocalOrientation", LocalOrientation_Element.ToLinkReference(context));
members.Add("LocalSize", LocalSize_Element.ToLinkReference(context));
}

}
}
