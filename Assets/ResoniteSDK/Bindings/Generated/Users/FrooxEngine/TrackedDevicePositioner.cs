
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TrackedDevicePositioner
// Generated on: úterý 24. února 2026 18:20:21
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DeviceIndex", DeviceIndex.ToResoniteLinkField());
members.Add("CorrespondingBodyNode", CorrespondingBodyNode.ToResoniteLinkField());
members.Add("AutoBodyNode", AutoBodyNode.ToResoniteLinkField());
members.Add("AlwaysRenderModel", AlwaysRenderModel.ToResoniteLinkField());
members.Add("ReferenceModel", ReferenceModel.ToResoniteReference(context));
members.Add("BodyNodeRoot", BodyNodeRoot.ToResoniteReference(context));
members.Add("ObjectSlot", ObjectSlot.ToResoniteReference(context));
members.Add("IsTracking", IsTracking.ToResoniteLinkField());
members.Add("IsActive", IsActive.ToResoniteLinkField());
members.Add("IsSimulated", IsSimulated.ToResoniteLinkField());
members.Add("CreateAvatarObjectSlot", CreateAvatarObjectSlot.ToResoniteLinkField());
members.Add("PoseFilter", PoseFilter.ToResoniteReference(context));
}

}
}
