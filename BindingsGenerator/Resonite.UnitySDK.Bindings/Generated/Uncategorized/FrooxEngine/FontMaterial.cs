
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FontMaterial
// Generated on: čtvrtek 26. února 2026 10:03:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FontMaterial")]
public partial class FontMaterial : global::FrooxEngine.Component

{
    public global::System.Single OutlineThickness { get => OutlineThickness_Element.Data; set => OutlineThickness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OutlineThickness_Element = new();
public UnityEngine.ColorX OutlineColor { get => OutlineColor_Element.Data; set => OutlineColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> OutlineColor_Element = new();
public global::System.Single FaceSoftness { get => FaceSoftness_Element.Data; set => FaceSoftness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FaceSoftness_Element = new();
public global::System.Single FaceDilate { get => FaceDilate_Element.Data; set => FaceDilate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FaceDilate_Element = new();
public global::FrooxEngine.Culling Culling { get => Culling_Element.Data; set => Culling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Culling>, global::FrooxEngine.Culling> Culling_Element = new();
public global::FrooxEngine.ZTest ZTest { get => ZTest_Element.Data; set => ZTest_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZTest>, global::FrooxEngine.ZTest> ZTest_Element = new();
public global::System.Int32 RenderQueue { get => RenderQueue_Element.Data; set => RenderQueue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RenderQueue_Element = new();
public global::FrooxEngine.TextUnlitMaterial _convertedMaterial { get => _convertedMaterial_Element.Data; set => _convertedMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TextUnlitMaterial>, global::FrooxEngine.TextUnlitMaterial> _convertedMaterial_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OutlineThickness", OutlineThickness_Element.Data.ToResoniteLinkField());
members.Add("OutlineColor", OutlineColor_Element.Data.ToResoniteLinkField());
members.Add("FaceSoftness", FaceSoftness_Element.Data.ToResoniteLinkField());
members.Add("FaceDilate", FaceDilate_Element.Data.ToResoniteLinkField());
members.Add("Culling", Culling_Element.Data.ToResoniteLinkField());
members.Add("ZTest", ZTest_Element.Data.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue_Element.Data.ToResoniteLinkField());
members.Add("_convertedMaterial", _convertedMaterial_Element.Data.ToResoniteReference(context));
}

}
}
