
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.UserSpawn
// Generated on: čtvrtek 26. února 2026 12:28:00
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.UserSpawn")]
public partial class UserSpawn : global::FrooxEngine.FrooxEngine.ProtoFlux.ProxyVoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.UserSpawn.Proxy>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> OnlyHost { get => OnlyHost_Element.Data; set => OnlyHost_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> OnlyHost_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnSpawn { get => OnSpawn_Element.Data; set => OnSpawn_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> OnSpawn_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.User> SpawnedUser = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnlyHost", OnlyHost_Element.ToLinkReference(context));
members.Add("OnSpawn", OnSpawn_Element.ToLinkReference(context));
members.Add("SpawnedUser", SpawnedUser.ToLinkEmpty(context));
}

}
}
