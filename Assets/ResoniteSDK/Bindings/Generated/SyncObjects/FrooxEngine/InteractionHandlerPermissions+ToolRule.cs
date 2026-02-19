
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractionHandlerPermissions+ToolRule
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
