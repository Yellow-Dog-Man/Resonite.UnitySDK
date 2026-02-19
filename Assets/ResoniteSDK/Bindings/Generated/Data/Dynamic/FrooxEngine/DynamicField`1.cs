
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicField<>
// Generated on: čtvrtek 19. února 2026 7:58:57
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicField<>")]
public partial class DynamicField<T> : global::FrooxEngine.DynamicVariableBase<T>
	

{
    public global::FrooxEngine.IField<T> TargetField;
public global::System.Boolean OverrideOnLink;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetField", TargetField.ToResoniteReference(context));
members.Add("OverrideOnLink", OverrideOnLink.ToResoniteLinkField());
}

}
}
