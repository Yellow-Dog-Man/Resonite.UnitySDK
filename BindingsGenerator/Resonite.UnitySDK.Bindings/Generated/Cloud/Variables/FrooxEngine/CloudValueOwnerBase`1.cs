
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CloudValueOwnerBase<>
// Generated on: pátek 6. března 2026 14:18:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CloudValueOwnerBase<>")]
public abstract partial class CloudValueOwnerBase<T> : global::FrooxEngine.CloudValueBase<T>
	

{
    public global::System.String VariableOwnerId { get => VariableOwnerId_Element.Data; set => VariableOwnerId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> VariableOwnerId_Element = new();
public global::FrooxEngine.CloudVariableChangeMode ChangeHandling { get => ChangeHandling_Element.Data; set => ChangeHandling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CloudVariableChangeMode>, global::FrooxEngine.CloudVariableChangeMode> ChangeHandling_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VariableOwnerId", VariableOwnerId_Element.ToLinkField(context));
members.Add("ChangeHandling", ChangeHandling_Element.ToLinkField(context));
}

}
}
