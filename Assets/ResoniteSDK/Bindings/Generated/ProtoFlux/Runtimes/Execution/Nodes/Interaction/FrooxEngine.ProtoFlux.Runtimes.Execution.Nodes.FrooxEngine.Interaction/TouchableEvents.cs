
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.TouchableEvents
// Generated on: úterý 24. února 2026 18:19:16
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.TouchableEvents")]
public partial class TouchableEvents : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.TouchEventRelay> EventSource;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnEvent;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::FrooxEngine.EventState> Hover;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::FrooxEngine.EventState> Touch;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Point;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Tip;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::FrooxEngine.TouchType> Type;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.Component> Source;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EventSource", EventSource.ToResoniteReference(context));
members.Add("OnEvent", OnEvent.ToResoniteReference(context));
members.Add("Hover", new ResoniteLink.EmptyElement());
members.Add("Touch", new ResoniteLink.EmptyElement());
members.Add("Point", new ResoniteLink.EmptyElement());
members.Add("Tip", new ResoniteLink.EmptyElement());
members.Add("Type", new ResoniteLink.EmptyElement());
members.Add("Source", new ResoniteLink.EmptyElement());
}

}
}
