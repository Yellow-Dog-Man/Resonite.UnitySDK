
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FontMaterial
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FontMaterial")]
public partial class FontMaterial : global::FrooxEngine.Component

{
    public global::System.Single OutlineThickness;
public UnityEngine.ColorX OutlineColor;
public global::System.Single FaceSoftness;
public global::System.Single FaceDilate;
public global::FrooxEngine.Culling Culling;
public global::FrooxEngine.ZTest ZTest;
public global::System.Int32 RenderQueue;
public global::FrooxEngine.TextUnlitMaterial _convertedMaterial;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("OutlineThickness", OutlineThickness.ToResoniteLinkField());
members.Add("OutlineColor", OutlineColor.ToResoniteLinkField());
members.Add("FaceSoftness", FaceSoftness.ToResoniteLinkField());
members.Add("FaceDilate", FaceDilate.ToResoniteLinkField());
members.Add("Culling", Culling.ToResoniteLinkField());
members.Add("ZTest", ZTest.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
members.Add("_convertedMaterial", new ResoniteLink.Reference() { });
}

}
}
