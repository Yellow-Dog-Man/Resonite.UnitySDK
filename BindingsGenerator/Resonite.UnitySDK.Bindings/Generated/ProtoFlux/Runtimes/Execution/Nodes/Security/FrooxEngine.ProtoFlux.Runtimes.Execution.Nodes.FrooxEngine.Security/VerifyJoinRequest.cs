
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Security.VerifyJoinRequest
// Generated on: čtvrtek 26. února 2026 10:04:29
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.ProtoFlux.INodeOperation Verify { get => Verify_Element.Data; set => Verify_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> Verify_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> UserId = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> UserSessionId = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> MachineId = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> Username = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::Renderite.Shared.HeadOutputDevice> HeadOutputDevice = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::FrooxEngine.Platform> Platform = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsInvited = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsContact = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsInKioskMode = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsSpectatorBanned = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsMuteBanned = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Security.JoinRequestHandle> Handle = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Verify", Verify_Element.Data.ToResoniteReference(context));
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
