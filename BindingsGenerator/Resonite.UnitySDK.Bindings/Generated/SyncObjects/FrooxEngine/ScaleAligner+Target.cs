
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleAligner+Target
// Generated on: středa 25. února 2026 16:14:30
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
