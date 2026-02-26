
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.Text
// Generated on: čtvrtek 26. února 2026 15:08:31
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.FontSet> Font { get => Font_Element.Data; set => Font_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.FontSet>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.FontSet>> Font_Element = new();
public global::System.String Content { get => Content_Element.Data; set => Content_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Content_Element = new();
public global::System.Boolean ParseRichText { get => ParseRichText_Element.Data; set => ParseRichText_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ParseRichText_Element = new();
public global::System.String NullContent { get => NullContent_Element.Data; set => NullContent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> NullContent_Element = new();
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
public global::System.String MaskPattern { get => MaskPattern_Element.Data; set => MaskPattern_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> MaskPattern_Element = new();
public global::System.Boolean HorizontalAutoSize { get => HorizontalAutoSize_Element.Data; set => HorizontalAutoSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HorizontalAutoSize_Element = new();
public global::System.Boolean VerticalAutoSize { get => VerticalAutoSize_Element.Data; set => VerticalAutoSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> VerticalAutoSize_Element = new();
public global::System.Single AutoSizeMin { get => AutoSizeMin_Element.Data; set => AutoSizeMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AutoSizeMin_Element = new();
public global::System.Single AutoSizeMax { get => AutoSizeMax_Element.Data; set => AutoSizeMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AutoSizeMax_Element = new();
public global::System.Int32 CaretPosition { get => CaretPosition_Element.Data; set => CaretPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> CaretPosition_Element = new();
public global::System.Int32 SelectionStart { get => SelectionStart_Element.Data; set => SelectionStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> SelectionStart_Element = new();
public UnityEngine.ColorX CaretColor { get => CaretColor_Element.Data; set => CaretColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> CaretColor_Element = new();
public UnityEngine.ColorX SelectionColor { get => SelectionColor_Element.Data; set => SelectionColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SelectionColor_Element = new();
public global::System.Boolean InteractionTarget { get => InteractionTarget_Element.Data; set => InteractionTarget_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> InteractionTarget_Element = new();
public global::FrooxEngine.FontMaterial _legacyFontMaterial { get => _legacyFontMaterial_Element.Data; set => _legacyFontMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.FontMaterial>, global::FrooxEngine.FontMaterial> _legacyFontMaterial_Element = new();
public global::Elements.Core.Alignment _legacyAlign { get => _legacyAlign_Element.Data; set => _legacyAlign_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Core.Alignment>, global::Elements.Core.Alignment> _legacyAlign_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Font", Font_Element.ToLinkReference(context));
members.Add("Content", Content_Element.ToLinkField(context));
members.Add("ParseRichText", ParseRichText_Element.ToLinkField(context));
members.Add("NullContent", NullContent_Element.ToLinkField(context));
members.Add("Size", Size_Element.ToLinkField(context));
members.Add("HorizontalAlign", HorizontalAlign_Element.ToLinkField(context));
members.Add("VerticalAlign", VerticalAlign_Element.ToLinkField(context));
members.Add("AlignmentMode", AlignmentMode_Element.ToLinkField(context));
members.Add("Color", Color_Element.ToLinkField(context));
members.Add("Materials", Materials.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("LineHeight", LineHeight_Element.ToLinkField(context));
members.Add("MaskPattern", MaskPattern_Element.ToLinkField(context));
members.Add("HorizontalAutoSize", HorizontalAutoSize_Element.ToLinkField(context));
members.Add("VerticalAutoSize", VerticalAutoSize_Element.ToLinkField(context));
members.Add("AutoSizeMin", AutoSizeMin_Element.ToLinkField(context));
members.Add("AutoSizeMax", AutoSizeMax_Element.ToLinkField(context));
members.Add("CaretPosition", CaretPosition_Element.ToLinkField(context));
members.Add("SelectionStart", SelectionStart_Element.ToLinkField(context));
members.Add("CaretColor", CaretColor_Element.ToLinkField(context));
members.Add("SelectionColor", SelectionColor_Element.ToLinkField(context));
members.Add("InteractionTarget", InteractionTarget_Element.ToLinkField(context));
members.Add("_legacyFontMaterial", _legacyFontMaterial_Element.ToLinkReference(context));
members.Add("_legacyAlign", _legacyAlign_Element.ToLinkField(context));
}

}
}
