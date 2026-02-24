
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocalVariableSync<>
// Generated on: úterý 24. února 2026 18:20:25
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocalVariableSync<>")]
public partial class LocalVariableSync<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.UserRef OwnerUser;
public global::FrooxEngine.IField<T> Value;
public global::System.String Variable;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OwnerUser", new ResoniteLink.SyncObject() { Members = OwnerUser.CollectMembers(context) });
members.Add("Value", Value.ToResoniteReference(context));
members.Add("Variable", Variable.ToResoniteLinkField());
}

}
}
