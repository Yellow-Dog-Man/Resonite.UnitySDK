
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractionHandlerPermissions+ToolRule
// Generated on: pátek 13. února 2026 23:21:42
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Type", Type.ToResoniteLinkField());
members.Add("IncludeDerived", IncludeDerived.ToResoniteLinkField());
members.Add("Allow", Allow.ToResoniteLinkField());
}

}
            }
}
