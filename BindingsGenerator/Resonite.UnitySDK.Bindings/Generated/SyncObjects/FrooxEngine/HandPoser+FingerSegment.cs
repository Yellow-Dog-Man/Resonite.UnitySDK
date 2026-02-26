
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HandPoser+FingerSegment
// Generated on: čtvrtek 26. února 2026 15:09:17
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class HandPoser
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HandPoser+FingerSegment")]
public partial class FingerSegment : global::FrooxEngine.SyncObject

{
    public UnityEngine.Quaternion CoordinateCompensation { get => CoordinateCompensation_Element.Data; set => CoordinateCompensation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> CoordinateCompensation_Element = new();
public global::FrooxEngine.Slot Root { get => Root_Element.Data; set => Root_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Root_Element = new();
public UnityEngine.Quaternion OriginalRotation { get => OriginalRotation_Element.Data; set => OriginalRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> OriginalRotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> RotationDrive { get => RotationDrive_Element.Data; set => RotationDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> RotationDrive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CoordinateCompensation", CoordinateCompensation_Element.ToLinkField(context));
members.Add("Root", Root_Element.ToLinkReference(context));
members.Add("OriginalRotation", OriginalRotation_Element.ToLinkField(context));
members.Add("RotationDrive", RotationDrive_Element.ToLinkReference(context));
}

}
            }
}
