
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueMultiDriver<>
// Generated on: pátek 13. února 2026 23:23:03
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueMultiDriver<>")]
public partial class ValueMultiDriver<T> : global::FrooxEngine.Component
	

{
    public T Value;
public System.Collections.Generic.List<global::FrooxEngine.IField<T>> Drives;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Value", Value.ToResoniteLinkField());
members.Add("Drives", new ResoniteLink.SyncList()
{
    Elements = Drives.ConvertList(m => new ResoniteLink.Reference() { })
});
}

}
}
