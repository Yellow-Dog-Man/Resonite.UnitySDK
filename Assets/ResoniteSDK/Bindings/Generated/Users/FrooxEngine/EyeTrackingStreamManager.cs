
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EyeTrackingStreamManager
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.EyeTrackingStreamManager")]
public partial class EyeTrackingStreamManager : global::FrooxEngine.UserRootComponent, global::FrooxEngine.IEyeDataSourceComponent

{
    public global::FrooxEngine.User User;
public global::FrooxEngine.ValueStream<global::System.Single> ConvergenceDistance;
public global::FrooxEngine.ValueStream<global::System.Boolean> IsEyeTrackingActive;
public global::FrooxEngine.EyeTrackingStreamManager.EyeStreams LeftEyeStreams;
public global::FrooxEngine.EyeTrackingStreamManager.EyeStreams RightEyeStreams;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("User", new ResoniteLink.Reference() { });
members.Add("ConvergenceDistance", new ResoniteLink.Reference() { });
members.Add("IsEyeTrackingActive", new ResoniteLink.Reference() { });
members.Add("LeftEyeStreams", new ResoniteLink.SyncObject() { Members = LeftEyeStreams.CollectMembers() });
members.Add("RightEyeStreams", new ResoniteLink.SyncObject() { Members = RightEyeStreams.CollectMembers() });
}

}
}
