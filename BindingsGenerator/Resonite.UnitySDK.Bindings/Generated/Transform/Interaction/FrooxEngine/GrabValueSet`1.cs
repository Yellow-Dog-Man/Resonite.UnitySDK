
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabValueSet<>
// Generated on: čtvrtek 26. února 2026 15:09:08
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.IField<T> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<T>>, global::FrooxEngine.IField<T>> Target_Element = new();
public T GrabbedValue { get => GrabbedValue_Element.Data; set => GrabbedValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> GrabbedValue_Element = new();
public T ReleasedValue { get => ReleasedValue_Element.Data; set => ReleasedValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> ReleasedValue_Element = new();
public global::System.Boolean SetOnGrabbed { get => SetOnGrabbed_Element.Data; set => SetOnGrabbed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetOnGrabbed_Element = new();
public global::System.Boolean SetOnReleased { get => SetOnReleased_Element.Data; set => SetOnReleased_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetOnReleased_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("GrabbedValue", GrabbedValue_Element.ToLinkField(context));
members.Add("ReleasedValue", ReleasedValue_Element.ToLinkField(context));
members.Add("SetOnGrabbed", SetOnGrabbed_Element.ToLinkField(context));
members.Add("SetOnReleased", SetOnReleased_Element.ToLinkField(context));
}

}
}
