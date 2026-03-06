
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.RectTransformComputedProperties
// Generated on: pátek 6. března 2026 14:18:08
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::FrooxEngine.UIX.RectTransform Rect { get => Rect_Element.Data; set => Rect_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> Rect_Element = new();
public UnityEngine.Rect LocalComputeRect { get => LocalComputeRect_Element.Data; set => LocalComputeRect_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Rect>, UnityEngine.Rect> LocalComputeRect_Element = new();
public UnityEngine.Rect BoundingRect { get => BoundingRect_Element.Data; set => BoundingRect_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Rect>, UnityEngine.Rect> BoundingRect_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Rect", Rect_Element.ToLinkReference(context));
members.Add("LocalComputeRect", LocalComputeRect_Element.ToLinkField(context));
members.Add("BoundingRect", BoundingRect_Element.ToLinkField(context));
}

}
}
