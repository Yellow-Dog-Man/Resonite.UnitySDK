
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.AxisMultiViewportPanner
// Generated on: pátek 13. února 2026 23:23:12
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.AxisMultiViewportPanner")]
public partial class AxisMultiViewportPanner : global::FrooxEngine.Component

{
    public global::System.Int32 ViewportIndex;
public global::System.Single AnimationTime;
public global::FrooxEngine.UIX.AxisMultiViewportPanner.AlignDirection Direction;
public System.Collections.Generic.List<global::FrooxEngine.UIX.AxisMultiViewportPanner.Viewport> Viewports;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ViewportIndex", ViewportIndex.ToResoniteLinkField());
members.Add("AnimationTime", AnimationTime.ToResoniteLinkField());
members.Add("Direction", Direction.ToResoniteLinkField());
members.Add("Viewports", new ResoniteLink.SyncList()
{
    Elements = Viewports.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
}

}
}
