
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxEngineProxy
// Generated on: čtvrtek 26. února 2026 12:27:28
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxEngineProxy")]
public abstract partial class ProtoFluxEngineProxy : global::FrooxEngine.Component

{
    public global::FrooxEngine.ProtoFlux.IProtoFluxNode Node { get => Node_Element.Data; set => Node_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.IProtoFluxNode>, global::FrooxEngine.ProtoFlux.IProtoFluxNode> Node_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.ProtoFlux.IProtoFluxNode>, global::FrooxEngine.ProtoFlux.IProtoFluxNode, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.IProtoFluxNode>, global::FrooxEngine.ProtoFlux.IProtoFluxNode>> Path = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Node", Node_Element.ToLinkReference(context));
members.Add("Path", Path.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
