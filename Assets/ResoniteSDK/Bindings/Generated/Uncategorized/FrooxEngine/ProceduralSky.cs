
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProceduralSky
// Generated on: čtvrtek 19. února 2026 8:00:30
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProceduralSky")]
public partial class ProceduralSky : global::FrooxEngine.Component

{
    public global::FrooxEngine.ProceduralSky.SunType SunQuality;
public global::System.Single SunSize;
public global::FrooxEngine.Light Sun;
public global::System.Single AtmosphereThickness;
public UnityEngine.ColorX SkyTint;
public UnityEngine.ColorX GroundColor;
public global::System.Single Exposure;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SunQuality", SunQuality.ToResoniteLinkField());
members.Add("SunSize", SunSize.ToResoniteLinkField());
members.Add("Sun", Sun.ToResoniteReference(context));
members.Add("AtmosphereThickness", AtmosphereThickness.ToResoniteLinkField());
members.Add("SkyTint", SkyTint.ToResoniteLinkField());
members.Add("GroundColor", GroundColor.ToResoniteLinkField());
members.Add("Exposure", Exposure.ToResoniteLinkField());
}

}
}
