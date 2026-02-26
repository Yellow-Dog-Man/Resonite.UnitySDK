
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.FocusWorld
// Generated on: čtvrtek 26. února 2026 12:28:00
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.FocusWorld")]
public partial class FocusWorld : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.WorldURLActionNode

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> CloseCurrent { get => CloseCurrent_Element.Data; set => CloseCurrent_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> CloseCurrent_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnNotFound { get => OnNotFound_Element.Data; set => OnNotFound_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnNotFound_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnFocused { get => OnFocused_Element.Data; set => OnFocused_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnFocused_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnFail { get => OnFail_Element.Data; set => OnFail_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnFail_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CloseCurrent", CloseCurrent_Element.ToLinkReference(context));
members.Add("OnNotFound", OnNotFound_Element.ToLinkReference(context));
members.Add("OnFocused", OnFocused_Element.ToLinkReference(context));
members.Add("OnFail", OnFail_Element.ToLinkReference(context));
}

}
}
