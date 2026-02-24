
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.OpenWorld
// Generated on: úterý 24. února 2026 18:20:01
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.OpenWorld")]
public partial class OpenWorld : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.WorldURLActionNode

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.Userspace.WorldRelation> Relation;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> GetExisting;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> LoadingIndicator;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> AutoFocus;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> MakePrivate;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> SessionID;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<System.Uri> SessionURL;
public global::FrooxEngine.ProtoFlux.INodeOperation OnOpenStart;
public global::FrooxEngine.ProtoFlux.INodeOperation OnOpenDone;
public global::FrooxEngine.ProtoFlux.INodeOperation OnWorldReady;
public global::FrooxEngine.ProtoFlux.INodeOperation OnOpenFail;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Relation", Relation.ToResoniteReference(context));
members.Add("GetExisting", GetExisting.ToResoniteReference(context));
members.Add("LoadingIndicator", LoadingIndicator.ToResoniteReference(context));
members.Add("AutoFocus", AutoFocus.ToResoniteReference(context));
members.Add("MakePrivate", MakePrivate.ToResoniteReference(context));
members.Add("SessionID", new ResoniteLink.EmptyElement());
members.Add("SessionURL", new ResoniteLink.EmptyElement());
members.Add("OnOpenStart", OnOpenStart.ToResoniteReference(context));
members.Add("OnOpenDone", OnOpenDone.ToResoniteReference(context));
members.Add("OnWorldReady", OnWorldReady.ToResoniteReference(context));
members.Add("OnOpenFail", OnOpenFail.ToResoniteReference(context));
}

}
}
