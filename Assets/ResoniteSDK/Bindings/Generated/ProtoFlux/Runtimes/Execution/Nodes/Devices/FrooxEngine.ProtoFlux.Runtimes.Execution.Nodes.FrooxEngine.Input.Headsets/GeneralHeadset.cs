
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Headsets.GeneralHeadset
// Generated on: úterý 24. února 2026 18:19:10
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Headsets
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Headsets.GeneralHeadset")]
public partial class GeneralHeadset : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User> User;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsActive;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> BatteryLevel;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsBatteryCharging;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User.ToResoniteReference(context));
members.Add("IsActive", new ResoniteLink.EmptyElement());
members.Add("BatteryLevel", new ResoniteLink.EmptyElement());
members.Add("IsBatteryCharging", new ResoniteLink.EmptyElement());
}

}
}
