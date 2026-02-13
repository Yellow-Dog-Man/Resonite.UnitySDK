
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.RectTransformComputedProperties
// Generated on: pátek 13. února 2026 23:21:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.RectTransformComputedProperties")]
public partial class RectTransformComputedProperties : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.RectTransform Rect;
public UnityEngine.Rect LocalComputeRect;
public UnityEngine.Rect BoundingRect;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Rect", new ResoniteLink.Reference() { });
members.Add("LocalComputeRect", LocalComputeRect.ToResoniteLinkField());
members.Add("BoundingRect", BoundingRect.ToResoniteLinkField());
}

}
}
