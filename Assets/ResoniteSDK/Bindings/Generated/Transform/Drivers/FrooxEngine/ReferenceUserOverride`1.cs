
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceUserOverride<>
// Generated on: pátek 13. února 2026 5:52:26
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceUserOverride<>")]
public partial class ReferenceUserOverride<T> : global::FrooxEngine.Component
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.SyncRef<T> Target;
public T Default;
public global::System.Boolean CreateOverrideOnWrite;
public global::System.Boolean PersistentOverrides;
public global::System.Boolean ClearOnUserLeave;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("Default", new ResoniteLink.Reference() { });
members.Add("CreateOverrideOnWrite", CreateOverrideOnWrite.ToResoniteLinkField());
members.Add("PersistentOverrides", PersistentOverrides.ToResoniteLinkField());
members.Add("ClearOnUserLeave", ClearOnUserLeave.ToResoniteLinkField());
}

}
}
