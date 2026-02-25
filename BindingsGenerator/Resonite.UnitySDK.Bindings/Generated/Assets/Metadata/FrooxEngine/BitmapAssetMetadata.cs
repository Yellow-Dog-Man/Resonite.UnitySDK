
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BitmapAssetMetadata
// Generated on: středa 25. února 2026 16:13:04
// Resonite version: 2026.2.25.455
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> Asset;
public global::System.Int32 Width;
public global::System.Int32 Height;
public global::System.String BaseFormat;
public global::Elements.Assets.ColorChannelData ColorData;
public global::Elements.Assets.AlphaChannelData AlphaData;
public global::System.Double BitsPerPixel;
public global::System.Int32 ChannelCount;
public UnityEngine.ColorX AverageColor;
public UnityEngine.ColorX AverageVisibleColor;
public UnityEngine.ColorX AverageHSV;
public UnityEngine.ColorX AverageVisibleHSV;
public global::System.Int32 InvalidPixelCount;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Asset", Asset.ToResoniteReference(context));
members.Add("Width", Width.ToResoniteLinkField());
members.Add("Height", Height.ToResoniteLinkField());
members.Add("BaseFormat", BaseFormat.ToResoniteLinkField());
members.Add("ColorData", ColorData.ToResoniteLinkField());
members.Add("AlphaData", AlphaData.ToResoniteLinkField());
members.Add("BitsPerPixel", BitsPerPixel.ToResoniteLinkField());
members.Add("ChannelCount", ChannelCount.ToResoniteLinkField());
members.Add("AverageColor", AverageColor.ToResoniteLinkField());
members.Add("AverageVisibleColor", AverageVisibleColor.ToResoniteLinkField());
members.Add("AverageHSV", AverageHSV.ToResoniteLinkField());
members.Add("AverageVisibleHSV", AverageVisibleHSV.ToResoniteLinkField());
members.Add("InvalidPixelCount", InvalidPixelCount.ToResoniteLinkField());
}

}
}
