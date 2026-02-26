
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScreenViewPermissions
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScreenViewPermissions")]
public partial class ScreenViewPermissions : global::FrooxEngine.PermissionsComponent

{
    public global::FrooxEngine.ListFilterMode ListMode { get => ListMode_Element.Data; set => ListMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ListFilterMode>, global::FrooxEngine.ListFilterMode> ListMode_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.ScreenViewPermissions.ViewTargettingFilter>, global::FrooxEngine.ScreenViewPermissions.ViewTargettingFilter> ViewFilters = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ListMode", ListMode_Element.ToLinkField(context));
members.Add("ViewFilters", ViewFilters.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
