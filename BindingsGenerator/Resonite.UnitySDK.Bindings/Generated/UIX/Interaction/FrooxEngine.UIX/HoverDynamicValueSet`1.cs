
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.HoverDynamicValueSet<>
// Generated on: čtvrtek 26. února 2026 10:04:42
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.HoverDynamicValueSet<>")]
public partial class HoverDynamicValueSet<T> : global::FrooxEngine.UIX.UIController, global::FrooxEngine.UIX.IUIHoverable
	

{
    public global::System.String VariableName { get => VariableName_Element.Data; set => VariableName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> VariableName_Element = new();
public T ValueOnBeginHover { get => ValueOnBeginHover_Element.Data; set => ValueOnBeginHover_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> ValueOnBeginHover_Element = new();
public T ValueOnEndHover { get => ValueOnEndHover_Element.Data; set => ValueOnEndHover_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> ValueOnEndHover_Element = new();
public global::System.Boolean SetValueOnBeginHover { get => SetValueOnBeginHover_Element.Data; set => SetValueOnBeginHover_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetValueOnBeginHover_Element = new();
public global::System.Boolean SetValueOnEndHover { get => SetValueOnEndHover_Element.Data; set => SetValueOnEndHover_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetValueOnEndHover_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VariableName", VariableName_Element.Data.ToResoniteLinkField());
members.Add("ValueOnBeginHover", ValueOnBeginHover_Element.Data.ToResoniteLinkField());
members.Add("ValueOnEndHover", ValueOnEndHover_Element.Data.ToResoniteLinkField());
members.Add("SetValueOnBeginHover", SetValueOnBeginHover_Element.Data.ToResoniteLinkField());
members.Add("SetValueOnEndHover", SetValueOnEndHover_Element.Data.ToResoniteLinkField());
}

}
}
