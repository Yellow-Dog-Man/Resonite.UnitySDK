
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FingerPoseModifier
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FingerPoseModifier")]
public partial class FingerPoseModifier : global::FrooxEngine.FingerPoseProcessor

{
    public global::FrooxEngine.IFingerPoseSourceComponent Source;
public global::FrooxEngine.FingerPoseModifier.FingerOffsets LeftOffsets;
public global::FrooxEngine.FingerPoseModifier.FingerOffsets RightOffsets;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Source", new ResoniteLink.Reference() { });
members.Add("LeftOffsets", new ResoniteLink.SyncObject() { Members = LeftOffsets.CollectMembers() });
members.Add("RightOffsets", new ResoniteLink.SyncObject() { Members = RightOffsets.CollectMembers() });
}

}
}
