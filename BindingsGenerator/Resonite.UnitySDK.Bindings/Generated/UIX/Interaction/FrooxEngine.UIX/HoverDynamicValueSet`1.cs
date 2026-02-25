
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.HoverDynamicValueSet<>
// Generated on: středa 25. února 2026 16:14:33
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
    public global::System.String VariableName;
public T ValueOnBeginHover;
public T ValueOnEndHover;
public global::System.Boolean SetValueOnBeginHover;
public global::System.Boolean SetValueOnEndHover;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VariableName", VariableName.ToResoniteLinkField());
members.Add("ValueOnBeginHover", ValueOnBeginHover.ToResoniteLinkField());
members.Add("ValueOnEndHover", ValueOnEndHover.ToResoniteLinkField());
members.Add("SetValueOnBeginHover", SetValueOnBeginHover.ToResoniteLinkField());
members.Add("SetValueOnEndHover", SetValueOnEndHover.ToResoniteLinkField());
}

}
}
