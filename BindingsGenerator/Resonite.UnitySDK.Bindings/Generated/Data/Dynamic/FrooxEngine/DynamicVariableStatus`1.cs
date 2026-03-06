
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicVariableStatus<>
// Generated on: pátek 6. března 2026 14:18:07
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicVariableStatus<>")]
public partial class DynamicVariableStatus<T> : global::FrooxEngine.DynamicVariableBase<T>
	

{
    public global::System.Boolean IsLinkedToSpace { get => IsLinkedToSpace_Element.Data; set => IsLinkedToSpace_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsLinkedToSpace_Element = new();
public global::System.Boolean VariableExists { get => VariableExists_Element.Data; set => VariableExists_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> VariableExists_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsLinkedToSpace", IsLinkedToSpace_Element.ToLinkField(context));
members.Add("VariableExists", VariableExists_Element.ToLinkField(context));
}

}
}
