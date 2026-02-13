
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Slots.SlotChildrenEvents
// Generated on: pátek 13. února 2026 23:22:53
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Instance", new ResoniteLink.Reference() { });
members.Add("OnUser", new ResoniteLink.Reference() { });
members.Add("OnChildAdded", new ResoniteLink.Reference() { });
members.Add("OnChildRemoved", new ResoniteLink.Reference() { });
members.Add("Child", new ResoniteLink.EmptyElement());
}

}
}
