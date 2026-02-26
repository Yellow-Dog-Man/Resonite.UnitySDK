
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicVariableResetBase<>
// Generated on: čtvrtek 26. února 2026 10:03:38
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicVariableResetBase<>")]
public abstract partial class DynamicVariableResetBase<T> : global::FrooxEngine.Component
	

{
    public global::System.String VariableName { get => VariableName_Element.Data; set => VariableName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> VariableName_Element = new();
public global::System.Boolean ResetOnLoad { get => ResetOnLoad_Element.Data; set => ResetOnLoad_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ResetOnLoad_Element = new();
public global::System.Boolean ResetOnDuplicate { get => ResetOnDuplicate_Element.Data; set => ResetOnDuplicate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ResetOnDuplicate_Element = new();
public global::System.Boolean ResetOnPaste { get => ResetOnPaste_Element.Data; set => ResetOnPaste_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ResetOnPaste_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VariableName", VariableName_Element.Data.ToResoniteLinkField());
members.Add("ResetOnLoad", ResetOnLoad_Element.Data.ToResoniteLinkField());
members.Add("ResetOnDuplicate", ResetOnDuplicate_Element.Data.ToResoniteLinkField());
members.Add("ResetOnPaste", ResetOnPaste_Element.Data.ToResoniteLinkField());
}

}
}
