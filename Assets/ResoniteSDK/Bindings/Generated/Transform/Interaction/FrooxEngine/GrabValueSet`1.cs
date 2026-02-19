
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabValueSet<>
// Generated on: čtvrtek 19. února 2026 8:00:24
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabValueSet<>")]
public partial class GrabValueSet<T> : global::FrooxEngine.Component, global::FrooxEngine.IGrabEventReceiver
	

{
    public global::FrooxEngine.IField<T> Target;
public T GrabbedValue;
public T ReleasedValue;
public global::System.Boolean SetOnGrabbed;
public global::System.Boolean SetOnReleased;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("GrabbedValue", GrabbedValue.ToResoniteLinkField());
members.Add("ReleasedValue", ReleasedValue.ToResoniteLinkField());
members.Add("SetOnGrabbed", SetOnGrabbed.ToResoniteLinkField());
members.Add("SetOnReleased", SetOnReleased.ToResoniteLinkField());
}

}
}
