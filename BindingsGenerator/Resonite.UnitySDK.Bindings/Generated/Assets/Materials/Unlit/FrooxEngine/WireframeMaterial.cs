
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WireframeMaterial
// Generated on: středa 25. února 2026 16:13:03
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WireframeMaterial")]
public partial class WireframeMaterial : global::FrooxEngine.MaterialProvider, global::FrooxEngine.ICommonMaterial

{
    public global::System.Single Thickness;
public global::System.Boolean ScreenSpace;
public UnityEngine.ColorX LineColor;
public UnityEngine.ColorX FillColor;
public UnityEngine.ColorX InnerLineColor;
public UnityEngine.ColorX InnerFillColor;
public global::System.Boolean UseFresnel;
public UnityEngine.ColorX LineFarColor;
public UnityEngine.ColorX FillFarColor;
public UnityEngine.ColorX InnerLineFarColor;
public UnityEngine.ColorX InnerFillFarColor;
public global::System.Single Exp;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture;
public global::FrooxEngine.ZWrite ZWrite;
public global::System.Boolean DoubleSided;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Int32 RenderQueue;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _regular;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _regularDoubleSided;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Thickness", Thickness.ToResoniteLinkField());
members.Add("ScreenSpace", ScreenSpace.ToResoniteLinkField());
members.Add("LineColor", LineColor.ToResoniteLinkField());
members.Add("FillColor", FillColor.ToResoniteLinkField());
members.Add("InnerLineColor", InnerLineColor.ToResoniteLinkField());
members.Add("InnerFillColor", InnerFillColor.ToResoniteLinkField());
members.Add("UseFresnel", UseFresnel.ToResoniteLinkField());
members.Add("LineFarColor", LineFarColor.ToResoniteLinkField());
members.Add("FillFarColor", FillFarColor.ToResoniteLinkField());
members.Add("InnerLineFarColor", InnerLineFarColor.ToResoniteLinkField());
members.Add("InnerFillFarColor", InnerFillFarColor.ToResoniteLinkField());
members.Add("Exp", Exp.ToResoniteLinkField());
members.Add("Texture", Texture.ToResoniteReference(context));
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("DoubleSided", DoubleSided.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
members.Add("_regular", _regular.ToResoniteReference(context));
members.Add("_regularDoubleSided", _regularDoubleSided.ToResoniteReference(context));
}

}
}
