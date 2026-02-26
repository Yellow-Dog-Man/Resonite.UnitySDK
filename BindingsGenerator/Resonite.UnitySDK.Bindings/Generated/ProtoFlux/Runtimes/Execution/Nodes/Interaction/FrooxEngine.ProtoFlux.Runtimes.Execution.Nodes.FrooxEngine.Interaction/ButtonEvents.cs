
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.ButtonEvents
// Generated on: čtvrtek 26. února 2026 15:08:38
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.IButton> Button { get => Button_Element.Data; set => Button_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.IButton>>, global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.IButton>> Button_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation Pressed { get => Pressed_Element.Data; set => Pressed_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> Pressed_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation Pressing { get => Pressing_Element.Data; set => Pressing_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> Pressing_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation Released { get => Released_Element.Data; set => Released_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> Released_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation HoverEnter { get => HoverEnter_Element.Data; set => HoverEnter_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> HoverEnter_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation HoverStay { get => HoverStay_Element.Data; set => HoverStay_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> HoverStay_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation HoverLeave { get => HoverLeave_Element.Data; set => HoverLeave_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> HoverLeave_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.Component> Source = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> GlobalPoint = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> LocalPoint = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> NormalizedPoint = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Button", Button_Element.ToLinkReference(context));
members.Add("Pressed", Pressed_Element.ToLinkReference(context));
members.Add("Pressing", Pressing_Element.ToLinkReference(context));
members.Add("Released", Released_Element.ToLinkReference(context));
members.Add("HoverEnter", HoverEnter_Element.ToLinkReference(context));
members.Add("HoverStay", HoverStay_Element.ToLinkReference(context));
members.Add("HoverLeave", HoverLeave_Element.ToLinkReference(context));
members.Add("Source", Source.ToLinkEmpty(context));
members.Add("GlobalPoint", GlobalPoint.ToLinkEmpty(context));
members.Add("LocalPoint", LocalPoint.ToLinkEmpty(context));
members.Add("NormalizedPoint", NormalizedPoint.ToLinkEmpty(context));
}

}
}
