
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.OpenWorld
// Generated on: pátek 13. února 2026 5:52:18
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Relation", new ResoniteLink.Reference() { });
members.Add("GetExisting", new ResoniteLink.Reference() { });
members.Add("LoadingIndicator", new ResoniteLink.Reference() { });
members.Add("AutoFocus", new ResoniteLink.Reference() { });
members.Add("MakePrivate", new ResoniteLink.Reference() { });
members.Add("SessionID", new ResoniteLink.EmptyElement());
members.Add("SessionURL", new ResoniteLink.EmptyElement());
members.Add("OnOpenStart", new ResoniteLink.Reference() { });
members.Add("OnOpenDone", new ResoniteLink.Reference() { });
members.Add("OnWorldReady", new ResoniteLink.Reference() { });
members.Add("OnOpenFail", new ResoniteLink.Reference() { });
}

}
}
