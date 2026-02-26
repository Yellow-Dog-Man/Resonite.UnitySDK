
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.GripEvents
// Generated on: čtvrtek 26. února 2026 10:04:29
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.GripEvents")]
public abstract partial class GripEvents : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.LocomotionGrip> Grip { get => Grip_Element.Data; set => Grip_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.LocomotionGrip>>, global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.LocomotionGrip>> Grip_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnEvent { get => OnEvent_Element.Data; set => OnEvent_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> OnEvent_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.ILocomotionModule> Module = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::Renderite.Shared.BodyNode> GrippingBodyNode = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Grip", Grip_Element.Data.ToResoniteReference(context));
members.Add("OnEvent", OnEvent_Element.Data.ToResoniteReference(context));
members.Add("Module", new ResoniteLink.EmptyElement());
members.Add("GrippingBodyNode", new ResoniteLink.EmptyElement());
}

}
}
