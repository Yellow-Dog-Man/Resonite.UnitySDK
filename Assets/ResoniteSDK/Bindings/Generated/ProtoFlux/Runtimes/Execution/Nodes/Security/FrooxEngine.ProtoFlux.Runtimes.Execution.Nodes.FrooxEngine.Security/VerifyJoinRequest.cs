
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Security.VerifyJoinRequest
// Generated on: pátek 13. února 2026 23:22:53
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Security
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Security.VerifyJoinRequest")]
public partial class VerifyJoinRequest : global::FrooxEngine.FrooxEngine.ProtoFlux.ProxyVoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Security.VerifyJoinRequest.Proxy>

{
    public global::FrooxEngine.ProtoFlux.INodeOperation Verify;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> UserId;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> UserSessionId;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> MachineId;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> Username;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::Renderite.Shared.HeadOutputDevice> HeadOutputDevice;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::FrooxEngine.Platform> Platform;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsInvited;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsContact;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsInKioskMode;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsSpectatorBanned;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsMuteBanned;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Security.JoinRequestHandle> Handle;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Verify", new ResoniteLink.Reference() { });
members.Add("UserId", new ResoniteLink.EmptyElement());
members.Add("UserSessionId", new ResoniteLink.EmptyElement());
members.Add("MachineId", new ResoniteLink.EmptyElement());
members.Add("Username", new ResoniteLink.EmptyElement());
members.Add("HeadOutputDevice", new ResoniteLink.EmptyElement());
members.Add("Platform", new ResoniteLink.EmptyElement());
members.Add("IsInvited", new ResoniteLink.EmptyElement());
members.Add("IsContact", new ResoniteLink.EmptyElement());
members.Add("IsInKioskMode", new ResoniteLink.EmptyElement());
members.Add("IsSpectatorBanned", new ResoniteLink.EmptyElement());
members.Add("IsMuteBanned", new ResoniteLink.EmptyElement());
members.Add("Handle", new ResoniteLink.EmptyElement());
}

}
}
