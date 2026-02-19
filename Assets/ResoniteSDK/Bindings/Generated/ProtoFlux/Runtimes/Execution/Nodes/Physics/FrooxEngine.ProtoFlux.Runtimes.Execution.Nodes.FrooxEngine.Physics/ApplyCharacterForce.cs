
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.ApplyCharacterForce
// Generated on: čtvrtek 19. února 2026 8:00:09
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.ApplyCharacterForce")]
public partial class ApplyCharacterForce : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionBreakableFlowNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Force;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.CharacterController> Character;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> IgnoreMass;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Force", Force.ToResoniteReference(context));
members.Add("Character", Character.ToResoniteReference(context));
members.Add("IgnoreMass", IgnoreMass.ToResoniteReference(context));
}

}
}
