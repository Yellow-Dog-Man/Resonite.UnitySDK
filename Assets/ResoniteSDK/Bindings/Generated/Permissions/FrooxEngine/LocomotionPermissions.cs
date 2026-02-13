
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionPermissions
// Generated on: pátek 13. února 2026 5:51:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionPermissions")]
public partial class LocomotionPermissions : global::FrooxEngine.PermissionsComponent

{
    public global::FrooxEngine.ListFilterMode LocomotionListMode;
public System.Collections.Generic.List<global::FrooxEngine.LocomotionPermissions.LocomotionFilter> Locomotions;
public global::FrooxEngine.PermissionState Scaling;
public global::System.Single MinScale;
public global::System.Single MaxScale;
public global::FrooxEngine.PermissionState JumpToUser;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("LocomotionListMode", LocomotionListMode.ToResoniteLinkField());
members.Add("Locomotions", new ResoniteLink.SyncList()
{
    Elements = Locomotions.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
members.Add("Scaling", Scaling.ToResoniteLinkField());
members.Add("MinScale", MinScale.ToResoniteLinkField());
members.Add("MaxScale", MaxScale.ToResoniteLinkField());
members.Add("JumpToUser", JumpToUser.ToResoniteLinkField());
}

}
}
