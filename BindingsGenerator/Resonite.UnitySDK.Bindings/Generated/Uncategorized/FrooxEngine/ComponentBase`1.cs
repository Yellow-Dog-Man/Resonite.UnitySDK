
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ComponentBase<>
// Generated on: středa 25. února 2026 16:13:01
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ComponentBase<>")]
public abstract partial class ComponentBase<C> : global::FrooxEngine.Worker, global::FrooxEngine.IComponentBase, global::FrooxEngine.IDestroyable, global::FrooxEngine.IUpdatable, global::FrooxEngine.IChangeable, global::FrooxEngine.ILinkable, global::FrooxEngine.IWorldEventReceiver
	where C : global::FrooxEngine.ComponentBase<C>

{
    public global::System.Boolean persistent;
public global::System.Int32 UpdateOrder;
public global::System.Boolean Enabled;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("persistent", persistent.ToResoniteLinkField());
members.Add("UpdateOrder", UpdateOrder.ToResoniteLinkField());
members.Add("Enabled", Enabled.ToResoniteLinkField());
}

}
}
