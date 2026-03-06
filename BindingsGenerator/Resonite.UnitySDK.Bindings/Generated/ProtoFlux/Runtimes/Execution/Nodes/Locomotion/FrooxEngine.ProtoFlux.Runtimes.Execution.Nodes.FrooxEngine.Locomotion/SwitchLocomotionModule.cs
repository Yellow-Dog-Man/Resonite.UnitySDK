
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Locomotion.SwitchLocomotionModule
// Generated on: pátek 6. března 2026 14:18:44
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User> TargetUser { get => TargetUser_Element.Data; set => TargetUser_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User>> TargetUser_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> ModuleName { get => ModuleName_Element.Data; set => ModuleName_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> ModuleName_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> ExactMatch { get => ExactMatch_Element.Data; set => ExactMatch_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> ExactMatch_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnSwitched { get => OnSwitched_Element.Data; set => OnSwitched_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnSwitched_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnNotFound { get => OnNotFound_Element.Data; set => OnNotFound_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnNotFound_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetUser", TargetUser_Element.ToLinkReference(context));
members.Add("ModuleName", ModuleName_Element.ToLinkReference(context));
members.Add("ExactMatch", ExactMatch_Element.ToLinkReference(context));
members.Add("OnSwitched", OnSwitched_Element.ToLinkReference(context));
members.Add("OnNotFound", OnNotFound_Element.ToLinkReference(context));
}

}
}
