
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabReferenceSet<>
// Generated on: čtvrtek 26. února 2026 10:04:42
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
    public global::FrooxEngine.SyncRef<T> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncRef<T>>, global::FrooxEngine.SyncRef<T>> Target_Element = new();
public T GrabbedTarget { get => GrabbedTarget_Element.Data; set => GrabbedTarget_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<T>, T> GrabbedTarget_Element = new();
public T ReleasedTarget { get => ReleasedTarget_Element.Data; set => ReleasedTarget_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<T>, T> ReleasedTarget_Element = new();
public global::System.Boolean SetOnGrabbed { get => SetOnGrabbed_Element.Data; set => SetOnGrabbed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetOnGrabbed_Element = new();
public global::System.Boolean SetOnReleased { get => SetOnReleased_Element.Data; set => SetOnReleased_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetOnReleased_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.Data.ToResoniteReference(context));
members.Add("GrabbedTarget", GrabbedTarget_Element.Data.ToResoniteReference(context));
members.Add("ReleasedTarget", ReleasedTarget_Element.Data.ToResoniteReference(context));
members.Add("SetOnGrabbed", SetOnGrabbed_Element.Data.ToResoniteLinkField());
members.Add("SetOnReleased", SetOnReleased_Element.Data.ToResoniteLinkField());
}

}
}
