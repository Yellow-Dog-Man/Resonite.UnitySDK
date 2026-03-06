
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxEngineProxy
// Generated on: pátek 6. března 2026 14:18:37
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.IProtoFluxNode>, global::FrooxEngine.ProtoFlux.IProtoFluxNode> Node_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.ProtoFlux.IProtoFluxNode>, global::FrooxEngine.ProtoFlux.IProtoFluxNode, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.IProtoFluxNode>, global::FrooxEngine.ProtoFlux.IProtoFluxNode>> Path = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Node", Node_Element.ToLinkReference(context));
members.Add("Path", Path.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
