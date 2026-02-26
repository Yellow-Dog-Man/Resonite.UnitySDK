
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Animation.TweenValue<>
// Generated on: čtvrtek 26. února 2026 10:04:05
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Animation
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Animation.TweenValue<>")]
public partial class TweenValue<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> To { get => To_Element.Data; set => To_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T>> To_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> From { get => From_Element.Data; set => From_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T>> From_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Duration { get => Duration_Element.Data; set => Duration_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Duration_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.CurvePreset> Curve { get => Curve_Element.Data; set => Curve_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.CurvePreset>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.CurvePreset>> Curve_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> ProportionalDuration { get => ProportionalDuration_Element.Data; set => ProportionalDuration_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> ProportionalDuration_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IField<T>> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IField<T>>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IField<T>>> Target_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnStarted { get => OnStarted_Element.Data; set => OnStarted_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnStarted_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnDone { get => OnDone_Element.Data; set => OnDone_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnDone_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("To", To_Element.Data.ToResoniteReference(context));
members.Add("From", From_Element.Data.ToResoniteReference(context));
members.Add("Duration", Duration_Element.Data.ToResoniteReference(context));
members.Add("Curve", Curve_Element.Data.ToResoniteReference(context));
members.Add("ProportionalDuration", ProportionalDuration_Element.Data.ToResoniteReference(context));
members.Add("Target", Target_Element.Data.ToResoniteReference(context));
members.Add("OnStarted", OnStarted_Element.Data.ToResoniteReference(context));
members.Add("OnDone", OnDone_Element.Data.ToResoniteReference(context));
}

}
}
