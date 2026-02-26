
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ActiveUserCloudValueBase<>
// Generated on: čtvrtek 26. února 2026 15:07:57
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ActiveUserCloudValueBase<>")]
public abstract partial class ActiveUserCloudValueBase<T> : global::FrooxEngine.CloudValueBase<T>
	

{
    public global::System.Boolean UpdateCloudVariable { get => UpdateCloudVariable_Element.Data; set => UpdateCloudVariable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UpdateCloudVariable_Element = new();
public T FallbackValue { get => FallbackValue_Element.Data; set => FallbackValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> FallbackValue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UpdateCloudVariable", UpdateCloudVariable_Element.ToLinkField(context));
members.Add("FallbackValue", FallbackValue_Element.ToLinkField(context));
}

}
}
