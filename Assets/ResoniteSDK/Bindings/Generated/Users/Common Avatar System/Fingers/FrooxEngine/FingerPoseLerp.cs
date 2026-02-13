
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FingerPoseLerp
// Generated on: pátek 13. února 2026 5:52:39
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FingerPoseLerp")]
public partial class FingerPoseLerp : global::FrooxEngine.FingerPoseProcessor

{
    public global::FrooxEngine.IFingerPoseSourceComponent A;
public global::FrooxEngine.IFingerPoseSourceComponent B;
public global::System.Single Lerp;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("A", new ResoniteLink.Reference() { });
members.Add("B", new ResoniteLink.Reference() { });
members.Add("Lerp", Lerp.ToResoniteLinkField());
}

}
}
