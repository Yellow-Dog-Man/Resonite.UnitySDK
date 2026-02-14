
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionPermissions
// Generated on: sobota 14. února 2026 8:57:09
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionPermissions")]
public partial class LocomotionPermissions : global::FrooxEngine.PermissionsComponent

{
    public global::FrooxEngine.ListFilterMode LocomotionListMode;
public System.Collections.Generic.List<global::FrooxEngine.LocomotionPermissions.LocomotionFilter> Locomotions;
public global::FrooxEngine.PermissionState Scaling;
public global::System.Single MinScale;
public global::System.Single MaxScale;
public global::FrooxEngine.PermissionState JumpToUser;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LocomotionListMode", LocomotionListMode.ToResoniteLinkField());
members.Add("Locomotions", new ResoniteLink.SyncList()
{
    Elements = Locomotions.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("Scaling", Scaling.ToResoniteLinkField());
members.Add("MinScale", MinScale.ToResoniteLinkField());
members.Add("MaxScale", MaxScale.ToResoniteLinkField());
members.Add("JumpToUser", JumpToUser.ToResoniteLinkField());
}

}
}
