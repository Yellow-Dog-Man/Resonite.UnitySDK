
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserPermissions
// Generated on: čtvrtek 19. února 2026 7:59:01
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserPermissions")]
public partial class UserPermissions : global::FrooxEngine.PermissionsComponent

{
    public global::System.Boolean AllowEnableEditMode;
public global::System.Boolean AllowRespawn;
public global::System.Boolean AllowSilence;
public global::System.Boolean AllowKick;
public global::System.Boolean AllowBan;
public global::System.Boolean AllowAssignRoles;
public global::System.Boolean AllowSeeOtherRoles;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AllowEnableEditMode", AllowEnableEditMode.ToResoniteLinkField());
members.Add("AllowRespawn", AllowRespawn.ToResoniteLinkField());
members.Add("AllowSilence", AllowSilence.ToResoniteLinkField());
members.Add("AllowKick", AllowKick.ToResoniteLinkField());
members.Add("AllowBan", AllowBan.ToResoniteLinkField());
members.Add("AllowAssignRoles", AllowAssignRoles.ToResoniteLinkField());
members.Add("AllowSeeOtherRoles", AllowSeeOtherRoles.ToResoniteLinkField());
}

}
}
