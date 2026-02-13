
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugHandOffsetCompensation
// Generated on: pátek 13. února 2026 23:21:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugHandOffsetCompensation")]
public partial class DebugHandOffsetCompensation : global::FrooxEngine.Component

{
    public UnityEngine.Vector3 LeftHandPosition;
public UnityEngine.Quaternion LeftHandRotation;
public UnityEngine.Vector3 RightHandPosition;
public UnityEngine.Quaternion RightHandRotation;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("LeftHandPosition", LeftHandPosition.ToResoniteLinkField());
members.Add("LeftHandRotation", LeftHandRotation.ToResoniteLinkField());
members.Add("RightHandPosition", RightHandPosition.ToResoniteLinkField());
members.Add("RightHandRotation", RightHandRotation.ToResoniteLinkField());
}

}
}
