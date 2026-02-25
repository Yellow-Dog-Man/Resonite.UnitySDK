
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.LocalImpulseTimeoutSeconds
// Generated on: středa 25. února 2026 16:13:46
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.LocalImpulseTimeoutSeconds")]
public partial class LocalImpulseTimeoutSeconds : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.LocalImpulseTimeout

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Timeout;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Timeout", Timeout.ToResoniteReference(context));
}

}
}
