
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EyeTrackingStreamManager
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.EyeTrackingStreamManager")]
public partial class EyeTrackingStreamManager : global::FrooxEngine.UserRootComponent, global::FrooxEngine.IEyeDataSourceComponent

{
    public global::FrooxEngine.User User;
public global::FrooxEngine.ValueStream<global::System.Single> ConvergenceDistance;
public global::FrooxEngine.ValueStream<global::System.Boolean> IsEyeTrackingActive;
public global::FrooxEngine.EyeTrackingStreamManager.EyeStreams LeftEyeStreams;
public global::FrooxEngine.EyeTrackingStreamManager.EyeStreams RightEyeStreams;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User.ToResoniteReference(context));
members.Add("ConvergenceDistance", ConvergenceDistance.ToResoniteReference(context));
members.Add("IsEyeTrackingActive", IsEyeTrackingActive.ToResoniteReference(context));
members.Add("LeftEyeStreams", new ResoniteLink.SyncObject() { Members = LeftEyeStreams.CollectMembers(context) });
members.Add("RightEyeStreams", new ResoniteLink.SyncObject() { Members = RightEyeStreams.CollectMembers(context) });
}

}
}
