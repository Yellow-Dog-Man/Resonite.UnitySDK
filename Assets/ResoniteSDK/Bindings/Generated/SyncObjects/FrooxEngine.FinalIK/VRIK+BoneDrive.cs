
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.VRIK+BoneDrive
// Generated on: čtvrtek 19. února 2026 8:00:27
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::FrooxEngine.IField<UnityEngine.Vector3> Position;
public global::FrooxEngine.IField<UnityEngine.Quaternion> Rotation;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Position", Position.ToResoniteReference(context));
members.Add("Rotation", Rotation.ToResoniteReference(context));
}

}
            }
}
