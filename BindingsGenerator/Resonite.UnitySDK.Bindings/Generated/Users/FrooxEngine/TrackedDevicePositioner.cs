
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TrackedDevicePositioner
// Generated on: čtvrtek 26. února 2026 15:09:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TrackedDevicePositioner")]
public partial class TrackedDevicePositioner : global::FrooxEngine.UserRootComponent, global::FrooxEngine.IInputUpdateReceiver

{
    public global::System.Int32 DeviceIndex { get => DeviceIndex_Element.Data; set => DeviceIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> DeviceIndex_Element = new();
public global::Renderite.Shared.BodyNode CorrespondingBodyNode { get => CorrespondingBodyNode_Element.Data; set => CorrespondingBodyNode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.BodyNode>, global::Renderite.Shared.BodyNode> CorrespondingBodyNode_Element = new();
public global::System.Nullable<global::Renderite.Shared.BodyNode> AutoBodyNode { get => AutoBodyNode_Element.Data; set => AutoBodyNode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::Renderite.Shared.BodyNode>>, global::System.Nullable<global::Renderite.Shared.BodyNode>> AutoBodyNode_Element = new();
public global::System.Boolean AlwaysRenderModel { get => AlwaysRenderModel_Element.Data; set => AlwaysRenderModel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AlwaysRenderModel_Element = new();
public global::FrooxEngine.Slot ReferenceModel { get => ReferenceModel_Element.Data; set => ReferenceModel_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ReferenceModel_Element = new();
public global::FrooxEngine.Slot BodyNodeRoot { get => BodyNodeRoot_Element.Data; set => BodyNodeRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> BodyNodeRoot_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarObjectSlot ObjectSlot { get => ObjectSlot_Element.Data; set => ObjectSlot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarObjectSlot>, global::FrooxEngine.CommonAvatar.AvatarObjectSlot> ObjectSlot_Element = new();
public global::System.Boolean IsTracking { get => IsTracking_Element.Data; set => IsTracking_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsTracking_Element = new();
public global::System.Boolean IsActive { get => IsActive_Element.Data; set => IsActive_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsActive_Element = new();
public global::System.Boolean IsSimulated { get => IsSimulated_Element.Data; set => IsSimulated_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsSimulated_Element = new();
public global::System.Boolean CreateAvatarObjectSlot { get => CreateAvatarObjectSlot_Element.Data; set => CreateAvatarObjectSlot_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CreateAvatarObjectSlot_Element = new();
public global::FrooxEngine.UserPoseController PoseFilter { get => PoseFilter_Element.Data; set => PoseFilter_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UserPoseController>, global::FrooxEngine.UserPoseController> PoseFilter_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DeviceIndex", DeviceIndex_Element.ToLinkField(context));
members.Add("CorrespondingBodyNode", CorrespondingBodyNode_Element.ToLinkField(context));
members.Add("AutoBodyNode", AutoBodyNode_Element.ToLinkField(context));
members.Add("AlwaysRenderModel", AlwaysRenderModel_Element.ToLinkField(context));
members.Add("ReferenceModel", ReferenceModel_Element.ToLinkReference(context));
members.Add("BodyNodeRoot", BodyNodeRoot_Element.ToLinkReference(context));
members.Add("ObjectSlot", ObjectSlot_Element.ToLinkReference(context));
members.Add("IsTracking", IsTracking_Element.ToLinkField(context));
members.Add("IsActive", IsActive_Element.ToLinkField(context));
members.Add("IsSimulated", IsSimulated_Element.ToLinkField(context));
members.Add("CreateAvatarObjectSlot", CreateAvatarObjectSlot_Element.ToLinkField(context));
members.Add("PoseFilter", PoseFilter_Element.ToLinkReference(context));
}

}
}
