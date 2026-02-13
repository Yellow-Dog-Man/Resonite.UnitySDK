
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueOverrideBase<>
// Generated on: pátek 13. února 2026 23:23:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueOverrideBase<>")]
public abstract partial class ValueOverrideBase<T> : global::FrooxEngine.Component
	

{
    public T Default;
public global::System.Boolean CreateOverrideOnWrite;
public global::System.Boolean PersistentOverrides;
public global::System.Boolean ClearOnUserLeave;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Default", Default.ToResoniteLinkField());
members.Add("CreateOverrideOnWrite", CreateOverrideOnWrite.ToResoniteLinkField());
members.Add("PersistentOverrides", PersistentOverrides.ToResoniteLinkField());
members.Add("ClearOnUserLeave", ClearOnUserLeave.ToResoniteLinkField());
}

}
}
