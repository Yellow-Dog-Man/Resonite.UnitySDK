
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HandPoser+FingerSegment
// Generated on: čtvrtek 19. února 2026 8:00:33
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public UnityEngine.Quaternion CoordinateCompensation;
public global::FrooxEngine.Slot Root;
public UnityEngine.Quaternion OriginalRotation;
public global::FrooxEngine.IField<UnityEngine.Quaternion> RotationDrive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CoordinateCompensation", CoordinateCompensation.ToResoniteLinkField());
members.Add("Root", Root.ToResoniteReference(context));
members.Add("OriginalRotation", OriginalRotation.ToResoniteLinkField());
members.Add("RotationDrive", RotationDrive.ToResoniteReference(context));
}

}
            }
}
