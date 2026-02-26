
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ImpulseDisplay
// Generated on: čtvrtek 26. února 2026 15:08:31
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.UIX.Text _debugText { get => _debugText_Element.Data; set => _debugText_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _debugText_Element = new();
public global::FrooxEngine.Slot _timelineRoot { get => _timelineRoot_Element.Data; set => _timelineRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _timelineRoot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_debugText", _debugText_Element.ToLinkReference(context));
members.Add("_timelineRoot", _timelineRoot_Element.ToLinkReference(context));
}

}
}
