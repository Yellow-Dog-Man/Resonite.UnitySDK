
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.LocalImpulseTimeoutTimeSpan
// Generated on: čtvrtek 19. února 2026 7:59:51
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.LocalImpulseTimeoutTimeSpan")]
public partial class LocalImpulseTimeoutTimeSpan : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.LocalImpulseTimeout

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.TimeSpan> Timeout;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Timeout", Timeout.ToResoniteReference(context));
}

}
}
