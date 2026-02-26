
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicBoneChain+Bone
// Generated on: čtvrtek 26. února 2026 10:03:41
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class DynamicBoneChain
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicBoneChain+Bone")]
public partial class Bone : global::FrooxEngine.SyncObject, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.Slot BoneSlot { get => BoneSlot_Element.Data; set => BoneSlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> BoneSlot_Element = new();
public UnityEngine.Vector3 OrigPosition { get => OrigPosition_Element.Data; set => OrigPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> OrigPosition_Element = new();
public UnityEngine.Quaternion OrigRotation { get => OrigRotation_Element.Data; set => OrigRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> OrigRotation_Element = new();
public global::System.Single RadiusModifier { get => RadiusModifier_Element.Data; set => RadiusModifier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RadiusModifier_Element = new();
public global::FrooxEngine.DynamicBoneChain.Bone GrabOverride { get => GrabOverride_Element.Data; set => GrabOverride_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.DynamicBoneChain.Bone>, global::FrooxEngine.DynamicBoneChain.Bone> GrabOverride_Element = new();
public global::System.Boolean Collide { get => Collide_Element.Data; set => Collide_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Collide_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _posDrive { get => _posDrive_Element.Data; set => _posDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _posDrive_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotDrive { get => _rotDrive_Element.Data; set => _rotDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rotDrive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BoneSlot", BoneSlot_Element.Data.ToResoniteReference(context));
members.Add("OrigPosition", OrigPosition_Element.Data.ToResoniteLinkField());
members.Add("OrigRotation", OrigRotation_Element.Data.ToResoniteLinkField());
members.Add("RadiusModifier", RadiusModifier_Element.Data.ToResoniteLinkField());
members.Add("GrabOverride", GrabOverride_Element.Data.ToResoniteReference(context));
members.Add("Collide", Collide_Element.Data.ToResoniteLinkField());
members.Add("_posDrive", _posDrive_Element.Data.ToResoniteReference(context));
members.Add("_rotDrive", _rotDrive_Element.Data.ToResoniteReference(context));
}

}
            }
}
