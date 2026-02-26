
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.SetCharacterVelocity
// Generated on: čtvrtek 26. února 2026 12:27:53
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.SetCharacterVelocity")]
public partial class SetCharacterVelocity : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionBreakableFlowNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Velocity { get => Velocity_Element.Data; set => Velocity_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> Velocity_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.CharacterController> Character { get => Character_Element.Data; set => Character_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.CharacterController>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.CharacterController>> Character_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Velocity", Velocity_Element.ToLinkReference(context));
members.Add("Character", Character_Element.ToLinkReference(context));
}

}
}
