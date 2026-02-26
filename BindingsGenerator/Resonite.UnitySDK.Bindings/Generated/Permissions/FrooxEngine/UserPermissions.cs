
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserPermissions
// Generated on: čtvrtek 26. února 2026 15:08:02
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserPermissions")]
public partial class UserPermissions : global::FrooxEngine.PermissionsComponent

{
    public global::System.Boolean AllowEnableEditMode { get => AllowEnableEditMode_Element.Data; set => AllowEnableEditMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowEnableEditMode_Element = new();
public global::System.Boolean AllowRespawn { get => AllowRespawn_Element.Data; set => AllowRespawn_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowRespawn_Element = new();
public global::System.Boolean AllowSilence { get => AllowSilence_Element.Data; set => AllowSilence_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowSilence_Element = new();
public global::System.Boolean AllowKick { get => AllowKick_Element.Data; set => AllowKick_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowKick_Element = new();
public global::System.Boolean AllowBan { get => AllowBan_Element.Data; set => AllowBan_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowBan_Element = new();
public global::System.Boolean AllowAssignRoles { get => AllowAssignRoles_Element.Data; set => AllowAssignRoles_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowAssignRoles_Element = new();
public global::System.Boolean AllowSeeOtherRoles { get => AllowSeeOtherRoles_Element.Data; set => AllowSeeOtherRoles_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowSeeOtherRoles_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AllowEnableEditMode", AllowEnableEditMode_Element.ToLinkField(context));
members.Add("AllowRespawn", AllowRespawn_Element.ToLinkField(context));
members.Add("AllowSilence", AllowSilence_Element.ToLinkField(context));
members.Add("AllowKick", AllowKick_Element.ToLinkField(context));
members.Add("AllowBan", AllowBan_Element.ToLinkField(context));
members.Add("AllowAssignRoles", AllowAssignRoles_Element.ToLinkField(context));
members.Add("AllowSeeOtherRoles", AllowSeeOtherRoles_Element.ToLinkField(context));
}

}
}
