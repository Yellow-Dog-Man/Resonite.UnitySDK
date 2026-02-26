
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GradientStripTexture
// Generated on: čtvrtek 26. února 2026 10:03:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GradientStripTexture")]
public partial class GradientStripTexture : global::FrooxEngine.ProceduralTexture

{
    public global::SyncArray<global::FrooxEngine.SyncLinear<UnityEngine.ColorX>, global::FrooxEngine.LinearKey<UnityEngine.ColorX>> Gradient = new();
public global::System.Single Exp { get => Exp_Element.Data; set => Exp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Exp_Element = new();
public global::FrooxEngine.GradientStripTexture.StripOrientation _orientation { get => _orientation_Element.Data; set => _orientation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.GradientStripTexture.StripOrientation>, global::FrooxEngine.GradientStripTexture.StripOrientation> _orientation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Gradient", Gradient.Data.ToResoniteLinkArray());
members.Add("Exp", Exp_Element.Data.ToResoniteLinkField());
members.Add("_orientation", _orientation_Element.Data.ToResoniteLinkField());
}

}
}
