
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.OpenWorld
// Generated on: čtvrtek 26. února 2026 10:04:35
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.OpenWorld")]
public partial class OpenWorld : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.WorldURLActionNode

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.Userspace.WorldRelation> Relation { get => Relation_Element.Data; set => Relation_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.Userspace.WorldRelation>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.Userspace.WorldRelation>> Relation_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> GetExisting { get => GetExisting_Element.Data; set => GetExisting_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> GetExisting_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> LoadingIndicator { get => LoadingIndicator_Element.Data; set => LoadingIndicator_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> LoadingIndicator_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> AutoFocus { get => AutoFocus_Element.Data; set => AutoFocus_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> AutoFocus_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> MakePrivate { get => MakePrivate_Element.Data; set => MakePrivate_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> MakePrivate_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> SessionID = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<System.Uri> SessionURL = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnOpenStart { get => OnOpenStart_Element.Data; set => OnOpenStart_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnOpenStart_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnOpenDone { get => OnOpenDone_Element.Data; set => OnOpenDone_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnOpenDone_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnWorldReady { get => OnWorldReady_Element.Data; set => OnWorldReady_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnWorldReady_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnOpenFail { get => OnOpenFail_Element.Data; set => OnOpenFail_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnOpenFail_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Relation", Relation_Element.Data.ToResoniteReference(context));
members.Add("GetExisting", GetExisting_Element.Data.ToResoniteReference(context));
members.Add("LoadingIndicator", LoadingIndicator_Element.Data.ToResoniteReference(context));
members.Add("AutoFocus", AutoFocus_Element.Data.ToResoniteReference(context));
members.Add("MakePrivate", MakePrivate_Element.Data.ToResoniteReference(context));
members.Add("SessionID", new ResoniteLink.EmptyElement());
members.Add("SessionURL", new ResoniteLink.EmptyElement());
members.Add("OnOpenStart", OnOpenStart_Element.Data.ToResoniteReference(context));
members.Add("OnOpenDone", OnOpenDone_Element.Data.ToResoniteReference(context));
members.Add("OnWorldReady", OnWorldReady_Element.Data.ToResoniteReference(context));
members.Add("OnOpenFail", OnOpenFail_Element.Data.ToResoniteReference(context));
}

}
}
