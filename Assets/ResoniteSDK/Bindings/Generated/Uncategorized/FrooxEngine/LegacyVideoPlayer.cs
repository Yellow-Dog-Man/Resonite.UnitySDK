
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyVideoPlayer
// Generated on: úterý 24. února 2026 18:20:25
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("StereoLayout", StereoLayout.ToResoniteLinkField());
members.Add("SizeCompensation", SizeCompensation.ToResoniteLinkField());
members.Add("videoProvider", videoProvider.ToResoniteReference(context));
members.Add("_style", _style.ToResoniteReference(context));
members.Add("_indicatorTextureUrl", _indicatorTextureUrl.ToResoniteReference(context));
members.Add("_indicatorTint", _indicatorTint.ToResoniteReference(context));
members.Add("_colliderSize", _colliderSize.ToResoniteReference(context));
members.Add("_frameWidth", _frameWidth.ToResoniteReference(context));
members.Add("_frameHeight", _frameHeight.ToResoniteReference(context));
members.Add("_frameMaterial", _frameMaterial.ToResoniteReference(context));
members.Add("_displayMaterial", _displayMaterial.ToResoniteReference(context));
members.Add("_displayMaterialTexture", _displayMaterialTexture.ToResoniteReference(context));
members.Add("_displaySize", _displaySize.ToResoniteReference(context));
members.Add("_mainAudioOutput", _mainAudioOutput.ToResoniteReference(context));
members.Add("_timelineSlider", _timelineSlider.ToResoniteReference(context));
members.Add("_timelinePosition", _timelinePosition.ToResoniteReference(context));
members.Add("_timelineWidth", _timelineWidth.ToResoniteReference(context));
members.Add("_positionDrive", _positionDrive.ToResoniteReference(context));
members.Add("_volumeSlider", _volumeSlider.ToResoniteReference(context));
members.Add("_volumePosition", _volumePosition.ToResoniteReference(context));
members.Add("_volumeWidth", _volumeWidth.ToResoniteReference(context));
members.Add("_volumeDrive", _volumeDrive.ToResoniteReference(context));
members.Add("_buttonsWidth", _buttonsWidth.ToResoniteReference(context));
members.Add("_buttonsHeight", _buttonsHeight.ToResoniteReference(context));
members.Add("_buttonsPosition", _buttonsPosition.ToResoniteReference(context));
members.Add("_playButtonColor", _playButtonColor.ToResoniteReference(context));
members.Add("_pauseButtonColor", _pauseButtonColor.ToResoniteReference(context));
members.Add("_stopButtonColor", _stopButtonColor.ToResoniteReference(context));
members.Add("_loopButtonColor", _loopButtonColor.ToResoniteReference(context));
members.Add("_audio3DButtonColor", _audio3DButtonColor.ToResoniteReference(context));
members.Add("_exportable", _exportable.ToResoniteReference(context));
members.Add("_assetProxy", _assetProxy.ToResoniteReference(context));
members.Add("_referenceProxy", _referenceProxy.ToResoniteReference(context));
}

}
}
