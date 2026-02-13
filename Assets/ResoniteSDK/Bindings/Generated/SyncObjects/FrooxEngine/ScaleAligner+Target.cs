
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleAligner+Target
// Generated on: pátek 13. února 2026 23:23:09
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
    public partial class ScaleAligner
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaleAligner+Target")]
public partial class Target : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.Slot TargetSlot;
public global::FrooxEngine.IField<UnityEngine.Vector3> ScaleDrive;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetSlot", new ResoniteLink.Reference() { });
members.Add("ScaleDrive", new ResoniteLink.Reference() { });
}

}
            }
}
