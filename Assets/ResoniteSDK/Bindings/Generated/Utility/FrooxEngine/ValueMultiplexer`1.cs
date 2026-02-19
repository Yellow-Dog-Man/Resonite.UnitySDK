
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueMultiplexer<>
// Generated on: čtvrtek 19. února 2026 8:00:33
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueMultiplexer<>")]
public partial class ValueMultiplexer<T> : global::FrooxEngine.Component, global::FrooxEngine.IValue<T>, global::FrooxEngine.IValue
	

{
    public global::FrooxEngine.IField<T> Target;
public global::System.Int32 Index;
public System.Collections.Generic.List<T> Values;
public global::System.Boolean AllowWriteBack;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("Index", Index.ToResoniteLinkField());
members.Add("Values", new ResoniteLink.SyncList()
{
    Elements = Values.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("AllowWriteBack", AllowWriteBack.ToResoniteLinkField());
}

}
}
