
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.AxisMultiViewportPanner
// Generated on: čtvrtek 26. února 2026 15:09:09
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.Int32 ViewportIndex { get => ViewportIndex_Element.Data; set => ViewportIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> ViewportIndex_Element = new();
public global::System.Single AnimationTime { get => AnimationTime_Element.Data; set => AnimationTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AnimationTime_Element = new();
public global::FrooxEngine.UIX.AxisMultiViewportPanner.AlignDirection Direction { get => Direction_Element.Data; set => Direction_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UIX.AxisMultiViewportPanner.AlignDirection>, global::FrooxEngine.UIX.AxisMultiViewportPanner.AlignDirection> Direction_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.UIX.AxisMultiViewportPanner.Viewport>, global::FrooxEngine.UIX.AxisMultiViewportPanner.Viewport> Viewports = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ViewportIndex", ViewportIndex_Element.ToLinkField(context));
members.Add("AnimationTime", AnimationTime_Element.ToLinkField(context));
members.Add("Direction", Direction_Element.ToLinkField(context));
members.Add("Viewports", Viewports.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
