
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugHandOffsetCompensation
// Generated on: pátek 6. března 2026 14:18:08
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public UnityEngine.Vector3 LeftHandPosition { get => LeftHandPosition_Element.Data; set => LeftHandPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LeftHandPosition_Element = new();
public UnityEngine.Quaternion LeftHandRotation { get => LeftHandRotation_Element.Data; set => LeftHandRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> LeftHandRotation_Element = new();
public UnityEngine.Vector3 RightHandPosition { get => RightHandPosition_Element.Data; set => RightHandPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> RightHandPosition_Element = new();
public UnityEngine.Quaternion RightHandRotation { get => RightHandRotation_Element.Data; set => RightHandRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> RightHandRotation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LeftHandPosition", LeftHandPosition_Element.ToLinkField(context));
members.Add("LeftHandRotation", LeftHandRotation_Element.ToLinkField(context));
members.Add("RightHandPosition", RightHandPosition_Element.ToLinkField(context));
members.Add("RightHandRotation", RightHandRotation_Element.ToLinkField(context));
}

}
}
