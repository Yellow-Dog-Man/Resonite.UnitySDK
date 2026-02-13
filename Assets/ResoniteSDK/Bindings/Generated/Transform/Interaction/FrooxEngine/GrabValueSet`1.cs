
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabValueSet<>
// Generated on: pátek 13. února 2026 23:23:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabValueSet<>")]
public partial class GrabValueSet<T> : global::FrooxEngine.Component, global::FrooxEngine.IGrabEventReceiver
	

{
    public global::FrooxEngine.IField<T> Target;
public T GrabbedValue;
public T ReleasedValue;
public global::System.Boolean SetOnGrabbed;
public global::System.Boolean SetOnReleased;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("GrabbedValue", GrabbedValue.ToResoniteLinkField());
members.Add("ReleasedValue", ReleasedValue.ToResoniteLinkField());
members.Add("SetOnGrabbed", SetOnGrabbed.ToResoniteLinkField());
members.Add("SetOnReleased", SetOnReleased.ToResoniteLinkField());
}

}
}
