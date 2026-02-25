
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FingerPoseModifier
// Generated on: středa 25. února 2026 16:14:46
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FingerPoseModifier")]
public partial class FingerPoseModifier : global::FrooxEngine.FingerPoseProcessor

{
    public global::FrooxEngine.IFingerPoseSourceComponent Source;
public global::FrooxEngine.FingerPoseModifier.FingerOffsets LeftOffsets;
public global::FrooxEngine.FingerPoseModifier.FingerOffsets RightOffsets;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source.ToResoniteReference(context));
members.Add("LeftOffsets", new ResoniteLink.SyncObject() { Members = LeftOffsets.CollectMembers(context) });
members.Add("RightOffsets", new ResoniteLink.SyncObject() { Members = RightOffsets.CollectMembers(context) });
}

}
}
