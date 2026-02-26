
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyVideoPlayer
// Generated on: čtvrtek 26. února 2026 15:09:13
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyVideoPlayer")]
public partial class LegacyVideoPlayer : global::FrooxEngine.Component, global::FrooxEngine.IMaterialSource, global::FrooxEngine.IMaterialApplyPolicy, global::FrooxEngine.IPlayable, global::FrooxEngine.IItemMetadataSource, global::FrooxEngine.IUIInterface

{
    public global::Elements.Core.StereoLayout StereoLayout { get => StereoLayout_Element.Data; set => StereoLayout_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Core.StereoLayout>, global::Elements.Core.StereoLayout> StereoLayout_Element = new();
public UnityEngine.Vector2 SizeCompensation { get => SizeCompensation_Element.Data; set => SizeCompensation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> SizeCompensation_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.VideoTexture> videoProvider { get => videoProvider_Element.Data; set => videoProvider_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.VideoTexture>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.VideoTexture>> videoProvider_Element = new();
public global::FrooxEngine.LegacyUIStyle _style { get => _style_Element.Data; set => _style_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacyUIStyle>, global::FrooxEngine.LegacyUIStyle> _style_Element = new();
public global::FrooxEngine.IField<System.Uri> _indicatorTextureUrl { get => _indicatorTextureUrl_Element.Data; set => _indicatorTextureUrl_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<System.Uri>, global::FrooxEngine.IField<System.Uri>> _indicatorTextureUrl_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _indicatorTint { get => _indicatorTint_Element.Data; set => _indicatorTint_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _indicatorTint_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderSize { get => _colliderSize_Element.Data; set => _colliderSize_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _colliderSize_Element = new();
public global::FrooxEngine.IField<global::System.Single> _frameWidth { get => _frameWidth_Element.Data; set => _frameWidth_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _frameWidth_Element = new();
public global::FrooxEngine.IField<global::System.Single> _frameHeight { get => _frameHeight_Element.Data; set => _frameHeight_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _frameHeight_Element = new();
public global::FrooxEngine.PBS_RimMetallic _frameMaterial { get => _frameMaterial_Element.Data; set => _frameMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _frameMaterial_Element = new();
public global::FrooxEngine.UnlitMaterial _displayMaterial { get => _displayMaterial_Element.Data; set => _displayMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UnlitMaterial>, global::FrooxEngine.UnlitMaterial> _displayMaterial_Element = new();
public global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D> _displayMaterialTexture { get => _displayMaterialTexture_Element.Data; set => _displayMaterialTexture_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>>, global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>> _displayMaterialTexture_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _displaySize { get => _displaySize_Element.Data; set => _displaySize_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _displaySize_Element = new();
public global::FrooxEngine.AudioOutput _mainAudioOutput { get => _mainAudioOutput_Element.Data; set => _mainAudioOutput_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioOutput>, global::FrooxEngine.AudioOutput> _mainAudioOutput_Element = new();
public global::FrooxEngine.LegacySlider _timelineSlider { get => _timelineSlider_Element.Data; set => _timelineSlider_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacySlider>, global::FrooxEngine.LegacySlider> _timelineSlider_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _timelinePosition { get => _timelinePosition_Element.Data; set => _timelinePosition_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _timelinePosition_Element = new();
public global::FrooxEngine.IField<global::System.Single> _timelineWidth { get => _timelineWidth_Element.Data; set => _timelineWidth_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _timelineWidth_Element = new();
public global::FrooxEngine.IField<global::System.Single> _positionDrive { get => _positionDrive_Element.Data; set => _positionDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _positionDrive_Element = new();
public global::FrooxEngine.LegacySlider _volumeSlider { get => _volumeSlider_Element.Data; set => _volumeSlider_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacySlider>, global::FrooxEngine.LegacySlider> _volumeSlider_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _volumePosition { get => _volumePosition_Element.Data; set => _volumePosition_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _volumePosition_Element = new();
public global::FrooxEngine.IField<global::System.Single> _volumeWidth { get => _volumeWidth_Element.Data; set => _volumeWidth_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _volumeWidth_Element = new();
public global::FrooxEngine.IField<global::System.Single> _volumeDrive { get => _volumeDrive_Element.Data; set => _volumeDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _volumeDrive_Element = new();
public global::FrooxEngine.IField<global::System.Single> _buttonsWidth { get => _buttonsWidth_Element.Data; set => _buttonsWidth_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _buttonsWidth_Element = new();
public global::FrooxEngine.IField<global::System.Single> _buttonsHeight { get => _buttonsHeight_Element.Data; set => _buttonsHeight_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _buttonsHeight_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _buttonsPosition { get => _buttonsPosition_Element.Data; set => _buttonsPosition_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _buttonsPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _playButtonColor { get => _playButtonColor_Element.Data; set => _playButtonColor_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _playButtonColor_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _pauseButtonColor { get => _pauseButtonColor_Element.Data; set => _pauseButtonColor_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _pauseButtonColor_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _stopButtonColor { get => _stopButtonColor_Element.Data; set => _stopButtonColor_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _stopButtonColor_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _loopButtonColor { get => _loopButtonColor_Element.Data; set => _loopButtonColor_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _loopButtonColor_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _audio3DButtonColor { get => _audio3DButtonColor_Element.Data; set => _audio3DButtonColor_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _audio3DButtonColor_Element = new();
public global::FrooxEngine.VideoExportable _exportable { get => _exportable_Element.Data; set => _exportable_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.VideoExportable>, global::FrooxEngine.VideoExportable> _exportable_Element = new();
public global::FrooxEngine.AssetProxy<global::FrooxEngine.VideoTexture> _assetProxy { get => _assetProxy_Element.Data; set => _assetProxy_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AssetProxy<global::FrooxEngine.VideoTexture>>, global::FrooxEngine.AssetProxy<global::FrooxEngine.VideoTexture>> _assetProxy_Element = new();
public global::FrooxEngine.ReferenceProxy _referenceProxy { get => _referenceProxy_Element.Data; set => _referenceProxy_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ReferenceProxy>, global::FrooxEngine.ReferenceProxy> _referenceProxy_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("StereoLayout", StereoLayout_Element.ToLinkField(context));
members.Add("SizeCompensation", SizeCompensation_Element.ToLinkField(context));
members.Add("videoProvider", videoProvider_Element.ToLinkReference(context));
members.Add("_style", _style_Element.ToLinkReference(context));
members.Add("_indicatorTextureUrl", _indicatorTextureUrl_Element.ToLinkReference(context));
members.Add("_indicatorTint", _indicatorTint_Element.ToLinkReference(context));
members.Add("_colliderSize", _colliderSize_Element.ToLinkReference(context));
members.Add("_frameWidth", _frameWidth_Element.ToLinkReference(context));
members.Add("_frameHeight", _frameHeight_Element.ToLinkReference(context));
members.Add("_frameMaterial", _frameMaterial_Element.ToLinkReference(context));
members.Add("_displayMaterial", _displayMaterial_Element.ToLinkReference(context));
members.Add("_displayMaterialTexture", _displayMaterialTexture_Element.ToLinkReference(context));
members.Add("_displaySize", _displaySize_Element.ToLinkReference(context));
members.Add("_mainAudioOutput", _mainAudioOutput_Element.ToLinkReference(context));
members.Add("_timelineSlider", _timelineSlider_Element.ToLinkReference(context));
members.Add("_timelinePosition", _timelinePosition_Element.ToLinkReference(context));
members.Add("_timelineWidth", _timelineWidth_Element.ToLinkReference(context));
members.Add("_positionDrive", _positionDrive_Element.ToLinkReference(context));
members.Add("_volumeSlider", _volumeSlider_Element.ToLinkReference(context));
members.Add("_volumePosition", _volumePosition_Element.ToLinkReference(context));
members.Add("_volumeWidth", _volumeWidth_Element.ToLinkReference(context));
members.Add("_volumeDrive", _volumeDrive_Element.ToLinkReference(context));
members.Add("_buttonsWidth", _buttonsWidth_Element.ToLinkReference(context));
members.Add("_buttonsHeight", _buttonsHeight_Element.ToLinkReference(context));
members.Add("_buttonsPosition", _buttonsPosition_Element.ToLinkReference(context));
members.Add("_playButtonColor", _playButtonColor_Element.ToLinkReference(context));
members.Add("_pauseButtonColor", _pauseButtonColor_Element.ToLinkReference(context));
members.Add("_stopButtonColor", _stopButtonColor_Element.ToLinkReference(context));
members.Add("_loopButtonColor", _loopButtonColor_Element.ToLinkReference(context));
members.Add("_audio3DButtonColor", _audio3DButtonColor_Element.ToLinkReference(context));
members.Add("_exportable", _exportable_Element.ToLinkReference(context));
members.Add("_assetProxy", _assetProxy_Element.ToLinkReference(context));
members.Add("_referenceProxy", _referenceProxy_Element.ToLinkReference(context));
}

}
}
