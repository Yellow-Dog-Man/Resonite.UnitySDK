
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Users.SetUserScale
// Generated on: čtvrtek 26. února 2026 10:04:33
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Users
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Users.SetUserScale")]
public partial class SetUserScale : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.UserRoot> UserRoot { get => UserRoot_Element.Data; set => UserRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.UserRoot>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.UserRoot>> UserRoot_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Scale { get => Scale_Element.Data; set => Scale_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Scale_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> AnimationTime { get => AnimationTime_Element.Data; set => AnimationTime_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> AnimationTime_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnScaleChangeStart { get => OnScaleChangeStart_Element.Data; set => OnScaleChangeStart_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnScaleChangeStart_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnAnimationFinished { get => OnAnimationFinished_Element.Data; set => OnAnimationFinished_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnAnimationFinished_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UserRoot", UserRoot_Element.Data.ToResoniteReference(context));
members.Add("Scale", Scale_Element.Data.ToResoniteReference(context));
members.Add("AnimationTime", AnimationTime_Element.Data.ToResoniteReference(context));
members.Add("OnScaleChangeStart", OnScaleChangeStart_Element.Data.ToResoniteReference(context));
members.Add("OnAnimationFinished", OnAnimationFinished_Element.Data.ToResoniteReference(context));
}

}
}
