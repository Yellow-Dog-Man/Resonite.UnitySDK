
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WireframeMaterial
// Generated on: čtvrtek 26. února 2026 10:03:35
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
    public global::System.Single Thickness { get => Thickness_Element.Data; set => Thickness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Thickness_Element = new();
public global::System.Boolean ScreenSpace { get => ScreenSpace_Element.Data; set => ScreenSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ScreenSpace_Element = new();
public UnityEngine.ColorX LineColor { get => LineColor_Element.Data; set => LineColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> LineColor_Element = new();
public UnityEngine.ColorX FillColor { get => FillColor_Element.Data; set => FillColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> FillColor_Element = new();
public UnityEngine.ColorX InnerLineColor { get => InnerLineColor_Element.Data; set => InnerLineColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> InnerLineColor_Element = new();
public UnityEngine.ColorX InnerFillColor { get => InnerFillColor_Element.Data; set => InnerFillColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> InnerFillColor_Element = new();
public global::System.Boolean UseFresnel { get => UseFresnel_Element.Data; set => UseFresnel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseFresnel_Element = new();
public UnityEngine.ColorX LineFarColor { get => LineFarColor_Element.Data; set => LineFarColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> LineFarColor_Element = new();
public UnityEngine.ColorX FillFarColor { get => FillFarColor_Element.Data; set => FillFarColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> FillFarColor_Element = new();
public UnityEngine.ColorX InnerLineFarColor { get => InnerLineFarColor_Element.Data; set => InnerLineFarColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> InnerLineFarColor_Element = new();
public UnityEngine.ColorX InnerFillFarColor { get => InnerFillFarColor_Element.Data; set => InnerFillFarColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> InnerFillFarColor_Element = new();
public global::System.Single Exp { get => Exp_Element.Data; set => Exp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Exp_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> Texture_Element = new();
public global::FrooxEngine.ZWrite ZWrite { get => ZWrite_Element.Data; set => ZWrite_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZWrite>, global::FrooxEngine.ZWrite> ZWrite_Element = new();
public global::System.Boolean DoubleSided { get => DoubleSided_Element.Data; set => DoubleSided_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DoubleSided_Element = new();
public global::System.Single OffsetFactor { get => OffsetFactor_Element.Data; set => OffsetFactor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetFactor_Element = new();
public global::System.Single OffsetUnits { get => OffsetUnits_Element.Data; set => OffsetUnits_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetUnits_Element = new();
public global::System.Int32 RenderQueue { get => RenderQueue_Element.Data; set => RenderQueue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RenderQueue_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _regular { get => _regular_Element.Data; set => _regular_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Shader>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader>> _regular_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _regularDoubleSided { get => _regularDoubleSided_Element.Data; set => _regularDoubleSided_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Shader>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader>> _regularDoubleSided_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Thickness", Thickness_Element.Data.ToResoniteLinkField());
members.Add("ScreenSpace", ScreenSpace_Element.Data.ToResoniteLinkField());
members.Add("LineColor", LineColor_Element.Data.ToResoniteLinkField());
members.Add("FillColor", FillColor_Element.Data.ToResoniteLinkField());
members.Add("InnerLineColor", InnerLineColor_Element.Data.ToResoniteLinkField());
members.Add("InnerFillColor", InnerFillColor_Element.Data.ToResoniteLinkField());
members.Add("UseFresnel", UseFresnel_Element.Data.ToResoniteLinkField());
members.Add("LineFarColor", LineFarColor_Element.Data.ToResoniteLinkField());
members.Add("FillFarColor", FillFarColor_Element.Data.ToResoniteLinkField());
members.Add("InnerLineFarColor", InnerLineFarColor_Element.Data.ToResoniteLinkField());
members.Add("InnerFillFarColor", InnerFillFarColor_Element.Data.ToResoniteLinkField());
members.Add("Exp", Exp_Element.Data.ToResoniteLinkField());
members.Add("Texture", Texture_Element.Data.ToResoniteReference(context));
members.Add("ZWrite", ZWrite_Element.Data.ToResoniteLinkField());
members.Add("DoubleSided", DoubleSided_Element.Data.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor_Element.Data.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits_Element.Data.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue_Element.Data.ToResoniteLinkField());
members.Add("_regular", _regular_Element.Data.ToResoniteReference(context));
members.Add("_regularDoubleSided", _regularDoubleSided_Element.Data.ToResoniteReference(context));
}

}
}
