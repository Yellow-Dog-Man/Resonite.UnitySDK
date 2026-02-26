
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Users.Roots.HandSlot
// Generated on: čtvrtek 26. února 2026 12:27:58
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Users.Roots
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Users.Roots.HandSlot")]
public partial class HandSlot : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::FrooxEngine.Slot>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.UserRoot> UserRoot { get => UserRoot_Element.Data; set => UserRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.UserRoot>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.UserRoot>> UserRoot_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.Chirality> Side { get => Side_Element.Data; set => Side_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.Chirality>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.Chirality>> Side_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UserRoot", UserRoot_Element.ToLinkReference(context));
members.Add("Side", Side_Element.ToLinkReference(context));
}

}
}
