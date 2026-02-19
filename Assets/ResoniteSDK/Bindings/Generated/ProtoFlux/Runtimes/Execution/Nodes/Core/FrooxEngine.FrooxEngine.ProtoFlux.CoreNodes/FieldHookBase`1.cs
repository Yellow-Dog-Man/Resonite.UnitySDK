
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.FieldHookBase<>
// Generated on: čtvrtek 19. února 2026 7:59:44
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IField<T>> Target;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsDriving;
public global::FrooxEngine.ProtoFlux.SyncNodeOperation StartDrive;
public global::FrooxEngine.ProtoFlux.SyncNodeOperation StopDrive;
public global::FrooxEngine.ProtoFlux.INodeOperation OnStartDrive;
public global::FrooxEngine.ProtoFlux.INodeOperation OnStopDrive;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnHook;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("IsDriving", new ResoniteLink.EmptyElement());
members.Add("StartDrive", new ResoniteLink.EmptyElement());
members.Add("StopDrive", new ResoniteLink.EmptyElement());
members.Add("OnStartDrive", OnStartDrive.ToResoniteReference(context));
members.Add("OnStopDrive", OnStopDrive.ToResoniteReference(context));
members.Add("OnHook", OnHook.ToResoniteReference(context));
}

}
}
