
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.ButtonEvents
// Generated on: pátek 13. února 2026 23:22:31
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Button", new ResoniteLink.Reference() { });
members.Add("Pressed", new ResoniteLink.Reference() { });
members.Add("Pressing", new ResoniteLink.Reference() { });
members.Add("Released", new ResoniteLink.Reference() { });
members.Add("HoverEnter", new ResoniteLink.Reference() { });
members.Add("HoverStay", new ResoniteLink.Reference() { });
members.Add("HoverLeave", new ResoniteLink.Reference() { });
members.Add("Source", new ResoniteLink.EmptyElement());
members.Add("GlobalPoint", new ResoniteLink.EmptyElement());
members.Add("LocalPoint", new ResoniteLink.EmptyElement());
members.Add("NormalizedPoint", new ResoniteLink.EmptyElement());
}

}
}
