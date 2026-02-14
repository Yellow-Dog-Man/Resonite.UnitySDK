
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicVariableResetBase<>
// Generated on: sobota 14. února 2026 8:57:04
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicVariableResetBase<>")]
public abstract partial class DynamicVariableResetBase<T> : global::FrooxEngine.Component
	

{
    public global::System.String VariableName;
public global::System.Boolean ResetOnLoad;
public global::System.Boolean ResetOnDuplicate;
public global::System.Boolean ResetOnPaste;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VariableName", VariableName.ToResoniteLinkField());
members.Add("ResetOnLoad", ResetOnLoad.ToResoniteLinkField());
members.Add("ResetOnDuplicate", ResetOnDuplicate.ToResoniteLinkField());
members.Add("ResetOnPaste", ResetOnPaste.ToResoniteLinkField());
}

}
}
