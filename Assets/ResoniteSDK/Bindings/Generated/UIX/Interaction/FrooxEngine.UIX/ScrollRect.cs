
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ScrollRect
// Generated on: pátek 13. února 2026 5:52:19
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ScrollRect")]
public partial class ScrollRect : global::FrooxEngine.UIX.UIController, global::FrooxEngine.UIX.IUIInteractable

{
    public UnityEngine.Vector2 NormalizedPosition;
public global::FrooxEngine.UIX.LayoutHorizontalAlignment HorizontalAlign;
public global::FrooxEngine.UIX.LayoutVerticalAlignment VerticalAlign;
public global::FrooxEngine.UIX.RectTransform ViewportOverride;
public global::FrooxEngine.UIX.RectTransform __legacyContent;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("NormalizedPosition", NormalizedPosition.ToResoniteLinkField());
members.Add("HorizontalAlign", HorizontalAlign.ToResoniteLinkField());
members.Add("VerticalAlign", VerticalAlign.ToResoniteLinkField());
members.Add("ViewportOverride", new ResoniteLink.Reference() { });
members.Add("__legacyContent", new ResoniteLink.Reference() { });
}

}
}
