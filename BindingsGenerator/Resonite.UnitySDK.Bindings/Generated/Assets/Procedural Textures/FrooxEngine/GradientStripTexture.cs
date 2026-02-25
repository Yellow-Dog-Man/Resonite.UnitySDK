
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GradientStripTexture
// Generated on: středa 25. února 2026 16:13:05
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
    public global::FrooxEngine.LinearKey<UnityEngine.ColorX>[] Gradient;
public global::System.Single Exp;
public global::FrooxEngine.GradientStripTexture.StripOrientation _orientation;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Gradient", Gradient.ToResoniteLinkArray());
members.Add("Exp", Exp.ToResoniteLinkField());
members.Add("_orientation", _orientation.ToResoniteLinkField());
}

}
}
