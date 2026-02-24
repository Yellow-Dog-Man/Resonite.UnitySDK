
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CloudValueOwnerBase<>
// Generated on: úterý 24. února 2026 18:17:44
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::System.String VariableOwnerId;
public global::FrooxEngine.CloudVariableChangeMode ChangeHandling;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VariableOwnerId", VariableOwnerId.ToResoniteLinkField());
members.Add("ChangeHandling", ChangeHandling.ToResoniteLinkField());
}

}
}
