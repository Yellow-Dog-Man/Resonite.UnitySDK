
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GradientStripTexture
// Generated on: pátek 13. února 2026 23:21:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GradientStripTexture")]
public partial class GradientStripTexture : global::FrooxEngine.ProceduralTexture

{
    public global::FrooxEngine.LinearKey<UnityEngine.ColorX>[] Gradient;
public global::System.Single Exp;
public global::FrooxEngine.GradientStripTexture.StripOrientation _orientation;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Gradient", Gradient.ToResoniteLinkArray());
members.Add("Exp", Exp.ToResoniteLinkField());
members.Add("_orientation", _orientation.ToResoniteLinkField());
}

}
}
