
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyAudioPlayer
// Generated on: středa 25. února 2026 16:14:40
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AudioClip", AudioClip.ToResoniteReference(context));
members.Add("_clipPlayer", _clipPlayer.ToResoniteReference(context));
members.Add("_audioOutput", _audioOutput.ToResoniteReference(context));
members.Add("_waveformMaterial", _waveformMaterial.ToResoniteReference(context));
members.Add("_playbackMaterial", _playbackMaterial.ToResoniteReference(context));
members.Add("_waveformRingMesh", _waveformRingMesh.ToResoniteReference(context));
members.Add("_playbackRingMesh", _playbackRingMesh.ToResoniteReference(context));
members.Add("_playbackRingArc", _playbackRingArc.ToResoniteReference(context));
members.Add("_volumeRingArc", _volumeRingArc.ToResoniteReference(context));
members.Add("_playbackTimeText", _playbackTimeText.ToResoniteReference(context));
members.Add("_clipLengthTimeText", _clipLengthTimeText.ToResoniteReference(context));
members.Add("_iconTextureURL", _iconTextureURL.ToResoniteReference(context));
members.Add("_stopItem", _stopItem.ToResoniteReference(context));
members.Add("_loopItem", _loopItem.ToResoniteReference(context));
members.Add("_spatialItem", _spatialItem.ToResoniteReference(context));
members.Add("_loopIconURL", _loopIconURL.ToResoniteReference(context));
members.Add("_spatialIconURL", _spatialIconURL.ToResoniteReference(context));
members.Add("_exportable", _exportable.ToResoniteReference(context));
members.Add("_assetProxy", _assetProxy.ToResoniteReference(context));
}

}
}
