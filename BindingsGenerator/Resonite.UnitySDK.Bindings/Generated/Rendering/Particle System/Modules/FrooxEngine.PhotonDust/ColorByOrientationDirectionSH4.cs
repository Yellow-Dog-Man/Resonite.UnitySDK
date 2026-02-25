
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorByOrientationDirectionSH4
// Generated on: středa 25. února 2026 16:14:18
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ColorByOrientationDirectionSH4")]
public partial class ColorByOrientationDirectionSH4 : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::Elements.Core.SphericalHarmonicsL4<UnityEngine.ColorX> SH;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SH", SH.ToResoniteLinkField());
}

}
}
