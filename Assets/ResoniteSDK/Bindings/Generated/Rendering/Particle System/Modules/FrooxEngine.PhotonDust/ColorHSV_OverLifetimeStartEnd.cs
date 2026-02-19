
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorHSV_OverLifetimeStartEnd
// Generated on: čtvrtek 19. února 2026 8:00:20
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ColorHSV_OverLifetimeStartEnd")]
public partial class ColorHSV_OverLifetimeStartEnd : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::System.Single StartHue;
public global::System.Single StartSaturation;
public global::System.Single StartValue;
public global::System.Single EndHue;
public global::System.Single EndSaturation;
public global::System.Single EndValue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("StartHue", StartHue.ToResoniteLinkField());
members.Add("StartSaturation", StartSaturation.ToResoniteLinkField());
members.Add("StartValue", StartValue.ToResoniteLinkField());
members.Add("EndHue", EndHue.ToResoniteLinkField());
members.Add("EndSaturation", EndSaturation.ToResoniteLinkField());
members.Add("EndValue", EndValue.ToResoniteLinkField());
}

}
}
