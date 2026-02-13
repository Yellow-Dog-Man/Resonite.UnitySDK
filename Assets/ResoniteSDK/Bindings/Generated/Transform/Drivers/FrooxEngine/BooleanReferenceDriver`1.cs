
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BooleanReferenceDriver<>
// Generated on: pátek 13. února 2026 5:52:25
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BooleanReferenceDriver<>")]
public partial class BooleanReferenceDriver<T> : global::FrooxEngine.Component
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::System.Boolean State;
public global::FrooxEngine.SyncRef<T> TargetReference;
public T FalseTarget;
public T TrueTarget;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("State", State.ToResoniteLinkField());
members.Add("TargetReference", new ResoniteLink.Reference() { });
members.Add("FalseTarget", new ResoniteLink.Reference() { });
members.Add("TrueTarget", new ResoniteLink.Reference() { });
}

}
}
