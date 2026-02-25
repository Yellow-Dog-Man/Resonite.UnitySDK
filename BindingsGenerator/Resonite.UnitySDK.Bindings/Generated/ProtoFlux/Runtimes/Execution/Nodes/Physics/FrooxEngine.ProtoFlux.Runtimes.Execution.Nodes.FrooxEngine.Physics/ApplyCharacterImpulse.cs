
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.ApplyCharacterImpulse
// Generated on: středa 25. února 2026 16:14:04
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.ApplyCharacterImpulse")]
public partial class ApplyCharacterImpulse : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionBreakableFlowNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Impulse;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.CharacterController> Character;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> IgnoreMass;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Impulse", Impulse.ToResoniteReference(context));
members.Add("Character", Character.ToResoniteReference(context));
members.Add("IgnoreMass", IgnoreMass.ToResoniteReference(context));
}

}
}
