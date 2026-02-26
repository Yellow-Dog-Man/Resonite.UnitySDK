
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CopyGlobalTransform
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CopyGlobalTransform")]
public partial class CopyGlobalTransform : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Source_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _posDrive { get => _posDrive_Element.Data; set => _posDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _posDrive_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotDrive { get => _rotDrive_Element.Data; set => _rotDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rotDrive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("_posDrive", _posDrive_Element.ToLinkReference(context));
members.Add("_rotDrive", _rotDrive_Element.ToLinkReference(context));
}

}
}
