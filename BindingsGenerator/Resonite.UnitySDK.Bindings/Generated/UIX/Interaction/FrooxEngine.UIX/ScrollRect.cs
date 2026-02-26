
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ScrollRect
// Generated on: čtvrtek 26. února 2026 12:28:02
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ScrollRect")]
public partial class ScrollRect : global::FrooxEngine.UIX.UIController, global::FrooxEngine.UIX.IUIInteractable

{
    public UnityEngine.Vector2 NormalizedPosition { get => NormalizedPosition_Element.Data; set => NormalizedPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> NormalizedPosition_Element = new();
public global::FrooxEngine.UIX.LayoutHorizontalAlignment HorizontalAlign { get => HorizontalAlign_Element.Data; set => HorizontalAlign_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UIX.LayoutHorizontalAlignment>, global::FrooxEngine.UIX.LayoutHorizontalAlignment> HorizontalAlign_Element = new();
public global::FrooxEngine.UIX.LayoutVerticalAlignment VerticalAlign { get => VerticalAlign_Element.Data; set => VerticalAlign_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UIX.LayoutVerticalAlignment>, global::FrooxEngine.UIX.LayoutVerticalAlignment> VerticalAlign_Element = new();
public global::FrooxEngine.UIX.RectTransform ViewportOverride { get => ViewportOverride_Element.Data; set => ViewportOverride_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> ViewportOverride_Element = new();
public global::FrooxEngine.UIX.RectTransform __legacyContent { get => __legacyContent_Element.Data; set => __legacyContent_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> __legacyContent_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NormalizedPosition", NormalizedPosition_Element.ToLinkField(context));
members.Add("HorizontalAlign", HorizontalAlign_Element.ToLinkField(context));
members.Add("VerticalAlign", VerticalAlign_Element.ToLinkField(context));
members.Add("ViewportOverride", ViewportOverride_Element.ToLinkReference(context));
members.Add("__legacyContent", __legacyContent_Element.ToLinkReference(context));
}

}
}
