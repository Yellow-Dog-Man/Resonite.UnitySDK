
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugHandOffsetCompensation
// Generated on: sobota 14. února 2026 8:57:05
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LeftHandPosition", LeftHandPosition.ToResoniteLinkField());
members.Add("LeftHandRotation", LeftHandRotation.ToResoniteLinkField());
members.Add("RightHandPosition", RightHandPosition.ToResoniteLinkField());
members.Add("RightHandRotation", RightHandRotation.ToResoniteLinkField());
}

}
}
