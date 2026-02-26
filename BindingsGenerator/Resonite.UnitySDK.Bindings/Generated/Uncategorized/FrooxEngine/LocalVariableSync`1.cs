
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocalVariableSync<>
// Generated on: čtvrtek 26. února 2026 15:09:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocalVariableSync<>")]
public partial class LocalVariableSync<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.UserRef OwnerUser = new();
public global::FrooxEngine.IField<T> Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<T>>, global::FrooxEngine.IField<T>> Value_Element = new();
public global::System.String Variable { get => Variable_Element.Data; set => Variable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Variable_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OwnerUser", OwnerUser.ToLinkSyncObject(context));
members.Add("Value", Value_Element.ToLinkReference(context));
members.Add("Variable", Variable_Element.ToLinkField(context));
}

}
}
