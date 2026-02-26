
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextRenderer
// Generated on: čtvrtek 26. února 2026 15:07:57
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.FontSet> Font { get => Font_Element.Data; set => Font_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.FontSet>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.FontSet>> Font_Element = new();
public global::System.String Text { get => Text_Element.Data; set => Text_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Text_Element = new();
public global::System.Boolean ParseRichText { get => ParseRichText_Element.Data; set => ParseRichText_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ParseRichText_Element = new();
public global::System.String NullText { get => NullText_Element.Data; set => NullText_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> NullText_Element = new();
public global::System.Single Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Size_Element = new();
public global::Elements.Assets.TextHorizontalAlignment HorizontalAlign { get => HorizontalAlign_Element.Data; set => HorizontalAlign_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.TextHorizontalAlignment>, global::Elements.Assets.TextHorizontalAlignment> HorizontalAlign_Element = new();
public global::Elements.Assets.TextVerticalAlignment VerticalAlign { get => VerticalAlign_Element.Data; set => VerticalAlign_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.TextVerticalAlignment>, global::Elements.Assets.TextVerticalAlignment> VerticalAlign_Element = new();
public global::Elements.Assets.AlignmentMode AlignmentMode { get => AlignmentMode_Element.Data; set => AlignmentMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.AlignmentMode>, global::Elements.Assets.AlignmentMode> AlignmentMode_Element = new();
public UnityEngine.ColorX Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncAssetList<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>, Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>>> Materials = new();
public global::System.Single LineHeight { get => LineHeight_Element.Data; set => LineHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LineHeight_Element = new();
public global::System.Boolean Bounded { get => Bounded_Element.Data; set => Bounded_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Bounded_Element = new();
public UnityEngine.Vector2 BoundsSize { get => BoundsSize_Element.Data; set => BoundsSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> BoundsSize_Element = new();
public global::Elements.Core.Alignment BoundsAlignment { get => BoundsAlignment_Element.Data; set => BoundsAlignment_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Core.Alignment>, global::Elements.Core.Alignment> BoundsAlignment_Element = new();
public global::System.String MaskPattern { get => MaskPattern_Element.Data; set => MaskPattern_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> MaskPattern_Element = new();
public global::System.Boolean HorizontalAutoSize { get => HorizontalAutoSize_Element.Data; set => HorizontalAutoSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HorizontalAutoSize_Element = new();
public global::System.Boolean VerticalAutoSize { get => VerticalAutoSize_Element.Data; set => VerticalAutoSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> VerticalAutoSize_Element = new();
public global::System.Int32 CaretPosition { get => CaretPosition_Element.Data; set => CaretPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> CaretPosition_Element = new();
public global::System.Int32 SelectionStart { get => SelectionStart_Element.Data; set => SelectionStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> SelectionStart_Element = new();
public UnityEngine.ColorX CaretColor { get => CaretColor_Element.Data; set => CaretColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> CaretColor_Element = new();
public UnityEngine.ColorX SelectionColor { get => SelectionColor_Element.Data; set => SelectionColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SelectionColor_Element = new();
public global::FrooxEngine.FontMaterial _legacyFontMaterial { get => _legacyFontMaterial_Element.Data; set => _legacyFontMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.FontMaterial>, global::FrooxEngine.FontMaterial> _legacyFontMaterial_Element = new();
public global::Elements.Core.Alignment _legacyAlign { get => _legacyAlign_Element.Data; set => _legacyAlign_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Core.Alignment>, global::Elements.Core.Alignment> _legacyAlign_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Font", Font_Element.ToLinkReference(context));
members.Add("Text", Text_Element.ToLinkField(context));
members.Add("ParseRichText", ParseRichText_Element.ToLinkField(context));
members.Add("NullText", NullText_Element.ToLinkField(context));
members.Add("Size", Size_Element.ToLinkField(context));
members.Add("HorizontalAlign", HorizontalAlign_Element.ToLinkField(context));
members.Add("VerticalAlign", VerticalAlign_Element.ToLinkField(context));
members.Add("AlignmentMode", AlignmentMode_Element.ToLinkField(context));
members.Add("Color", Color_Element.ToLinkField(context));
members.Add("Materials", Materials.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("LineHeight", LineHeight_Element.ToLinkField(context));
members.Add("Bounded", Bounded_Element.ToLinkField(context));
members.Add("BoundsSize", BoundsSize_Element.ToLinkField(context));
members.Add("BoundsAlignment", BoundsAlignment_Element.ToLinkField(context));
members.Add("MaskPattern", MaskPattern_Element.ToLinkField(context));
members.Add("HorizontalAutoSize", HorizontalAutoSize_Element.ToLinkField(context));
members.Add("VerticalAutoSize", VerticalAutoSize_Element.ToLinkField(context));
members.Add("CaretPosition", CaretPosition_Element.ToLinkField(context));
members.Add("SelectionStart", SelectionStart_Element.ToLinkField(context));
members.Add("CaretColor", CaretColor_Element.ToLinkField(context));
members.Add("SelectionColor", SelectionColor_Element.ToLinkField(context));
members.Add("_legacyFontMaterial", _legacyFontMaterial_Element.ToLinkReference(context));
members.Add("_legacyAlign", _legacyAlign_Element.ToLinkField(context));
}

}
}
