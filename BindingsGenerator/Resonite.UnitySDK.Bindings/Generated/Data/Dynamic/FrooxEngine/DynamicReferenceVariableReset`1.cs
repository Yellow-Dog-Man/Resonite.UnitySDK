
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicReferenceVariableReset<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicReferenceVariableReset<>")]
public partial class DynamicReferenceVariableReset<T> : global::FrooxEngine.DynamicVariableResetBase<T>
	where T : class, global::FrooxEngine.IWorldElement

{
    public T ResetTarget { get => ResetTarget_Element.Data; set => ResetTarget_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<T>, T> ResetTarget_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ResetTarget", ResetTarget_Element.Data.ToResoniteReference(context));
}

}
}
