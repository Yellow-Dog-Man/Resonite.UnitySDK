
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Users.UserFromUsername
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Users.UserFromUsername")]
public partial class UserFromUsername : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::FrooxEngine.User>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Username { get => Username_Element.Data; set => Username_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> Username_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> IgnoreCase { get => IgnoreCase_Element.Data; set => IgnoreCase_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> IgnoreCase_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> AllowPartialMatch { get => AllowPartialMatch_Element.Data; set => AllowPartialMatch_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> AllowPartialMatch_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Username", Username_Element.Data.ToResoniteReference(context));
members.Add("IgnoreCase", IgnoreCase_Element.Data.ToResoniteReference(context));
members.Add("AllowPartialMatch", AllowPartialMatch_Element.Data.ToResoniteReference(context));
}

}
}
