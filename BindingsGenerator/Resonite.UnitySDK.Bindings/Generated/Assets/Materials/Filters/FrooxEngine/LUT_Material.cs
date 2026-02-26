
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LUT_Material
// Generated on: čtvrtek 26. února 2026 10:03:34
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LUT_Material")]
public partial class LUT_Material : global::FrooxEngine.SingleShaderUI_StencilMaterial

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture3D> LUT { get => LUT_Element.Data; set => LUT_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture3D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture3D>> LUT_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture3D> SecondaryLUT { get => SecondaryLUT_Element.Data; set => SecondaryLUT_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture3D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture3D>> SecondaryLUT_Element = new();
public global::System.Boolean UseSRGB { get => UseSRGB_Element.Data; set => UseSRGB_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseSRGB_Element = new();
public global::System.Single Lerp { get => Lerp_Element.Data; set => Lerp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Lerp_Element = new();
public global::FrooxEngine.BlendMode BlendMode { get => BlendMode_Element.Data; set => BlendMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BlendMode>, global::FrooxEngine.BlendMode> BlendMode_Element = new();
public global::FrooxEngine.Sidedness Sidedness { get => Sidedness_Element.Data; set => Sidedness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Sidedness>, global::FrooxEngine.Sidedness> Sidedness_Element = new();
public global::FrooxEngine.ZWrite ZWrite { get => ZWrite_Element.Data; set => ZWrite_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZWrite>, global::FrooxEngine.ZWrite> ZWrite_Element = new();
public global::FrooxEngine.ZTest ZTest { get => ZTest_Element.Data; set => ZTest_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZTest>, global::FrooxEngine.ZTest> ZTest_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LUT", LUT_Element.Data.ToResoniteReference(context));
members.Add("SecondaryLUT", SecondaryLUT_Element.Data.ToResoniteReference(context));
members.Add("UseSRGB", UseSRGB_Element.Data.ToResoniteLinkField());
members.Add("Lerp", Lerp_Element.Data.ToResoniteLinkField());
members.Add("BlendMode", BlendMode_Element.Data.ToResoniteLinkField());
members.Add("Sidedness", Sidedness_Element.Data.ToResoniteLinkField());
members.Add("ZWrite", ZWrite_Element.Data.ToResoniteLinkField());
members.Add("ZTest", ZTest_Element.Data.ToResoniteLinkField());
}

}
}
