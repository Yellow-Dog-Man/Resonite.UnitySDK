
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorHSV_OverLifetimeStartEnd
// Generated on: pátek 13. února 2026 5:52:22
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("StartHue", StartHue.ToResoniteLinkField());
members.Add("StartSaturation", StartSaturation.ToResoniteLinkField());
members.Add("StartValue", StartValue.ToResoniteLinkField());
members.Add("EndHue", EndHue.ToResoniteLinkField());
members.Add("EndSaturation", EndSaturation.ToResoniteLinkField());
members.Add("EndValue", EndValue.ToResoniteLinkField());
}

}
}
