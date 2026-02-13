
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProceduralSky
// Generated on: pátek 13. února 2026 5:52:35
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SunQuality", SunQuality.ToResoniteLinkField());
members.Add("SunSize", SunSize.ToResoniteLinkField());
members.Add("Sun", new ResoniteLink.Reference() { });
members.Add("AtmosphereThickness", AtmosphereThickness.ToResoniteLinkField());
members.Add("SkyTint", SkyTint.ToResoniteLinkField());
members.Add("GroundColor", GroundColor.ToResoniteLinkField());
members.Add("Exposure", Exposure.ToResoniteLinkField());
}

}
}
