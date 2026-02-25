
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FingerPoseStreamManager
// Generated on: středa 25. února 2026 16:14:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FingerPoseStreamManager")]
public partial class FingerPoseStreamManager : global::FrooxEngine.UserRootComponent, global::FrooxEngine.IFingerPoseSourceComponent

{
    public global::FrooxEngine.User User;
public global::FrooxEngine.ValueStream<global::System.Boolean> LeftIsTracking;
public global::FrooxEngine.ValueStream<global::System.Boolean> RightIsTracking;
public global::FrooxEngine.MultiValueStream<UnityEngine.Quaternion> Stream;
public global::System.Boolean TracksMetacarpals;
public global::FrooxEngine.UserPoseController PoseController;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User.ToResoniteReference(context));
members.Add("LeftIsTracking", LeftIsTracking.ToResoniteReference(context));
members.Add("RightIsTracking", RightIsTracking.ToResoniteReference(context));
members.Add("Stream", Stream.ToResoniteReference(context));
members.Add("TracksMetacarpals", TracksMetacarpals.ToResoniteLinkField());
members.Add("PoseController", PoseController.ToResoniteReference(context));
}

}
}
