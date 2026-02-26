
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorByOrientationDirectionSH3
// Generated on: čtvrtek 26. února 2026 15:09:04
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ColorByOrientationDirectionSH3")]
public partial class ColorByOrientationDirectionSH3 : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::Elements.Core.SphericalHarmonicsL3<UnityEngine.ColorX> SH { get => SH_Element.Data; set => SH_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Core.SphericalHarmonicsL3<UnityEngine.ColorX>>, global::Elements.Core.SphericalHarmonicsL3<UnityEngine.ColorX>> SH_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SH", SH_Element.ToLinkField(context));
}

}
}
