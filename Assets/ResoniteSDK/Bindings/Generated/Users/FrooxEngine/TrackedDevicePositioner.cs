
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TrackedDevicePositioner
// Generated on: pátek 13. února 2026 5:52:31
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TrackedDevicePositioner")]
public partial class TrackedDevicePositioner : global::FrooxEngine.UserRootComponent, global::FrooxEngine.IInputUpdateReceiver

{
    public global::System.Int32 DeviceIndex;
public global::Renderite.Shared.BodyNode CorrespondingBodyNode;
public global::System.Nullable<global::Renderite.Shared.BodyNode> AutoBodyNode;
public global::System.Boolean AlwaysRenderModel;
public global::FrooxEngine.Slot ReferenceModel;
public global::FrooxEngine.Slot BodyNodeRoot;
public global::FrooxEngine.CommonAvatar.AvatarObjectSlot ObjectSlot;
public global::System.Boolean IsTracking;
public global::System.Boolean IsActive;
public global::System.Boolean IsSimulated;
public global::System.Boolean CreateAvatarObjectSlot;
public global::FrooxEngine.UserPoseController PoseFilter;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("DeviceIndex", DeviceIndex.ToResoniteLinkField());
members.Add("CorrespondingBodyNode", CorrespondingBodyNode.ToResoniteLinkField());
members.Add("AutoBodyNode", AutoBodyNode.ToResoniteLinkField());
members.Add("AlwaysRenderModel", AlwaysRenderModel.ToResoniteLinkField());
members.Add("ReferenceModel", new ResoniteLink.Reference() { });
members.Add("BodyNodeRoot", new ResoniteLink.Reference() { });
members.Add("ObjectSlot", new ResoniteLink.Reference() { });
members.Add("IsTracking", IsTracking.ToResoniteLinkField());
members.Add("IsActive", IsActive.ToResoniteLinkField());
members.Add("IsSimulated", IsSimulated.ToResoniteLinkField());
members.Add("CreateAvatarObjectSlot", CreateAvatarObjectSlot.ToResoniteLinkField());
members.Add("PoseFilter", new ResoniteLink.Reference() { });
}

}
}
