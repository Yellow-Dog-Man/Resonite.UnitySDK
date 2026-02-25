
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Slots.SlotChildrenEvents
// Generated on: středa 25. února 2026 16:14:05
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Slots
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Slots.SlotChildrenEvents")]
public partial class SlotChildrenEvents : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.Slot> Instance;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User> OnUser;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnChildAdded;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnChildRemoved;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.Slot> Child;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Instance", Instance.ToResoniteReference(context));
members.Add("OnUser", OnUser.ToResoniteReference(context));
members.Add("OnChildAdded", OnChildAdded.ToResoniteReference(context));
members.Add("OnChildRemoved", OnChildRemoved.ToResoniteReference(context));
members.Add("Child", new ResoniteLink.EmptyElement());
}

}
}
