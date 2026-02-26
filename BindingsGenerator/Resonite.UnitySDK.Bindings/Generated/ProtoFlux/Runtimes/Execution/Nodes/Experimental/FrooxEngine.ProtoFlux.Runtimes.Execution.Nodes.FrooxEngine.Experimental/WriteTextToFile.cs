
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Experimental.WriteTextToFile
// Generated on: čtvrtek 26. února 2026 12:27:33
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> String { get => String_Element.Data; set => String_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> String_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> FilePath { get => FilePath_Element.Data; set => FilePath_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> FilePath_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Append { get => Append_Element.Data; set => Append_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> Append_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> NewLine { get => NewLine_Element.Data; set => NewLine_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> NewLine_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnWriteStarted { get => OnWriteStarted_Element.Data; set => OnWriteStarted_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnWriteStarted_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnWriteFinished { get => OnWriteFinished_Element.Data; set => OnWriteFinished_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnWriteFinished_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnWriteFail { get => OnWriteFail_Element.Data; set => OnWriteFail_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnWriteFail_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("String", String_Element.ToLinkReference(context));
members.Add("FilePath", FilePath_Element.ToLinkReference(context));
members.Add("Append", Append_Element.ToLinkReference(context));
members.Add("NewLine", NewLine_Element.ToLinkReference(context));
members.Add("OnWriteStarted", OnWriteStarted_Element.ToLinkReference(context));
members.Add("OnWriteFinished", OnWriteFinished_Element.ToLinkReference(context));
members.Add("OnWriteFail", OnWriteFail_Element.ToLinkReference(context));
}

}
}
