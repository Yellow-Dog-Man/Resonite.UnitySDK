
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ComponentBase<>
// Generated on: čtvrtek 26. února 2026 15:07:51
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.Boolean persistent { get => persistent_Element.Data; set => persistent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> persistent_Element = new();
public global::System.Int32 UpdateOrder { get => UpdateOrder_Element.Data; set => UpdateOrder_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> UpdateOrder_Element = new();
public global::System.Boolean Enabled { get => Enabled_Element.Data; set => Enabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Enabled_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("persistent", persistent_Element.ToLinkField(context));
members.Add("UpdateOrder", UpdateOrder_Element.ToLinkField(context));
members.Add("Enabled", Enabled_Element.ToLinkField(context));
}

}
}
