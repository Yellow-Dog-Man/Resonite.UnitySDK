
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonReferenceCycle<>
// Generated on: pátek 13. února 2026 5:51:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonReferenceCycle<>")]
public partial class ButtonReferenceCycle<T> : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.SyncRef<T> TargetReference;
public System.Collections.Generic.List<T> Targets;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetReference", new ResoniteLink.Reference() { });
members.Add("Targets", new ResoniteLink.SyncList()
{
    Elements = Targets.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
}

}
}
