
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.Text
// Generated on: středa 25. února 2026 16:13:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.Text")]
public partial class Text : global::FrooxEngine.UIX.Graphic, global::FrooxEngine.UIX.ILayoutElement, global::FrooxEngine.IText

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.FontSet> Font;
public global::System.String Content;
public global::System.Boolean ParseRichText;
public global::System.String NullContent;
public global::System.Single Size;
public global::Elements.Assets.TextHorizontalAlignment HorizontalAlign;
public global::Elements.Assets.TextVerticalAlignment VerticalAlign;
public global::Elements.Assets.AlignmentMode AlignmentMode;
public UnityEngine.ColorX Color;
public System.Collections.Generic.List<global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> Materials;
public global::System.Single LineHeight;
public global::System.String MaskPattern;
public global::System.Boolean HorizontalAutoSize;
public global::System.Boolean VerticalAutoSize;
public global::System.Single AutoSizeMin;
public global::System.Single AutoSizeMax;
public global::System.Int32 CaretPosition;
public global::System.Int32 SelectionStart;
public UnityEngine.ColorX CaretColor;
public UnityEngine.ColorX SelectionColor;
public global::System.Boolean InteractionTarget;
public global::FrooxEngine.FontMaterial _legacyFontMaterial;
public global::Elements.Core.Alignment _legacyAlign;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Font", Font.ToResoniteReference(context));
members.Add("Content", Content.ToResoniteLinkField());
members.Add("ParseRichText", ParseRichText.ToResoniteLinkField());
members.Add("NullContent", NullContent.ToResoniteLinkField());
members.Add("Size", Size.ToResoniteLinkField());
members.Add("HorizontalAlign", HorizontalAlign.ToResoniteLinkField());
members.Add("VerticalAlign", VerticalAlign.ToResoniteLinkField());
members.Add("AlignmentMode", AlignmentMode.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("Materials", new ResoniteLink.SyncList()
{
    Elements = Materials.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("LineHeight", LineHeight.ToResoniteLinkField());
members.Add("MaskPattern", MaskPattern.ToResoniteLinkField());
members.Add("HorizontalAutoSize", HorizontalAutoSize.ToResoniteLinkField());
members.Add("VerticalAutoSize", VerticalAutoSize.ToResoniteLinkField());
members.Add("AutoSizeMin", AutoSizeMin.ToResoniteLinkField());
members.Add("AutoSizeMax", AutoSizeMax.ToResoniteLinkField());
members.Add("CaretPosition", CaretPosition.ToResoniteLinkField());
members.Add("SelectionStart", SelectionStart.ToResoniteLinkField());
members.Add("CaretColor", CaretColor.ToResoniteLinkField());
members.Add("SelectionColor", SelectionColor.ToResoniteLinkField());
members.Add("InteractionTarget", InteractionTarget.ToResoniteLinkField());
members.Add("_legacyFontMaterial", _legacyFontMaterial.ToResoniteReference(context));
members.Add("_legacyAlign", _legacyAlign.ToResoniteLinkField());
}

}
}
