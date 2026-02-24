
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractionHandlerPermissions+ToolRule
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
    public partial class InteractionHandlerPermissions
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractionHandlerPermissions+ToolRule")]
public partial class ToolRule : global::FrooxEngine.SyncObject

{
    public System.String Type;
public global::System.Boolean IncludeDerived;
public global::System.Boolean Allow;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Type", Type.ToResoniteLinkField());
members.Add("IncludeDerived", IncludeDerived.ToResoniteLinkField());
members.Add("Allow", Allow.ToResoniteLinkField());
}

}
            }
}
