
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.RectTransformComputedProperties
// Generated on: úterý 24. února 2026 18:17:49
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Rect", Rect.ToResoniteReference(context));
members.Add("LocalComputeRect", LocalComputeRect.ToResoniteLinkField());
members.Add("BoundingRect", BoundingRect.ToResoniteLinkField());
}

}
}
