
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractionHandlerPermissions+ToolRule
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
    public partial class InteractionHandlerPermissions
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractionHandlerPermissions+ToolRule")]
public partial class ToolRule : global::FrooxEngine.SyncObject

{
    public System.String Type { get => Type_Element.Data; set => Type_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> Type_Element = new();
public global::System.Boolean IncludeDerived { get => IncludeDerived_Element.Data; set => IncludeDerived_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IncludeDerived_Element = new();
public global::System.Boolean Allow { get => Allow_Element.Data; set => Allow_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Allow_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Type", Type_Element.ToLinkField(context));
members.Add("IncludeDerived", IncludeDerived_Element.ToLinkField(context));
members.Add("Allow", Allow_Element.ToLinkField(context));
}

}
            }
}
