
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BitmapAssetMetadata
// Generated on: čtvrtek 26. února 2026 12:26:49
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BitmapAssetMetadata")]
public partial class BitmapAssetMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> Asset { get => Asset_Element.Data; set => Asset_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D>> Asset_Element = new();
public global::System.Int32 Width { get => Width_Element.Data; set => Width_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> Width_Element = new();
public global::System.Int32 Height { get => Height_Element.Data; set => Height_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> Height_Element = new();
public global::System.String BaseFormat { get => BaseFormat_Element.Data; set => BaseFormat_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> BaseFormat_Element = new();
public global::Elements.Assets.ColorChannelData ColorData { get => ColorData_Element.Data; set => ColorData_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::Elements.Assets.ColorChannelData>, global::Elements.Assets.ColorChannelData> ColorData_Element = new();
public global::Elements.Assets.AlphaChannelData AlphaData { get => AlphaData_Element.Data; set => AlphaData_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::Elements.Assets.AlphaChannelData>, global::Elements.Assets.AlphaChannelData> AlphaData_Element = new();
public global::System.Double BitsPerPixel { get => BitsPerPixel_Element.Data; set => BitsPerPixel_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Double>, global::System.Double> BitsPerPixel_Element = new();
public global::System.Int32 ChannelCount { get => ChannelCount_Element.Data; set => ChannelCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> ChannelCount_Element = new();
public UnityEngine.ColorX AverageColor { get => AverageColor_Element.Data; set => AverageColor_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.ColorX>, UnityEngine.ColorX> AverageColor_Element = new();
public UnityEngine.ColorX AverageVisibleColor { get => AverageVisibleColor_Element.Data; set => AverageVisibleColor_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.ColorX>, UnityEngine.ColorX> AverageVisibleColor_Element = new();
public UnityEngine.ColorX AverageHSV { get => AverageHSV_Element.Data; set => AverageHSV_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.ColorX>, UnityEngine.ColorX> AverageHSV_Element = new();
public UnityEngine.ColorX AverageVisibleHSV { get => AverageVisibleHSV_Element.Data; set => AverageVisibleHSV_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.ColorX>, UnityEngine.ColorX> AverageVisibleHSV_Element = new();
public global::System.Int32 InvalidPixelCount { get => InvalidPixelCount_Element.Data; set => InvalidPixelCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> InvalidPixelCount_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Asset", Asset_Element.ToLinkReference(context));
members.Add("Width", Width_Element.ToLinkField(context));
members.Add("Height", Height_Element.ToLinkField(context));
members.Add("BaseFormat", BaseFormat_Element.ToLinkField(context));
members.Add("ColorData", ColorData_Element.ToLinkField(context));
members.Add("AlphaData", AlphaData_Element.ToLinkField(context));
members.Add("BitsPerPixel", BitsPerPixel_Element.ToLinkField(context));
members.Add("ChannelCount", ChannelCount_Element.ToLinkField(context));
members.Add("AverageColor", AverageColor_Element.ToLinkField(context));
members.Add("AverageVisibleColor", AverageVisibleColor_Element.ToLinkField(context));
members.Add("AverageHSV", AverageHSV_Element.ToLinkField(context));
members.Add("AverageVisibleHSV", AverageVisibleHSV_Element.ToLinkField(context));
members.Add("InvalidPixelCount", InvalidPixelCount_Element.ToLinkField(context));
}

}
}
