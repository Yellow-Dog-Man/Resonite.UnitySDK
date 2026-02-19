
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Experimental.WriteTextToFile
// Generated on: čtvrtek 19. února 2026 7:59:50
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("String", String.ToResoniteReference(context));
members.Add("FilePath", FilePath.ToResoniteReference(context));
members.Add("Append", Append.ToResoniteReference(context));
members.Add("NewLine", NewLine.ToResoniteReference(context));
members.Add("OnWriteStarted", OnWriteStarted.ToResoniteReference(context));
members.Add("OnWriteFinished", OnWriteFinished.ToResoniteReference(context));
members.Add("OnWriteFail", OnWriteFail.ToResoniteReference(context));
}

}
}
