
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScreenViewPermissions
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScreenViewPermissions")]
public partial class ScreenViewPermissions : global::FrooxEngine.PermissionsComponent

{
    public global::FrooxEngine.ListFilterMode ListMode;
public System.Collections.Generic.List<global::FrooxEngine.ScreenViewPermissions.ViewTargettingFilter> ViewFilters;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ListMode", ListMode.ToResoniteLinkField());
members.Add("ViewFilters", new ResoniteLink.SyncList()
{
    Elements = ViewFilters.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
