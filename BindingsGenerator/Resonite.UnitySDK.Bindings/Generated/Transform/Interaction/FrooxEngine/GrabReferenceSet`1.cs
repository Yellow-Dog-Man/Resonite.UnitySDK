
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabReferenceSet<>
// Generated on: středa 25. února 2026 16:14:31
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabReferenceSet<>")]
public partial class GrabReferenceSet<T> : global::FrooxEngine.Component, global::FrooxEngine.IGrabEventReceiver
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.SyncRef<T> Target;
public T GrabbedTarget;
public T ReleasedTarget;
public global::System.Boolean SetOnGrabbed;
public global::System.Boolean SetOnReleased;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("GrabbedTarget", GrabbedTarget.ToResoniteReference(context));
members.Add("ReleasedTarget", ReleasedTarget.ToResoniteReference(context));
members.Add("SetOnGrabbed", SetOnGrabbed.ToResoniteLinkField());
members.Add("SetOnReleased", SetOnReleased.ToResoniteLinkField());
}

}
}
