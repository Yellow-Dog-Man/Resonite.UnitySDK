
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ImpulseDisplay
// Generated on: čtvrtek 19. února 2026 7:59:44
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ImpulseDisplay")]
public partial class ImpulseDisplay : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ExternalImpulseDisplay<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.UIX.Text _debugText;
public global::FrooxEngine.Slot _timelineRoot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_debugText", _debugText.ToResoniteReference(context));
members.Add("_timelineRoot", _timelineRoot.ToResoniteReference(context));
}

}
}
