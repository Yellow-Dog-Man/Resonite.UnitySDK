
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicBoneChain+Bone
// Generated on: středa 25. února 2026 16:13:11
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
    public global::FrooxEngine.Slot BoneSlot;
public UnityEngine.Vector3 OrigPosition;
public UnityEngine.Quaternion OrigRotation;
public global::System.Single RadiusModifier;
public global::FrooxEngine.DynamicBoneChain.Bone GrabOverride;
public global::System.Boolean Collide;
public global::FrooxEngine.IField<UnityEngine.Vector3> _posDrive;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotDrive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BoneSlot", BoneSlot.ToResoniteReference(context));
members.Add("OrigPosition", OrigPosition.ToResoniteLinkField());
members.Add("OrigRotation", OrigRotation.ToResoniteLinkField());
members.Add("RadiusModifier", RadiusModifier.ToResoniteLinkField());
members.Add("GrabOverride", GrabOverride.ToResoniteReference(context));
members.Add("Collide", Collide.ToResoniteLinkField());
members.Add("_posDrive", _posDrive.ToResoniteReference(context));
members.Add("_rotDrive", _rotDrive.ToResoniteReference(context));
}

}
            }
}
