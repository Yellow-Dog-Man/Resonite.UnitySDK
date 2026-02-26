
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LODGroup
// Generated on: čtvrtek 26. února 2026 12:28:03
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LODGroup")]
public partial class LODGroup : global::FrooxEngine.ChangeHandlingRenderableComponent

{
    public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.LODGroup.LOD>, global::FrooxEngine.LODGroup.LOD> LODs = new();
public global::System.Boolean CrossFade { get => CrossFade_Element.Data; set => CrossFade_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CrossFade_Element = new();
public global::System.Boolean AnimateCrossFading { get => AnimateCrossFading_Element.Data; set => AnimateCrossFading_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AnimateCrossFading_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LODs", LODs.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("CrossFade", CrossFade_Element.ToLinkField(context));
members.Add("AnimateCrossFading", AnimateCrossFading_Element.ToLinkField(context));
}

}
}
