
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LODGroup
// Generated on: pátek 13. února 2026 23:23:04
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("LODs", new ResoniteLink.SyncList()
{
    Elements = LODs.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
members.Add("CrossFade", CrossFade.ToResoniteLinkField());
members.Add("AnimateCrossFading", AnimateCrossFading.ToResoniteLinkField());
}

}
}
