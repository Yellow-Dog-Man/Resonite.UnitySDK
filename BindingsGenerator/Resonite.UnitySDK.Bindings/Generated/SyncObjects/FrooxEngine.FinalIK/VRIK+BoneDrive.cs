
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.VRIK+BoneDrive
// Generated on: čtvrtek 26. února 2026 12:28:11
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FinalIK
{
    public partial class VRIK
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FinalIK.VRIK+BoneDrive")]
public partial class BoneDrive : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IField<UnityEngine.Vector3> Position { get => Position_Element.Data; set => Position_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> Position_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> Rotation { get => Rotation_Element.Data; set => Rotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> Rotation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Position", Position_Element.ToLinkReference(context));
members.Add("Rotation", Rotation_Element.ToLinkReference(context));
}

}
            }
}
