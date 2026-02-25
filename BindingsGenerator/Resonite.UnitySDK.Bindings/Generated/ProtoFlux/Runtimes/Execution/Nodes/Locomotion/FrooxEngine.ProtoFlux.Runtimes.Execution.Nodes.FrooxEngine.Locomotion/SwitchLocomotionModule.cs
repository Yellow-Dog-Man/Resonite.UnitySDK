
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Locomotion.SwitchLocomotionModule
// Generated on: středa 25. února 2026 16:13:47
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetUser", TargetUser.ToResoniteReference(context));
members.Add("ModuleName", ModuleName.ToResoniteReference(context));
members.Add("ExactMatch", ExactMatch.ToResoniteReference(context));
members.Add("OnSwitched", OnSwitched.ToResoniteReference(context));
members.Add("OnNotFound", OnNotFound.ToResoniteReference(context));
}

}
}
