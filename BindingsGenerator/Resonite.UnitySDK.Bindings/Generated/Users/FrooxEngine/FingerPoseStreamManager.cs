
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FingerPoseStreamManager
// Generated on: čtvrtek 26. února 2026 15:09:16
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.User User { get => User_Element.Data; set => User_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> User_Element = new();
public global::FrooxEngine.ValueStream<global::System.Boolean> LeftIsTracking { get => LeftIsTracking_Element.Data; set => LeftIsTracking_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Boolean>>, global::FrooxEngine.ValueStream<global::System.Boolean>> LeftIsTracking_Element = new();
public global::FrooxEngine.ValueStream<global::System.Boolean> RightIsTracking { get => RightIsTracking_Element.Data; set => RightIsTracking_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Boolean>>, global::FrooxEngine.ValueStream<global::System.Boolean>> RightIsTracking_Element = new();
public global::FrooxEngine.MultiValueStream<UnityEngine.Quaternion> Stream { get => Stream_Element.Data; set => Stream_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.MultiValueStream<UnityEngine.Quaternion>>, global::FrooxEngine.MultiValueStream<UnityEngine.Quaternion>> Stream_Element = new();
public global::System.Boolean TracksMetacarpals { get => TracksMetacarpals_Element.Data; set => TracksMetacarpals_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> TracksMetacarpals_Element = new();
public global::FrooxEngine.UserPoseController PoseController { get => PoseController_Element.Data; set => PoseController_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UserPoseController>, global::FrooxEngine.UserPoseController> PoseController_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User_Element.ToLinkReference(context));
members.Add("LeftIsTracking", LeftIsTracking_Element.ToLinkReference(context));
members.Add("RightIsTracking", RightIsTracking_Element.ToLinkReference(context));
members.Add("Stream", Stream_Element.ToLinkReference(context));
members.Add("TracksMetacarpals", TracksMetacarpals_Element.ToLinkField(context));
members.Add("PoseController", PoseController_Element.ToLinkReference(context));
}

}
}
