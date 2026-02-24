
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueMultiDriver<>
// Generated on: úterý 24. února 2026 18:20:04
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueMultiDriver<>")]
public partial class ValueMultiDriver<T> : global::FrooxEngine.Component
	

{
    public T Value;
public System.Collections.Generic.List<global::FrooxEngine.IField<T>> Drives;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value.ToResoniteLinkField());
members.Add("Drives", new ResoniteLink.SyncList()
{
    Elements = Drives.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
