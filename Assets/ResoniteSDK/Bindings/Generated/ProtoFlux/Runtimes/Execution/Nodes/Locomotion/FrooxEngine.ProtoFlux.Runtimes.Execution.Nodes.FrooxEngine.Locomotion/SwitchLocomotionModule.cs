
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Locomotion.SwitchLocomotionModule
// Generated on: pátek 13. února 2026 23:22:31
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Locomotion
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Locomotion.SwitchLocomotionModule")]
public partial class SwitchLocomotionModule : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User> TargetUser;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> ModuleName;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> ExactMatch;
public global::FrooxEngine.ProtoFlux.INodeOperation OnSwitched;
public global::FrooxEngine.ProtoFlux.INodeOperation OnNotFound;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetUser", new ResoniteLink.Reference() { });
members.Add("ModuleName", new ResoniteLink.Reference() { });
members.Add("ExactMatch", new ResoniteLink.Reference() { });
members.Add("OnSwitched", new ResoniteLink.Reference() { });
members.Add("OnNotFound", new ResoniteLink.Reference() { });
}

}
}
