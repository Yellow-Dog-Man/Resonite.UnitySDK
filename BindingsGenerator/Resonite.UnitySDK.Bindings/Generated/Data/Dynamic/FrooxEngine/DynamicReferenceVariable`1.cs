
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicReferenceVariable<>
// Generated on: středa 25. února 2026 16:13:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicReferenceVariable<>")]
public partial class DynamicReferenceVariable<T> : global::FrooxEngine.DynamicVariableBase<T>
	where T : class, global::FrooxEngine.IWorldElement

{
    public T Reference;
public global::System.Boolean OverrideOnLink;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Reference", Reference.ToResoniteReference(context));
members.Add("OverrideOnLink", OverrideOnLink.ToResoniteLinkField());
}

}
}
