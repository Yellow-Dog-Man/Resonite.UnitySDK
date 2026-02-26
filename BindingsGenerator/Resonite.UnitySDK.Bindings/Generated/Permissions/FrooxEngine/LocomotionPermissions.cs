
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionPermissions
// Generated on: čtvrtek 26. února 2026 12:26:57
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionPermissions")]
public partial class LocomotionPermissions : global::FrooxEngine.PermissionsComponent

{
    public global::FrooxEngine.ListFilterMode LocomotionListMode { get => LocomotionListMode_Element.Data; set => LocomotionListMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ListFilterMode>, global::FrooxEngine.ListFilterMode> LocomotionListMode_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.LocomotionPermissions.LocomotionFilter>, global::FrooxEngine.LocomotionPermissions.LocomotionFilter> Locomotions = new();
public global::FrooxEngine.PermissionState Scaling { get => Scaling_Element.Data; set => Scaling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PermissionState>, global::FrooxEngine.PermissionState> Scaling_Element = new();
public global::System.Single MinScale { get => MinScale_Element.Data; set => MinScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinScale_Element = new();
public global::System.Single MaxScale { get => MaxScale_Element.Data; set => MaxScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxScale_Element = new();
public global::FrooxEngine.PermissionState JumpToUser { get => JumpToUser_Element.Data; set => JumpToUser_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PermissionState>, global::FrooxEngine.PermissionState> JumpToUser_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LocomotionListMode", LocomotionListMode_Element.ToLinkField(context));
members.Add("Locomotions", Locomotions.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("Scaling", Scaling_Element.ToLinkField(context));
members.Add("MinScale", MinScale_Element.ToLinkField(context));
members.Add("MaxScale", MaxScale_Element.ToLinkField(context));
members.Add("JumpToUser", JumpToUser_Element.ToLinkField(context));
}

}
}
