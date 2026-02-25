
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ArcSegmentLayout
// Generated on: středa 25. února 2026 16:14:34
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ArcSegmentLayout")]
public partial class ArcSegmentLayout : global::FrooxEngine.UIX.LayoutController

{
    public global::FrooxEngine.UIX.RectTransform Nested;
public global::System.Single NestedSizeRatio;
public global::FrooxEngine.UIX.Text Label;
public UnityEngine.Vector2 LabelSize;
public global::System.Single LabelDistance;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Nested", Nested.ToResoniteReference(context));
members.Add("NestedSizeRatio", NestedSizeRatio.ToResoniteLinkField());
members.Add("Label", Label.ToResoniteReference(context));
members.Add("LabelSize", LabelSize.ToResoniteLinkField());
members.Add("LabelDistance", LabelDistance.ToResoniteLinkField());
}

}
}
