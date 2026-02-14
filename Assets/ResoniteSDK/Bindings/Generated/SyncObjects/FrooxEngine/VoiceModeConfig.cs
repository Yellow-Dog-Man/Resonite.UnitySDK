
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VoiceModeConfig
// Generated on: sobota 14. února 2026 8:58:50
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VoiceModeConfig")]
public partial class VoiceModeConfig : global::FrooxEngine.SyncObject

{
    public global::System.Single Volume;
public global::System.Single MinDistance;
public global::System.Single MaxDistance;
public global::Awwdio.AudioRolloffCurve RollOffMode;
public global::FrooxEngine.AudioDistanceSpace DistanceSpace;
public global::System.Single MinScale;
public global::System.Single MaxScale;
public global::System.Boolean Spatialize;
public global::System.Single SpatialBlend;
public global::System.Single Doppler;
public global::System.Boolean IgnoreAudioEffects;
public global::System.Boolean AllowLocallyIgnoringAudioEffects;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Volume", Volume.ToResoniteLinkField());
members.Add("MinDistance", MinDistance.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance.ToResoniteLinkField());
members.Add("RollOffMode", RollOffMode.ToResoniteLinkField());
members.Add("DistanceSpace", DistanceSpace.ToResoniteLinkField());
members.Add("MinScale", MinScale.ToResoniteLinkField());
members.Add("MaxScale", MaxScale.ToResoniteLinkField());
members.Add("Spatialize", Spatialize.ToResoniteLinkField());
members.Add("SpatialBlend", SpatialBlend.ToResoniteLinkField());
members.Add("Doppler", Doppler.ToResoniteLinkField());
members.Add("IgnoreAudioEffects", IgnoreAudioEffects.ToResoniteLinkField());
members.Add("AllowLocallyIgnoringAudioEffects", AllowLocallyIgnoringAudioEffects.ToResoniteLinkField());
}

}
}
