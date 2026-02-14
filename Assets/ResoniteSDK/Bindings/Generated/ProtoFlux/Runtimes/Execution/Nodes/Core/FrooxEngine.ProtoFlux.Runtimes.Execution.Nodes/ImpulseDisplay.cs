
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ImpulseDisplay
// Generated on: sobota 14. února 2026 8:57:49
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
