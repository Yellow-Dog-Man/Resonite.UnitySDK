
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Locomotion.InstallLocomotionModules
// Generated on: čtvrtek 26. února 2026 12:27:35
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Locomotion.InstallLocomotionModules")]
public partial class InstallLocomotionModules : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionBreakableFlowNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> ModulesRoot { get => ModulesRoot_Element.Data; set => ModulesRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot>> ModulesRoot_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User> TargetUser { get => TargetUser_Element.Data; set => TargetUser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User>> TargetUser_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> ClearExisting { get => ClearExisting_Element.Data; set => ClearExisting_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> ClearExisting_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ModulesRoot", ModulesRoot_Element.ToLinkReference(context));
members.Add("TargetUser", TargetUser_Element.ToLinkReference(context));
members.Add("ClearExisting", ClearExisting_Element.ToLinkReference(context));
}

}
}
