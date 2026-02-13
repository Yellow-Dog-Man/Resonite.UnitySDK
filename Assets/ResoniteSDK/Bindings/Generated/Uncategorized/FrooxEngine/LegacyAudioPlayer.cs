
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyAudioPlayer
// Generated on: pátek 13. února 2026 23:23:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyAudioPlayer")]
public partial class LegacyAudioPlayer : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> AudioClip;
public global::FrooxEngine.AudioClipPlayer _clipPlayer;
public global::FrooxEngine.AudioOutput _audioOutput;
public global::FrooxEngine.UnlitMaterial _waveformMaterial;
public global::FrooxEngine.UnlitMaterial _playbackMaterial;
public global::FrooxEngine.RingMesh _waveformRingMesh;
public global::FrooxEngine.RingMesh _playbackRingMesh;
public global::FrooxEngine.IField<global::System.Single> _playbackRingArc;
public global::FrooxEngine.IField<global::System.Single> _volumeRingArc;
public global::FrooxEngine.IField<global::System.String> _playbackTimeText;
public global::FrooxEngine.IField<global::System.String> _clipLengthTimeText;
public global::FrooxEngine.IField<System.Uri> _iconTextureURL;
public global::FrooxEngine.LegacySegmentCircleMenuController.Item _stopItem;
public global::FrooxEngine.LegacySegmentCircleMenuController.Item _loopItem;
public global::FrooxEngine.LegacySegmentCircleMenuController.Item _spatialItem;
public global::FrooxEngine.IField<System.Uri> _loopIconURL;
public global::FrooxEngine.IField<System.Uri> _spatialIconURL;
public global::FrooxEngine.AudioExportable _exportable;
public global::FrooxEngine.AssetProxy<global::FrooxEngine.AudioClip> _assetProxy;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("AudioClip", new ResoniteLink.Reference() { });
members.Add("_clipPlayer", new ResoniteLink.Reference() { });
members.Add("_audioOutput", new ResoniteLink.Reference() { });
members.Add("_waveformMaterial", new ResoniteLink.Reference() { });
members.Add("_playbackMaterial", new ResoniteLink.Reference() { });
members.Add("_waveformRingMesh", new ResoniteLink.Reference() { });
members.Add("_playbackRingMesh", new ResoniteLink.Reference() { });
members.Add("_playbackRingArc", new ResoniteLink.Reference() { });
members.Add("_volumeRingArc", new ResoniteLink.Reference() { });
members.Add("_playbackTimeText", new ResoniteLink.Reference() { });
members.Add("_clipLengthTimeText", new ResoniteLink.Reference() { });
members.Add("_iconTextureURL", new ResoniteLink.Reference() { });
members.Add("_stopItem", new ResoniteLink.Reference() { });
members.Add("_loopItem", new ResoniteLink.Reference() { });
members.Add("_spatialItem", new ResoniteLink.Reference() { });
members.Add("_loopIconURL", new ResoniteLink.Reference() { });
members.Add("_spatialIconURL", new ResoniteLink.Reference() { });
members.Add("_exportable", new ResoniteLink.Reference() { });
members.Add("_assetProxy", new ResoniteLink.Reference() { });
}

}
}
