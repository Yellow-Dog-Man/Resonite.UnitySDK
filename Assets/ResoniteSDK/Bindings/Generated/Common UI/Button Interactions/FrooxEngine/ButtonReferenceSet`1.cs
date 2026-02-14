
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonReferenceSet<>
// Generated on: sobota 14. února 2026 8:57:03
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonReferenceSet<>")]
public partial class ButtonReferenceSet<T> : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.SyncRef<T> TargetReference;
public T SetReference;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetReference", TargetReference.ToResoniteReference(context));
members.Add("SetReference", SetReference.ToResoniteReference(context));
}

}
}
