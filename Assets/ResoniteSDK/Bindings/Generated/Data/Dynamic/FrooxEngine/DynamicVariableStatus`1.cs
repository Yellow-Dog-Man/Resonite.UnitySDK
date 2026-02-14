
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicVariableStatus<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicVariableStatus<>")]
public partial class DynamicVariableStatus<T> : global::FrooxEngine.DynamicVariableBase<T>
	

{
    public global::System.Boolean IsLinkedToSpace;
public global::System.Boolean VariableExists;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsLinkedToSpace", IsLinkedToSpace.ToResoniteLinkField());
members.Add("VariableExists", VariableExists.ToResoniteLinkField());
}

}
}
