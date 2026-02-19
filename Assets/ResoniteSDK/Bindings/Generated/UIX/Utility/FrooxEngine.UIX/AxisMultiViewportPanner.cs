
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.AxisMultiViewportPanner
// Generated on: čtvrtek 19. února 2026 8:00:25
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ViewportIndex", ViewportIndex.ToResoniteLinkField());
members.Add("AnimationTime", AnimationTime.ToResoniteLinkField());
members.Add("Direction", Direction.ToResoniteLinkField());
members.Add("Viewports", new ResoniteLink.SyncList()
{
    Elements = Viewports.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
