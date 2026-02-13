
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextRenderer
// Generated on: pátek 13. února 2026 23:21:37
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextRenderer")]
public partial class TextRenderer : global::FrooxEngine.ProceduralMesh, global::FrooxEngine.IBounded, global::FrooxEngine.IText, global::FrooxEngine.IRenderable

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.FontSet> Font;
public global::System.String Text;
public global::System.Boolean ParseRichText;
public global::System.String NullText;
public global::System.Single Size;
public global::Elements.Assets.TextHorizontalAlignment HorizontalAlign;
public global::Elements.Assets.TextVerticalAlignment VerticalAlign;
public global::Elements.Assets.AlignmentMode AlignmentMode;
public UnityEngine.ColorX Color;
public System.Collections.Generic.List<global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> Materials;
public global::System.Single LineHeight;
public global::System.Boolean Bounded;
public UnityEngine.Vector2 BoundsSize;
public global::Elements.Core.Alignment BoundsAlignment;
public global::System.String MaskPattern;
public global::System.Boolean HorizontalAutoSize;
public global::System.Boolean VerticalAutoSize;
public global::System.Int32 CaretPosition;
public global::System.Int32 SelectionStart;
public UnityEngine.ColorX CaretColor;
public UnityEngine.ColorX SelectionColor;
public global::FrooxEngine.FontMaterial _legacyFontMaterial;
public global::Elements.Core.Alignment _legacyAlign;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Font", new ResoniteLink.Reference() { });
members.Add("Text", Text.ToResoniteLinkField());
members.Add("ParseRichText", ParseRichText.ToResoniteLinkField());
members.Add("NullText", NullText.ToResoniteLinkField());
members.Add("Size", Size.ToResoniteLinkField());
members.Add("HorizontalAlign", HorizontalAlign.ToResoniteLinkField());
members.Add("VerticalAlign", VerticalAlign.ToResoniteLinkField());
members.Add("AlignmentMode", AlignmentMode.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("Materials", new ResoniteLink.SyncList()
{
    Elements = Materials.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("LineHeight", LineHeight.ToResoniteLinkField());
members.Add("Bounded", Bounded.ToResoniteLinkField());
members.Add("BoundsSize", BoundsSize.ToResoniteLinkField());
members.Add("BoundsAlignment", BoundsAlignment.ToResoniteLinkField());
members.Add("MaskPattern", MaskPattern.ToResoniteLinkField());
members.Add("HorizontalAutoSize", HorizontalAutoSize.ToResoniteLinkField());
members.Add("VerticalAutoSize", VerticalAutoSize.ToResoniteLinkField());
members.Add("CaretPosition", CaretPosition.ToResoniteLinkField());
members.Add("SelectionStart", SelectionStart.ToResoniteLinkField());
members.Add("CaretColor", CaretColor.ToResoniteLinkField());
members.Add("SelectionColor", SelectionColor.ToResoniteLinkField());
members.Add("_legacyFontMaterial", new ResoniteLink.Reference() { });
members.Add("_legacyAlign", _legacyAlign.ToResoniteLinkField());
}

}
}
