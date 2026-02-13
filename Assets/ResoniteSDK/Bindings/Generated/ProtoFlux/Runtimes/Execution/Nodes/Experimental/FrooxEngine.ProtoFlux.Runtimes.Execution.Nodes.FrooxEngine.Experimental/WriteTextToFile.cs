
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Experimental.WriteTextToFile
// Generated on: pátek 13. února 2026 5:51:52
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Experimental
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Experimental.WriteTextToFile")]
public partial class WriteTextToFile : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> String;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> FilePath;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Append;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> NewLine;
public global::FrooxEngine.ProtoFlux.INodeOperation OnWriteStarted;
public global::FrooxEngine.ProtoFlux.INodeOperation OnWriteFinished;
public global::FrooxEngine.ProtoFlux.INodeOperation OnWriteFail;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("String", new ResoniteLink.Reference() { });
members.Add("FilePath", new ResoniteLink.Reference() { });
members.Add("Append", new ResoniteLink.Reference() { });
members.Add("NewLine", new ResoniteLink.Reference() { });
members.Add("OnWriteStarted", new ResoniteLink.Reference() { });
members.Add("OnWriteFinished", new ResoniteLink.Reference() { });
members.Add("OnWriteFail", new ResoniteLink.Reference() { });
}

}
}
