
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyAudioPlayer
// Generated on: čtvrtek 26. února 2026 10:04:46
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> AudioClip { get => AudioClip_Element.Data; set => AudioClip_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> AudioClip_Element = new();
public global::FrooxEngine.AudioClipPlayer _clipPlayer { get => _clipPlayer_Element.Data; set => _clipPlayer_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioClipPlayer>, global::FrooxEngine.AudioClipPlayer> _clipPlayer_Element = new();
public global::FrooxEngine.AudioOutput _audioOutput { get => _audioOutput_Element.Data; set => _audioOutput_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioOutput>, global::FrooxEngine.AudioOutput> _audioOutput_Element = new();
public global::FrooxEngine.UnlitMaterial _waveformMaterial { get => _waveformMaterial_Element.Data; set => _waveformMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UnlitMaterial>, global::FrooxEngine.UnlitMaterial> _waveformMaterial_Element = new();
public global::FrooxEngine.UnlitMaterial _playbackMaterial { get => _playbackMaterial_Element.Data; set => _playbackMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UnlitMaterial>, global::FrooxEngine.UnlitMaterial> _playbackMaterial_Element = new();
public global::FrooxEngine.RingMesh _waveformRingMesh { get => _waveformRingMesh_Element.Data; set => _waveformRingMesh_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.RingMesh>, global::FrooxEngine.RingMesh> _waveformRingMesh_Element = new();
public global::FrooxEngine.RingMesh _playbackRingMesh { get => _playbackRingMesh_Element.Data; set => _playbackRingMesh_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.RingMesh>, global::FrooxEngine.RingMesh> _playbackRingMesh_Element = new();
public global::FrooxEngine.IField<global::System.Single> _playbackRingArc { get => _playbackRingArc_Element.Data; set => _playbackRingArc_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _playbackRingArc_Element = new();
public global::FrooxEngine.IField<global::System.Single> _volumeRingArc { get => _volumeRingArc_Element.Data; set => _volumeRingArc_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _volumeRingArc_Element = new();
public global::FrooxEngine.IField<global::System.String> _playbackTimeText { get => _playbackTimeText_Element.Data; set => _playbackTimeText_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> _playbackTimeText_Element = new();
public global::FrooxEngine.IField<global::System.String> _clipLengthTimeText { get => _clipLengthTimeText_Element.Data; set => _clipLengthTimeText_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> _clipLengthTimeText_Element = new();
public global::FrooxEngine.IField<System.Uri> _iconTextureURL { get => _iconTextureURL_Element.Data; set => _iconTextureURL_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<System.Uri>, global::FrooxEngine.IField<System.Uri>> _iconTextureURL_Element = new();
public global::FrooxEngine.LegacySegmentCircleMenuController.Item _stopItem { get => _stopItem_Element.Data; set => _stopItem_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacySegmentCircleMenuController.Item>, global::FrooxEngine.LegacySegmentCircleMenuController.Item> _stopItem_Element = new();
public global::FrooxEngine.LegacySegmentCircleMenuController.Item _loopItem { get => _loopItem_Element.Data; set => _loopItem_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacySegmentCircleMenuController.Item>, global::FrooxEngine.LegacySegmentCircleMenuController.Item> _loopItem_Element = new();
public global::FrooxEngine.LegacySegmentCircleMenuController.Item _spatialItem { get => _spatialItem_Element.Data; set => _spatialItem_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacySegmentCircleMenuController.Item>, global::FrooxEngine.LegacySegmentCircleMenuController.Item> _spatialItem_Element = new();
public global::FrooxEngine.IField<System.Uri> _loopIconURL { get => _loopIconURL_Element.Data; set => _loopIconURL_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<System.Uri>, global::FrooxEngine.IField<System.Uri>> _loopIconURL_Element = new();
public global::FrooxEngine.IField<System.Uri> _spatialIconURL { get => _spatialIconURL_Element.Data; set => _spatialIconURL_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<System.Uri>, global::FrooxEngine.IField<System.Uri>> _spatialIconURL_Element = new();
public global::FrooxEngine.AudioExportable _exportable { get => _exportable_Element.Data; set => _exportable_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioExportable>, global::FrooxEngine.AudioExportable> _exportable_Element = new();
public global::FrooxEngine.AssetProxy<global::FrooxEngine.AudioClip> _assetProxy { get => _assetProxy_Element.Data; set => _assetProxy_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.AssetProxy<global::FrooxEngine.AudioClip>>, global::FrooxEngine.AssetProxy<global::FrooxEngine.AudioClip>> _assetProxy_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AudioClip", AudioClip_Element.Data.ToResoniteReference(context));
members.Add("_clipPlayer", _clipPlayer_Element.Data.ToResoniteReference(context));
members.Add("_audioOutput", _audioOutput_Element.Data.ToResoniteReference(context));
members.Add("_waveformMaterial", _waveformMaterial_Element.Data.ToResoniteReference(context));
members.Add("_playbackMaterial", _playbackMaterial_Element.Data.ToResoniteReference(context));
members.Add("_waveformRingMesh", _waveformRingMesh_Element.Data.ToResoniteReference(context));
members.Add("_playbackRingMesh", _playbackRingMesh_Element.Data.ToResoniteReference(context));
members.Add("_playbackRingArc", _playbackRingArc_Element.Data.ToResoniteReference(context));
members.Add("_volumeRingArc", _volumeRingArc_Element.Data.ToResoniteReference(context));
members.Add("_playbackTimeText", _playbackTimeText_Element.Data.ToResoniteReference(context));
members.Add("_clipLengthTimeText", _clipLengthTimeText_Element.Data.ToResoniteReference(context));
members.Add("_iconTextureURL", _iconTextureURL_Element.Data.ToResoniteReference(context));
members.Add("_stopItem", _stopItem_Element.Data.ToResoniteReference(context));
members.Add("_loopItem", _loopItem_Element.Data.ToResoniteReference(context));
members.Add("_spatialItem", _spatialItem_Element.Data.ToResoniteReference(context));
members.Add("_loopIconURL", _loopIconURL_Element.Data.ToResoniteReference(context));
members.Add("_spatialIconURL", _spatialIconURL_Element.Data.ToResoniteReference(context));
members.Add("_exportable", _exportable_Element.Data.ToResoniteReference(context));
members.Add("_assetProxy", _assetProxy_Element.Data.ToResoniteReference(context));
}

}
}
