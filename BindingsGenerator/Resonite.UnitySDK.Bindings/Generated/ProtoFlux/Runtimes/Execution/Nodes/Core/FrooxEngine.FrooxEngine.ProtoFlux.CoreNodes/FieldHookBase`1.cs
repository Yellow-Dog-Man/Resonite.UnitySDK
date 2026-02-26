
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.FieldHookBase<>
// Generated on: čtvrtek 26. února 2026 15:08:32
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IField<T>>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IField<T>>> Target_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsDriving = new();
public global::FrooxEngine.ProtoFlux.SyncNodeOperation StartDrive = new();
public global::FrooxEngine.ProtoFlux.SyncNodeOperation StopDrive = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnStartDrive { get => OnStartDrive_Element.Data; set => OnStartDrive_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnStartDrive_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnStopDrive { get => OnStopDrive_Element.Data; set => OnStopDrive_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnStopDrive_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnHook { get => OnHook_Element.Data; set => OnHook_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> OnHook_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("IsDriving", IsDriving.ToLinkEmpty(context));
members.Add("StartDrive", StartDrive.ToLinkEmpty(context));
members.Add("StopDrive", StopDrive.ToLinkEmpty(context));
members.Add("OnStartDrive", OnStartDrive_Element.ToLinkReference(context));
members.Add("OnStopDrive", OnStopDrive_Element.ToLinkReference(context));
members.Add("OnHook", OnHook_Element.ToLinkReference(context));
}

}
}
