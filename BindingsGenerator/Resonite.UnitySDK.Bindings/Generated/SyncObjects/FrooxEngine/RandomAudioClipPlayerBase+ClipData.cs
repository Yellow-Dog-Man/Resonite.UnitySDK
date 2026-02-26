
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RandomAudioClipPlayerBase+ClipData
// Generated on: čtvrtek 26. února 2026 10:03:38
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> Clip { get => Clip_Element.Data; set => Clip_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> Clip_Element = new();
public global::System.Single Weight { get => Weight_Element.Data; set => Weight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Weight_Element = new();
public global::System.Single MinVolume { get => MinVolume_Element.Data; set => MinVolume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinVolume_Element = new();
public global::System.Single MaxVolume { get => MaxVolume_Element.Data; set => MaxVolume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxVolume_Element = new();
public global::System.Single MinSpeed { get => MinSpeed_Element.Data; set => MinSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinSpeed_Element = new();
public global::System.Single MaxSpeed { get => MaxSpeed_Element.Data; set => MaxSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxSpeed_Element = new();
public global::System.Boolean Spatialize { get => Spatialize_Element.Data; set => Spatialize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Spatialize_Element = new();
public global::System.Single SpatialBlend { get => SpatialBlend_Element.Data; set => SpatialBlend_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SpatialBlend_Element = new();
public global::System.Nullable<global::System.Boolean> IgnoreAudioEffects { get => IgnoreAudioEffects_Element.Data; set => IgnoreAudioEffects_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Boolean>>, global::System.Nullable<global::System.Boolean>> IgnoreAudioEffects_Element = new();
public global::System.Nullable<global::System.Boolean> Global { get => Global_Element.Data; set => Global_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Boolean>>, global::System.Nullable<global::System.Boolean>> Global_Element = new();
public global::System.Nullable<global::System.Single> MinDistance { get => MinDistance_Element.Data; set => MinDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> MinDistance_Element = new();
public global::System.Nullable<global::System.Single> MaxDistance { get => MaxDistance_Element.Data; set => MaxDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> MaxDistance_Element = new();
public global::System.Nullable<global::Awwdio.AudioRolloffCurve> RolloffMode { get => RolloffMode_Element.Data; set => RolloffMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::Awwdio.AudioRolloffCurve>>, global::System.Nullable<global::Awwdio.AudioRolloffCurve>> RolloffMode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Clip", Clip_Element.Data.ToResoniteReference(context));
members.Add("Weight", Weight_Element.Data.ToResoniteLinkField());
members.Add("MinVolume", MinVolume_Element.Data.ToResoniteLinkField());
members.Add("MaxVolume", MaxVolume_Element.Data.ToResoniteLinkField());
members.Add("MinSpeed", MinSpeed_Element.Data.ToResoniteLinkField());
members.Add("MaxSpeed", MaxSpeed_Element.Data.ToResoniteLinkField());
members.Add("Spatialize", Spatialize_Element.Data.ToResoniteLinkField());
members.Add("SpatialBlend", SpatialBlend_Element.Data.ToResoniteLinkField());
members.Add("IgnoreAudioEffects", IgnoreAudioEffects_Element.Data.ToResoniteLinkField());
members.Add("Global", Global_Element.Data.ToResoniteLinkField());
members.Add("MinDistance", MinDistance_Element.Data.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance_Element.Data.ToResoniteLinkField());
members.Add("RolloffMode", RolloffMode_Element.Data.ToResoniteLinkField());
}

}
            }
}
