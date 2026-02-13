
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioPlayerInterface
// Generated on: pátek 13. února 2026 23:23:21
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("URL", new ResoniteLink.Reference() { });
members.Add("Clip", new ResoniteLink.Reference() { });
members.Add("Group", new ResoniteLink.Reference() { });
members.Add("Volume", new ResoniteLink.Reference() { });
members.Add("Spatialize", new ResoniteLink.Reference() { });
members.Add("Doppler", new ResoniteLink.Reference() { });
members.Add("DefaultAudioClip", new ResoniteLink.Reference() { });
}

}
}
