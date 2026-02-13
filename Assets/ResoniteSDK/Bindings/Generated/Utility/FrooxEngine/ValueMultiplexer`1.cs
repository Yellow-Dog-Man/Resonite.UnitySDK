
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueMultiplexer<>
// Generated on: pátek 13. února 2026 5:52:40
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("Index", Index.ToResoniteLinkField());
members.Add("Values", new ResoniteLink.SyncList()
{
    Elements = Values.Select(m => m.ToResoniteLinkField()).ToList<ResoniteLink.Member>()
});
members.Add("AllowWriteBack", AllowWriteBack.ToResoniteLinkField());
}

}
}
