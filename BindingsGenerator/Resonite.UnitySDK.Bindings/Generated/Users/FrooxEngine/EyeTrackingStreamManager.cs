
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EyeTrackingStreamManager
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.EyeTrackingStreamManager")]
public partial class EyeTrackingStreamManager : global::FrooxEngine.UserRootComponent, global::FrooxEngine.IEyeDataSourceComponent

{
    public global::FrooxEngine.User User { get => User_Element.Data; set => User_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> User_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> ConvergenceDistance { get => ConvergenceDistance_Element.Data; set => ConvergenceDistance_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> ConvergenceDistance_Element = new();
public global::FrooxEngine.ValueStream<global::System.Boolean> IsEyeTrackingActive { get => IsEyeTrackingActive_Element.Data; set => IsEyeTrackingActive_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Boolean>>, global::FrooxEngine.ValueStream<global::System.Boolean>> IsEyeTrackingActive_Element = new();
public global::FrooxEngine.EyeTrackingStreamManager.EyeStreams LeftEyeStreams = new();
public global::FrooxEngine.EyeTrackingStreamManager.EyeStreams RightEyeStreams = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User_Element.ToLinkReference(context));
members.Add("ConvergenceDistance", ConvergenceDistance_Element.ToLinkReference(context));
members.Add("IsEyeTrackingActive", IsEyeTrackingActive_Element.ToLinkReference(context));
members.Add("LeftEyeStreams", LeftEyeStreams.ToLinkSyncObject(context));
members.Add("RightEyeStreams", RightEyeStreams.ToLinkSyncObject(context));
}

}
}
