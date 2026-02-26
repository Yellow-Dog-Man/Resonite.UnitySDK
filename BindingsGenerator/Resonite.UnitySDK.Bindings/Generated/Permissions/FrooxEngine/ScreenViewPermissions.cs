
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScreenViewPermissions
// Generated on: čtvrtek 26. února 2026 10:03:41
// Resonite version: 2026.2.25.455
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
members.Add("ListMode", ListMode_Element.Data.ToResoniteLinkField());
members.Add("ViewFilters", new ResoniteLink.SyncList()
{
    Elements = ViewFilters.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
