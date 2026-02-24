
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractionHandlerPermissions
// Generated on: úterý 24. února 2026 18:17:53
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::System.Boolean AllowOnlyWhitelistedTools;
public System.Collections.Generic.List<global::FrooxEngine.InteractionHandlerPermissions.ToolRule> ToolRules;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AllowOnlyWhitelistedTools", AllowOnlyWhitelistedTools.ToResoniteLinkField());
members.Add("ToolRules", new ResoniteLink.SyncList()
{
    Elements = ToolRules.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
