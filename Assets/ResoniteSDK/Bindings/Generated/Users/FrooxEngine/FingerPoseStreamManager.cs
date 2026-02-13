
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FingerPoseStreamManager
// Generated on: pátek 13. února 2026 5:52:38
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FingerPoseStreamManager")]
public partial class FingerPoseStreamManager : global::FrooxEngine.UserRootComponent, global::FrooxEngine.IFingerPoseSourceComponent

{
    public global::FrooxEngine.User User;
public global::FrooxEngine.ValueStream<global::System.Boolean> LeftIsTracking;
public global::FrooxEngine.ValueStream<global::System.Boolean> RightIsTracking;
public global::FrooxEngine.MultiValueStream<UnityEngine.Quaternion> Stream;
public global::System.Boolean TracksMetacarpals;
public global::FrooxEngine.UserPoseController PoseController;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("User", new ResoniteLink.Reference() { });
members.Add("LeftIsTracking", new ResoniteLink.Reference() { });
members.Add("RightIsTracking", new ResoniteLink.Reference() { });
members.Add("Stream", new ResoniteLink.Reference() { });
members.Add("TracksMetacarpals", TracksMetacarpals.ToResoniteLinkField());
members.Add("PoseController", new ResoniteLink.Reference() { });
}

}
}
