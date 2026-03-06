
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicReferenceVariableReset<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicReferenceVariableReset<>")]
public partial class DynamicReferenceVariableReset<T> : global::FrooxEngine.DynamicVariableResetBase<T>
	where T : class, global::FrooxEngine.IWorldElement

{
    public T ResetTarget { get => ResetTarget_Element.Data; set => ResetTarget_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<T>, T> ResetTarget_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ResetTarget", ResetTarget_Element.ToLinkReference(context));
}

}
}
