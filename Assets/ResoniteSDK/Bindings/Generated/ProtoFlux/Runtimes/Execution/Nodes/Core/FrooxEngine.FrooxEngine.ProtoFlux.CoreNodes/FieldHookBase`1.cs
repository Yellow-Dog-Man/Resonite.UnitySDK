
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.FieldHookBase<>
// Generated on: pátek 13. února 2026 23:22:21
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("IsDriving", new ResoniteLink.EmptyElement());
members.Add("StartDrive", new ResoniteLink.EmptyElement());
members.Add("StopDrive", new ResoniteLink.EmptyElement());
members.Add("OnStartDrive", new ResoniteLink.Reference() { });
members.Add("OnStopDrive", new ResoniteLink.Reference() { });
members.Add("OnHook", new ResoniteLink.Reference() { });
}

}
}
