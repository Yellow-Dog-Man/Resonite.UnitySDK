
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.ButtonEvents
// Generated on: sobota 14. února 2026 8:57:59
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.ButtonEvents")]
public partial class ButtonEvents : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.IButton> Button;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation Pressed;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation Pressing;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation Released;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation HoverEnter;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation HoverStay;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation HoverLeave;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.Component> Source;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> GlobalPoint;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> LocalPoint;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> NormalizedPoint;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Button", Button.ToResoniteReference(context));
members.Add("Pressed", Pressed.ToResoniteReference(context));
members.Add("Pressing", Pressing.ToResoniteReference(context));
members.Add("Released", Released.ToResoniteReference(context));
members.Add("HoverEnter", HoverEnter.ToResoniteReference(context));
members.Add("HoverStay", HoverStay.ToResoniteReference(context));
members.Add("HoverLeave", HoverLeave.ToResoniteReference(context));
members.Add("Source", new ResoniteLink.EmptyElement());
members.Add("GlobalPoint", new ResoniteLink.EmptyElement());
members.Add("LocalPoint", new ResoniteLink.EmptyElement());
members.Add("NormalizedPoint", new ResoniteLink.EmptyElement());
}

}
}
