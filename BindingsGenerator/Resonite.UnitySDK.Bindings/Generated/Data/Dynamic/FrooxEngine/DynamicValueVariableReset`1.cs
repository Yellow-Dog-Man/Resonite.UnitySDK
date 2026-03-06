
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicValueVariableReset<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicValueVariableReset<>")]
public partial class DynamicValueVariableReset<T> : global::FrooxEngine.DynamicVariableResetBase<T>
	

{
    public T ResetValue { get => ResetValue_Element.Data; set => ResetValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> ResetValue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ResetValue", ResetValue_Element.ToLinkField(context));
}

}
}
