
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FootstepSoundDefinition+FootstepClip
// Generated on: čtvrtek 26. února 2026 15:08:00
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
    public partial class FootstepSoundDefinition
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FootstepSoundDefinition+FootstepClip")]
public partial class FootstepClip : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> Clip { get => Clip_Element.Data; set => Clip_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> Clip_Element = new();
public global::System.Single Weight { get => Weight_Element.Data; set => Weight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Weight_Element = new();
public global::System.Single MinVelocity { get => MinVelocity_Element.Data; set => MinVelocity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinVelocity_Element = new();
public global::System.Single MaxVelocity { get => MaxVelocity_Element.Data; set => MaxVelocity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxVelocity_Element = new();
public global::System.Boolean PlayForWalking { get => PlayForWalking_Element.Data; set => PlayForWalking_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PlayForWalking_Element = new();
public global::System.Boolean PlayForLanding { get => PlayForLanding_Element.Data; set => PlayForLanding_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PlayForLanding_Element = new();
public global::System.Boolean PlayForLeftFoot { get => PlayForLeftFoot_Element.Data; set => PlayForLeftFoot_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PlayForLeftFoot_Element = new();
public global::System.Boolean PlayForRightFoot { get => PlayForRightFoot_Element.Data; set => PlayForRightFoot_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PlayForRightFoot_Element = new();
public global::System.Single VelocityMinPitch { get => VelocityMinPitch_Element.Data; set => VelocityMinPitch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VelocityMinPitch_Element = new();
public global::System.Single VelocityMaxPitch { get => VelocityMaxPitch_Element.Data; set => VelocityMaxPitch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VelocityMaxPitch_Element = new();
public global::System.Single PitchMinVelocityReference { get => PitchMinVelocityReference_Element.Data; set => PitchMinVelocityReference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PitchMinVelocityReference_Element = new();
public global::System.Single PitchMaxVelocityReference { get => PitchMaxVelocityReference_Element.Data; set => PitchMaxVelocityReference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PitchMaxVelocityReference_Element = new();
public global::System.Single MinPitchVariation { get => MinPitchVariation_Element.Data; set => MinPitchVariation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinPitchVariation_Element = new();
public global::System.Single MaxPitchVariation { get => MaxPitchVariation_Element.Data; set => MaxPitchVariation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxPitchVariation_Element = new();
public global::System.Single VelocityMinVolume { get => VelocityMinVolume_Element.Data; set => VelocityMinVolume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VelocityMinVolume_Element = new();
public global::System.Single VelocityMaxVolume { get => VelocityMaxVolume_Element.Data; set => VelocityMaxVolume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VelocityMaxVolume_Element = new();
public global::System.Single VolumeMinVelocityReference { get => VolumeMinVelocityReference_Element.Data; set => VolumeMinVelocityReference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VolumeMinVelocityReference_Element = new();
public global::System.Single VolumeMaxVelocityReference { get => VolumeMaxVelocityReference_Element.Data; set => VolumeMaxVelocityReference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VolumeMaxVelocityReference_Element = new();
public global::System.Single MinVolumeVariation { get => MinVolumeVariation_Element.Data; set => MinVolumeVariation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinVolumeVariation_Element = new();
public global::System.Single MaxVolumeVariation { get => MaxVolumeVariation_Element.Data; set => MaxVolumeVariation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxVolumeVariation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Clip", Clip_Element.ToLinkReference(context));
members.Add("Weight", Weight_Element.ToLinkField(context));
members.Add("MinVelocity", MinVelocity_Element.ToLinkField(context));
members.Add("MaxVelocity", MaxVelocity_Element.ToLinkField(context));
members.Add("PlayForWalking", PlayForWalking_Element.ToLinkField(context));
members.Add("PlayForLanding", PlayForLanding_Element.ToLinkField(context));
members.Add("PlayForLeftFoot", PlayForLeftFoot_Element.ToLinkField(context));
members.Add("PlayForRightFoot", PlayForRightFoot_Element.ToLinkField(context));
members.Add("VelocityMinPitch", VelocityMinPitch_Element.ToLinkField(context));
members.Add("VelocityMaxPitch", VelocityMaxPitch_Element.ToLinkField(context));
members.Add("PitchMinVelocityReference", PitchMinVelocityReference_Element.ToLinkField(context));
members.Add("PitchMaxVelocityReference", PitchMaxVelocityReference_Element.ToLinkField(context));
members.Add("MinPitchVariation", MinPitchVariation_Element.ToLinkField(context));
members.Add("MaxPitchVariation", MaxPitchVariation_Element.ToLinkField(context));
members.Add("VelocityMinVolume", VelocityMinVolume_Element.ToLinkField(context));
members.Add("VelocityMaxVolume", VelocityMaxVolume_Element.ToLinkField(context));
members.Add("VolumeMinVelocityReference", VolumeMinVelocityReference_Element.ToLinkField(context));
members.Add("VolumeMaxVelocityReference", VolumeMaxVelocityReference_Element.ToLinkField(context));
members.Add("MinVolumeVariation", MinVolumeVariation_Element.ToLinkField(context));
members.Add("MaxVolumeVariation", MaxVolumeVariation_Element.ToLinkField(context));
}

}
            }
}
