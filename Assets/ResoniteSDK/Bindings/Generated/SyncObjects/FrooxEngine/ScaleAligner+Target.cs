
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleAligner+Target
// Generated on: čtvrtek 19. února 2026 8:00:24
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
    public partial class ScaleAligner
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaleAligner+Target")]
public partial class Target : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.Slot TargetSlot;
public global::FrooxEngine.IField<UnityEngine.Vector3> ScaleDrive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetSlot", TargetSlot.ToResoniteReference(context));
members.Add("ScaleDrive", ScaleDrive.ToResoniteReference(context));
}

}
            }
}
