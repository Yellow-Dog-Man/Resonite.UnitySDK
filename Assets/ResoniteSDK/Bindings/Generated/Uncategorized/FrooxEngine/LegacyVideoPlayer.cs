
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyVideoPlayer
// Generated on: pátek 13. února 2026 5:52:34
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyVideoPlayer")]
public partial class LegacyVideoPlayer : global::FrooxEngine.Component, global::FrooxEngine.IMaterialSource, global::FrooxEngine.IMaterialApplyPolicy, global::FrooxEngine.IPlayable, global::FrooxEngine.IItemMetadataSource, global::FrooxEngine.IUIInterface

{
    public global::Elements.Core.StereoLayout StereoLayout;
public UnityEngine.Vector2 SizeCompensation;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.VideoTexture> videoProvider;
public global::FrooxEngine.LegacyUIStyle _style;
public global::FrooxEngine.IField<System.Uri> _indicatorTextureUrl;
public global::FrooxEngine.IField<UnityEngine.ColorX> _indicatorTint;
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderSize;
public global::FrooxEngine.IField<global::System.Single> _frameWidth;
public global::FrooxEngine.IField<global::System.Single> _frameHeight;
public global::FrooxEngine.PBS_RimMetallic _frameMaterial;
public global::FrooxEngine.UnlitMaterial _displayMaterial;
public global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D> _displayMaterialTexture;
public global::FrooxEngine.IField<UnityEngine.Vector2> _displaySize;
public global::FrooxEngine.AudioOutput _mainAudioOutput;
public global::FrooxEngine.LegacySlider _timelineSlider;
public global::FrooxEngine.IField<UnityEngine.Vector3> _timelinePosition;
public global::FrooxEngine.IField<global::System.Single> _timelineWidth;
public global::FrooxEngine.IField<global::System.Single> _positionDrive;
public global::FrooxEngine.LegacySlider _volumeSlider;
public global::FrooxEngine.IField<UnityEngine.Vector3> _volumePosition;
public global::FrooxEngine.IField<global::System.Single> _volumeWidth;
public global::FrooxEngine.IField<global::System.Single> _volumeDrive;
public global::FrooxEngine.IField<global::System.Single> _buttonsWidth;
public global::FrooxEngine.IField<global::System.Single> _buttonsHeight;
public global::FrooxEngine.IField<UnityEngine.Vector3> _buttonsPosition;
public global::FrooxEngine.IField<UnityEngine.ColorX> _playButtonColor;
public global::FrooxEngine.IField<UnityEngine.ColorX> _pauseButtonColor;
public global::FrooxEngine.IField<UnityEngine.ColorX> _stopButtonColor;
public global::FrooxEngine.IField<UnityEngine.ColorX> _loopButtonColor;
public global::FrooxEngine.IField<UnityEngine.ColorX> _audio3DButtonColor;
public global::FrooxEngine.VideoExportable _exportable;
public global::FrooxEngine.AssetProxy<global::FrooxEngine.VideoTexture> _assetProxy;
public global::FrooxEngine.ReferenceProxy _referenceProxy;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("StereoLayout", StereoLayout.ToResoniteLinkField());
members.Add("SizeCompensation", SizeCompensation.ToResoniteLinkField());
members.Add("videoProvider", new ResoniteLink.Reference() { });
members.Add("_style", new ResoniteLink.Reference() { });
members.Add("_indicatorTextureUrl", new ResoniteLink.Reference() { });
members.Add("_indicatorTint", new ResoniteLink.Reference() { });
members.Add("_colliderSize", new ResoniteLink.Reference() { });
members.Add("_frameWidth", new ResoniteLink.Reference() { });
members.Add("_frameHeight", new ResoniteLink.Reference() { });
members.Add("_frameMaterial", new ResoniteLink.Reference() { });
members.Add("_displayMaterial", new ResoniteLink.Reference() { });
members.Add("_displayMaterialTexture", new ResoniteLink.Reference() { });
members.Add("_displaySize", new ResoniteLink.Reference() { });
members.Add("_mainAudioOutput", new ResoniteLink.Reference() { });
members.Add("_timelineSlider", new ResoniteLink.Reference() { });
members.Add("_timelinePosition", new ResoniteLink.Reference() { });
members.Add("_timelineWidth", new ResoniteLink.Reference() { });
members.Add("_positionDrive", new ResoniteLink.Reference() { });
members.Add("_volumeSlider", new ResoniteLink.Reference() { });
members.Add("_volumePosition", new ResoniteLink.Reference() { });
members.Add("_volumeWidth", new ResoniteLink.Reference() { });
members.Add("_volumeDrive", new ResoniteLink.Reference() { });
members.Add("_buttonsWidth", new ResoniteLink.Reference() { });
members.Add("_buttonsHeight", new ResoniteLink.Reference() { });
members.Add("_buttonsPosition", new ResoniteLink.Reference() { });
members.Add("_playButtonColor", new ResoniteLink.Reference() { });
members.Add("_pauseButtonColor", new ResoniteLink.Reference() { });
members.Add("_stopButtonColor", new ResoniteLink.Reference() { });
members.Add("_loopButtonColor", new ResoniteLink.Reference() { });
members.Add("_audio3DButtonColor", new ResoniteLink.Reference() { });
members.Add("_exportable", new ResoniteLink.Reference() { });
members.Add("_assetProxy", new ResoniteLink.Reference() { });
members.Add("_referenceProxy", new ResoniteLink.Reference() { });
}

}
}
