
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueOverrideBase<>
// Generated on: úterý 24. února 2026 18:20:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueOverrideBase<>")]
public abstract partial class ValueOverrideBase<T> : global::FrooxEngine.Component
	

{
    public T Default;
public global::System.Boolean CreateOverrideOnWrite;
public global::System.Boolean PersistentOverrides;
public global::System.Boolean ClearOnUserLeave;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Default", Default.ToResoniteLinkField());
members.Add("CreateOverrideOnWrite", CreateOverrideOnWrite.ToResoniteLinkField());
members.Add("PersistentOverrides", PersistentOverrides.ToResoniteLinkField());
members.Add("ClearOnUserLeave", ClearOnUserLeave.ToResoniteLinkField());
}

}
}
