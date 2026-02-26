
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.SecondsTimer
// Generated on: čtvrtek 26. února 2026 10:04:14
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.SecondsTimer")]
public partial class SecondsTimer : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.UserUpdateBase

{
    public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnUpdate { get => OnUpdate_Element.Data; set => OnUpdate_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> OnUpdate_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Interval { get => Interval_Element.Data; set => Interval_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Interval_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnUpdate", OnUpdate_Element.Data.ToResoniteReference(context));
members.Add("Interval", Interval_Element.Data.ToResoniteReference(context));
}

}
}
