
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VoiceModeConfig
// Generated on: čtvrtek 26. února 2026 15:09:16
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.Single Volume { get => Volume_Element.Data; set => Volume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Volume_Element = new();
public global::System.Single MinDistance { get => MinDistance_Element.Data; set => MinDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinDistance_Element = new();
public global::System.Single MaxDistance { get => MaxDistance_Element.Data; set => MaxDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxDistance_Element = new();
public global::Awwdio.AudioRolloffCurve RollOffMode { get => RollOffMode_Element.Data; set => RollOffMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Awwdio.AudioRolloffCurve>, global::Awwdio.AudioRolloffCurve> RollOffMode_Element = new();
public global::FrooxEngine.AudioDistanceSpace DistanceSpace { get => DistanceSpace_Element.Data; set => DistanceSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.AudioDistanceSpace>, global::FrooxEngine.AudioDistanceSpace> DistanceSpace_Element = new();
public global::System.Single MinScale { get => MinScale_Element.Data; set => MinScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinScale_Element = new();
public global::System.Single MaxScale { get => MaxScale_Element.Data; set => MaxScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxScale_Element = new();
public global::System.Boolean Spatialize { get => Spatialize_Element.Data; set => Spatialize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Spatialize_Element = new();
public global::System.Single SpatialBlend { get => SpatialBlend_Element.Data; set => SpatialBlend_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SpatialBlend_Element = new();
public global::System.Single Doppler { get => Doppler_Element.Data; set => Doppler_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Doppler_Element = new();
public global::System.Boolean IgnoreAudioEffects { get => IgnoreAudioEffects_Element.Data; set => IgnoreAudioEffects_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IgnoreAudioEffects_Element = new();
public global::System.Boolean AllowLocallyIgnoringAudioEffects { get => AllowLocallyIgnoringAudioEffects_Element.Data; set => AllowLocallyIgnoringAudioEffects_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowLocallyIgnoringAudioEffects_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Volume", Volume_Element.ToLinkField(context));
members.Add("MinDistance", MinDistance_Element.ToLinkField(context));
members.Add("MaxDistance", MaxDistance_Element.ToLinkField(context));
members.Add("RollOffMode", RollOffMode_Element.ToLinkField(context));
members.Add("DistanceSpace", DistanceSpace_Element.ToLinkField(context));
members.Add("MinScale", MinScale_Element.ToLinkField(context));
members.Add("MaxScale", MaxScale_Element.ToLinkField(context));
members.Add("Spatialize", Spatialize_Element.ToLinkField(context));
members.Add("SpatialBlend", SpatialBlend_Element.ToLinkField(context));
members.Add("Doppler", Doppler_Element.ToLinkField(context));
members.Add("IgnoreAudioEffects", IgnoreAudioEffects_Element.ToLinkField(context));
members.Add("AllowLocallyIgnoringAudioEffects", AllowLocallyIgnoringAudioEffects_Element.ToLinkField(context));
}

}
}
