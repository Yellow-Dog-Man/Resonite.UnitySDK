
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RandomAudioClipPlayerBase+ClipData
// Generated on: středa 25. února 2026 16:13:07
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class RandomAudioClipPlayerBase
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RandomAudioClipPlayerBase+ClipData")]
public partial class ClipData : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> Clip;
public global::System.Single Weight;
public global::System.Single MinVolume;
public global::System.Single MaxVolume;
public global::System.Single MinSpeed;
public global::System.Single MaxSpeed;
public global::System.Boolean Spatialize;
public global::System.Single SpatialBlend;
public global::System.Nullable<global::System.Boolean> IgnoreAudioEffects;
public global::System.Nullable<global::System.Boolean> Global;
public global::System.Nullable<global::System.Single> MinDistance;
public global::System.Nullable<global::System.Single> MaxDistance;
public global::System.Nullable<global::Awwdio.AudioRolloffCurve> RolloffMode;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Clip", Clip.ToResoniteReference(context));
members.Add("Weight", Weight.ToResoniteLinkField());
members.Add("MinVolume", MinVolume.ToResoniteLinkField());
members.Add("MaxVolume", MaxVolume.ToResoniteLinkField());
members.Add("MinSpeed", MinSpeed.ToResoniteLinkField());
members.Add("MaxSpeed", MaxSpeed.ToResoniteLinkField());
members.Add("Spatialize", Spatialize.ToResoniteLinkField());
members.Add("SpatialBlend", SpatialBlend.ToResoniteLinkField());
members.Add("IgnoreAudioEffects", IgnoreAudioEffects.ToResoniteLinkField());
members.Add("Global", Global.ToResoniteLinkField());
members.Add("MinDistance", MinDistance.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance.ToResoniteLinkField());
members.Add("RolloffMode", RolloffMode.ToResoniteLinkField());
}

}
            }
}
