
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioPlayerInterface
// Generated on: sobota 14. února 2026 8:58:51
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioPlayerInterface")]
public partial class AudioPlayerInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.IField<System.Uri> URL;
public global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip> Clip;
public global::FrooxEngine.IField<global::FrooxEngine.AudioTypeGroup> Group;
public global::FrooxEngine.IField<global::System.Single> Volume;
public global::FrooxEngine.IField<global::System.Boolean> Spatialize;
public global::FrooxEngine.IField<global::System.Single> Doppler;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> DefaultAudioClip;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL.ToResoniteReference(context));
members.Add("Clip", Clip.ToResoniteReference(context));
members.Add("Group", Group.ToResoniteReference(context));
members.Add("Volume", Volume.ToResoniteReference(context));
members.Add("Spatialize", Spatialize.ToResoniteReference(context));
members.Add("Doppler", Doppler.ToResoniteReference(context));
members.Add("DefaultAudioClip", DefaultAudioClip.ToResoniteReference(context));
}

}
}
