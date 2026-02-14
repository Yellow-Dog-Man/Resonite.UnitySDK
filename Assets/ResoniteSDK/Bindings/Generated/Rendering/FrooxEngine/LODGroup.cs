
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LODGroup
// Generated on: sobota 14. února 2026 8:58:33
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
    public System.Collections.Generic.List<global::FrooxEngine.LODGroup.LOD> LODs;
public global::System.Boolean CrossFade;
public global::System.Boolean AnimateCrossFading;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LODs", new ResoniteLink.SyncList()
{
    Elements = LODs.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("CrossFade", CrossFade.ToResoniteLinkField());
members.Add("AnimateCrossFading", AnimateCrossFading.ToResoniteLinkField());
}

}
}
