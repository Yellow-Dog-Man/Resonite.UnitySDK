
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractionHandlerPermissions
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractionHandlerPermissions")]
public partial class InteractionHandlerPermissions : global::FrooxEngine.PermissionsComponent

{
    public global::System.Boolean AllowOnlyWhitelistedTools { get => AllowOnlyWhitelistedTools_Element.Data; set => AllowOnlyWhitelistedTools_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowOnlyWhitelistedTools_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.InteractionHandlerPermissions.ToolRule>, global::FrooxEngine.InteractionHandlerPermissions.ToolRule> ToolRules = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AllowOnlyWhitelistedTools", AllowOnlyWhitelistedTools_Element.Data.ToResoniteLinkField());
members.Add("ToolRules", new ResoniteLink.SyncList()
{
    Elements = ToolRules.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
