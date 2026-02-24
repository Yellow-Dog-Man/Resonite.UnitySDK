
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FootstepSoundDefinition+FootstepClip
// Generated on: úterý 24. února 2026 18:17:50
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class FootstepSoundDefinition
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FootstepSoundDefinition+FootstepClip")]
public partial class FootstepClip : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> Clip;
public global::System.Single Weight;
public global::System.Single MinVelocity;
public global::System.Single MaxVelocity;
public global::System.Boolean PlayForWalking;
public global::System.Boolean PlayForLanding;
public global::System.Boolean PlayForLeftFoot;
public global::System.Boolean PlayForRightFoot;
public global::System.Single VelocityMinPitch;
public global::System.Single VelocityMaxPitch;
public global::System.Single PitchMinVelocityReference;
public global::System.Single PitchMaxVelocityReference;
public global::System.Single MinPitchVariation;
public global::System.Single MaxPitchVariation;
public global::System.Single VelocityMinVolume;
public global::System.Single VelocityMaxVolume;
public global::System.Single VolumeMinVelocityReference;
public global::System.Single VolumeMaxVelocityReference;
public global::System.Single MinVolumeVariation;
public global::System.Single MaxVolumeVariation;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Clip", Clip.ToResoniteReference(context));
members.Add("Weight", Weight.ToResoniteLinkField());
members.Add("MinVelocity", MinVelocity.ToResoniteLinkField());
members.Add("MaxVelocity", MaxVelocity.ToResoniteLinkField());
members.Add("PlayForWalking", PlayForWalking.ToResoniteLinkField());
members.Add("PlayForLanding", PlayForLanding.ToResoniteLinkField());
members.Add("PlayForLeftFoot", PlayForLeftFoot.ToResoniteLinkField());
members.Add("PlayForRightFoot", PlayForRightFoot.ToResoniteLinkField());
members.Add("VelocityMinPitch", VelocityMinPitch.ToResoniteLinkField());
members.Add("VelocityMaxPitch", VelocityMaxPitch.ToResoniteLinkField());
members.Add("PitchMinVelocityReference", PitchMinVelocityReference.ToResoniteLinkField());
members.Add("PitchMaxVelocityReference", PitchMaxVelocityReference.ToResoniteLinkField());
members.Add("MinPitchVariation", MinPitchVariation.ToResoniteLinkField());
members.Add("MaxPitchVariation", MaxPitchVariation.ToResoniteLinkField());
members.Add("VelocityMinVolume", VelocityMinVolume.ToResoniteLinkField());
members.Add("VelocityMaxVolume", VelocityMaxVolume.ToResoniteLinkField());
members.Add("VolumeMinVelocityReference", VolumeMinVelocityReference.ToResoniteLinkField());
members.Add("VolumeMaxVelocityReference", VolumeMaxVelocityReference.ToResoniteLinkField());
members.Add("MinVolumeVariation", MinVolumeVariation.ToResoniteLinkField());
members.Add("MaxVolumeVariation", MaxVolumeVariation.ToResoniteLinkField());
}

}
            }
}
