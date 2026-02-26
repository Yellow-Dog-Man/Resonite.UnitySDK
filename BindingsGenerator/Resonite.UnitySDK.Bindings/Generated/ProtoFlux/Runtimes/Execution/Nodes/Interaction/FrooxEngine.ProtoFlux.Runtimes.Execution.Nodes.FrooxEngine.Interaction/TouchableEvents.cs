
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.TouchableEvents
// Generated on: čtvrtek 26. února 2026 12:27:35
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.TouchEventRelay> EventSource { get => EventSource_Element.Data; set => EventSource_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.TouchEventRelay>>, global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.TouchEventRelay>> EventSource_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnEvent { get => OnEvent_Element.Data; set => OnEvent_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> OnEvent_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::FrooxEngine.EventState> Hover = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::FrooxEngine.EventState> Touch = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Point = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Tip = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::FrooxEngine.TouchType> Type = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.Component> Source = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EventSource", EventSource_Element.ToLinkReference(context));
members.Add("OnEvent", OnEvent_Element.ToLinkReference(context));
members.Add("Hover", Hover.ToLinkEmpty(context));
members.Add("Touch", Touch.ToLinkEmpty(context));
members.Add("Point", Point.ToLinkEmpty(context));
members.Add("Tip", Tip.ToLinkEmpty(context));
members.Add("Type", Type.ToLinkEmpty(context));
members.Add("Source", Source.ToLinkEmpty(context));
}

}
}
