
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.RectTransform
// Generated on: středa 25. února 2026 16:13:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.RectTransform")]
public partial class RectTransform : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public UnityEngine.Vector2 AnchorMin;
public UnityEngine.Vector2 AnchorMax;
public UnityEngine.Vector2 OffsetMin;
public UnityEngine.Vector2 OffsetMax;
public UnityEngine.Vector2 Pivot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AnchorMin", AnchorMin.ToResoniteLinkField());
members.Add("AnchorMax", AnchorMax.ToResoniteLinkField());
members.Add("OffsetMin", OffsetMin.ToResoniteLinkField());
members.Add("OffsetMax", OffsetMax.ToResoniteLinkField());
members.Add("Pivot", Pivot.ToResoniteLinkField());
}

}
}
