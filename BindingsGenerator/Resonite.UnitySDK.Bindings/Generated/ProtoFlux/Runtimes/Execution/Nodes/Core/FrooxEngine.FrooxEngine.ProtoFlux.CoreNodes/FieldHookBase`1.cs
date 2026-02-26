
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.FieldHookBase<>
// Generated on: čtvrtek 26. února 2026 10:04:08
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.FieldHookBase<>")]
public abstract partial class FieldHookBase<T> : global::FrooxEngine.FrooxEngine.ProtoFlux.ProxyVoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::FrooxEngine.ProtoFlux.CoreNodes.FieldHookBase<T>.Proxy>
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IField<T>> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IField<T>>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IField<T>>> Target_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsDriving = new();
public global::FrooxEngine.ProtoFlux.SyncNodeOperation StartDrive = new();
public global::FrooxEngine.ProtoFlux.SyncNodeOperation StopDrive = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnStartDrive { get => OnStartDrive_Element.Data; set => OnStartDrive_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnStartDrive_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnStopDrive { get => OnStopDrive_Element.Data; set => OnStopDrive_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnStopDrive_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnHook { get => OnHook_Element.Data; set => OnHook_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> OnHook_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.Data.ToResoniteReference(context));
members.Add("IsDriving", new ResoniteLink.EmptyElement());
members.Add("StartDrive", new ResoniteLink.EmptyElement());
members.Add("StopDrive", new ResoniteLink.EmptyElement());
members.Add("OnStartDrive", OnStartDrive_Element.Data.ToResoniteReference(context));
members.Add("OnStopDrive", OnStopDrive_Element.Data.ToResoniteReference(context));
members.Add("OnHook", OnHook_Element.Data.ToResoniteReference(context));
}

}
}
