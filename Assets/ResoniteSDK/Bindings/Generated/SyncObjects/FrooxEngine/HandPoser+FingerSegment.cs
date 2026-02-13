
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HandPoser+FingerSegment
// Generated on: pátek 13. února 2026 23:23:20
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("CoordinateCompensation", CoordinateCompensation.ToResoniteLinkField());
members.Add("Root", new ResoniteLink.Reference() { });
members.Add("OriginalRotation", OriginalRotation.ToResoniteLinkField());
members.Add("RotationDrive", new ResoniteLink.Reference() { });
}

}
            }
}
