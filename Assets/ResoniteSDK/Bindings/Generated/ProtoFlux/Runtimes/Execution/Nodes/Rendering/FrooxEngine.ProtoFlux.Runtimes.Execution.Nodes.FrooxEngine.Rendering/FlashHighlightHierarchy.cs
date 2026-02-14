
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Rendering.FlashHighlightHierarchy
// Generated on: sobota 14. února 2026 8:58:23
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Rendering
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Rendering.FlashHighlightHierarchy")]
public partial class FlashHighlightHierarchy : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionBreakableFlowNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> HierarchyRoot;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> ExcludeColliders;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> ExcludeMeshes;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> ExcludeDisabled;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> TrackPosition;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Duration;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX> Color;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.Slot> FlashRoot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HierarchyRoot", HierarchyRoot.ToResoniteReference(context));
members.Add("ExcludeColliders", ExcludeColliders.ToResoniteReference(context));
members.Add("ExcludeMeshes", ExcludeMeshes.ToResoniteReference(context));
members.Add("ExcludeDisabled", ExcludeDisabled.ToResoniteReference(context));
members.Add("TrackPosition", TrackPosition.ToResoniteReference(context));
members.Add("Duration", Duration.ToResoniteReference(context));
members.Add("Color", Color.ToResoniteReference(context));
members.Add("FlashRoot", new ResoniteLink.EmptyElement());
}

}
}
