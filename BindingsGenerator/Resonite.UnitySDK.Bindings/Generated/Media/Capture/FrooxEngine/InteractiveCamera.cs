
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCamera
// Generated on: čtvrtek 26. února 2026 15:08:01
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCamera")]
public partial class InteractiveCamera : global::FrooxEngine.Component, global::FrooxEngine.ITriggerActionReceiver, global::FrooxEngine.IGrabbableReparentBlock, global::FrooxEngine.IInteractionBlock, global::FrooxEngine.IItemMetadataSource

{
    public global::FrooxEngine.InteractiveCamera.Mode CameraMode { get => CameraMode_Element.Data; set => CameraMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.InteractiveCamera.Mode>, global::FrooxEngine.InteractiveCamera.Mode> CameraMode_Element = new();
public global::System.Int32 PreviewWidth { get => PreviewWidth_Element.Data; set => PreviewWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> PreviewWidth_Element = new();
public global::System.Int32 PreviewHeight { get => PreviewHeight_Element.Data; set => PreviewHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> PreviewHeight_Element = new();
public global::System.Int32 RenderWidth { get => RenderWidth_Element.Data; set => RenderWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RenderWidth_Element = new();
public global::System.Single StereoSeparation { get => StereoSeparation_Element.Data; set => StereoSeparation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StereoSeparation_Element = new();
public global::System.Single TimerInterval { get => TimerInterval_Element.Data; set => TimerInterval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TimerInterval_Element = new();
public global::System.Boolean TimerEnabled { get => TimerEnabled_Element.Data; set => TimerEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> TimerEnabled_Element = new();
public global::FrooxEngine.IField<global::System.String> TimerCountIndicator { get => TimerCountIndicator_Element.Data; set => TimerCountIndicator_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> TimerCountIndicator_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> TimerColorIndicator { get => TimerColorIndicator_Element.Data; set => TimerColorIndicator_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> TimerColorIndicator_Element = new();
public global::FrooxEngine.User _timerUser { get => _timerUser_Element.Data; set => _timerUser_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> _timerUser_Element = new();
public global::FrooxEngine.Camera MainCamera { get => MainCamera_Element.Data; set => MainCamera_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.Camera>, global::FrooxEngine.Camera> MainCamera_Element = new();
public global::FrooxEngine.Camera SecondaryCamera { get => SecondaryCamera_Element.Data; set => SecondaryCamera_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Camera>, global::FrooxEngine.Camera> SecondaryCamera_Element = new();
public global::FrooxEngine.RenderTextureProvider PreviewTexture { get => PreviewTexture_Element.Data; set => PreviewTexture_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.RenderTextureProvider>, global::FrooxEngine.RenderTextureProvider> PreviewTexture_Element = new();
public global::FrooxEngine.IStereoMaterial DisplayMaterial { get => DisplayMaterial_Element.Data; set => DisplayMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IStereoMaterial>, global::FrooxEngine.IStereoMaterial> DisplayMaterial_Element = new();
public global::FrooxEngine.InteractiveCamera.EncodeFormat Format { get => Format_Element.Data; set => Format_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.InteractiveCamera.EncodeFormat>, global::FrooxEngine.InteractiveCamera.EncodeFormat> Format_Element = new();
public global::System.Single Quality { get => Quality_Element.Data; set => Quality_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Quality_Element = new();
public global::System.Boolean SpawnPhotoInWorld { get => SpawnPhotoInWorld_Element.Data; set => SpawnPhotoInWorld_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SpawnPhotoInWorld_Element = new();
public global::FrooxEngine.Slot PhotoSpawnPoint { get => PhotoSpawnPoint_Element.Data; set => PhotoSpawnPoint_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> PhotoSpawnPoint_Element = new();
public global::System.Single PhotoSpawnSize { get => PhotoSpawnSize_Element.Data; set => PhotoSpawnSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PhotoSpawnSize_Element = new();
public global::FrooxEngine.Slot PanoramaIndicator { get => PanoramaIndicator_Element.Data; set => PanoramaIndicator_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> PanoramaIndicator_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> PanoramaIndicatorSize { get => PanoramaIndicatorSize_Element.Data; set => PanoramaIndicatorSize_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> PanoramaIndicatorSize_Element = new();
public global::FrooxEngine.Slot ObjectTargetSource { get => ObjectTargetSource_Element.Data; set => ObjectTargetSource_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ObjectTargetSource_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> ObjectTargetSourceActive { get => ObjectTargetSourceActive_Element.Data; set => ObjectTargetSourceActive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> ObjectTargetSourceActive_Element = new();
public global::System.Boolean ObjectAutoPose { get => ObjectAutoPose_Element.Data; set => ObjectAutoPose_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ObjectAutoPose_Element = new();
public global::System.Boolean HideLasersOnCapture { get => HideLasersOnCapture_Element.Data; set => HideLasersOnCapture_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HideLasersOnCapture_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> CaptureSound { get => CaptureSound_Element.Data; set => CaptureSound_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> CaptureSound_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> TimerStartSound { get => TimerStartSound_Element.Data; set => TimerStartSound_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> TimerStartSound_Element = new();
public global::FrooxEngine.AudioClipPlayer TimerCountdownSlowPlayer { get => TimerCountdownSlowPlayer_Element.Data; set => TimerCountdownSlowPlayer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioClipPlayer>, global::FrooxEngine.AudioClipPlayer> TimerCountdownSlowPlayer_Element = new();
public global::FrooxEngine.AudioClipPlayer TimerCountdownFastPlayer { get => TimerCountdownFastPlayer_Element.Data; set => TimerCountdownFastPlayer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioClipPlayer>, global::FrooxEngine.AudioClipPlayer> TimerCountdownFastPlayer_Element = new();
public global::FrooxEngine.AudioOutput TimerCountdownSlowOutput { get => TimerCountdownSlowOutput_Element.Data; set => TimerCountdownSlowOutput_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioOutput>, global::FrooxEngine.AudioOutput> TimerCountdownSlowOutput_Element = new();
public global::FrooxEngine.AudioOutput TimerCountdownFastOutput { get => TimerCountdownFastOutput_Element.Data; set => TimerCountdownFastOutput_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioOutput>, global::FrooxEngine.AudioOutput> TimerCountdownFastOutput_Element = new();
public UnityEngine.Vector2 PreviewScale { get => PreviewScale_Element.Data; set => PreviewScale_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Vector2>, UnityEngine.Vector2> PreviewScale_Element = new();
public global::System.String CameraModelOverride { get => CameraModelOverride_Element.Data; set => CameraModelOverride_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> CameraModelOverride_Element = new();
public global::FrooxEngine.CameraFrustumMesh FrustumVisual { get => FrustumVisual_Element.Data; set => FrustumVisual_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.CameraFrustumMesh>, global::FrooxEngine.CameraFrustumMesh> FrustumVisual_Element = new();
public global::System.Single DefaultNearClip { get => DefaultNearClip_Element.Data; set => DefaultNearClip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DefaultNearClip_Element = new();
public global::System.Single DefaultFarClip { get => DefaultFarClip_Element.Data; set => DefaultFarClip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DefaultFarClip_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _frustumPosition { get => _frustumPosition_Element.Data; set => _frustumPosition_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _frustumPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _frustumRotation { get => _frustumRotation_Element.Data; set => _frustumRotation_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _frustumRotation_Element = new();
public global::FrooxEngine.IField<global::System.Single> _frustumVerticalFOV { get => _frustumVerticalFOV_Element.Data; set => _frustumVerticalFOV_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _frustumVerticalFOV_Element = new();
public global::FrooxEngine.IField<global::System.Single> _frustumHorizontalFOV { get => _frustumHorizontalFOV_Element.Data; set => _frustumHorizontalFOV_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _frustumHorizontalFOV_Element = new();
public global::FrooxEngine.IField<global::System.Single> _frustumNear { get => _frustumNear_Element.Data; set => _frustumNear_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _frustumNear_Element = new();
public global::FrooxEngine.IField<global::System.Single> _frustumFar { get => _frustumFar_Element.Data; set => _frustumFar_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _frustumFar_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftCamOffset { get => _leftCamOffset_Element.Data; set => _leftCamOffset_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _leftCamOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightCamOffset { get => _rightCamOffset_Element.Data; set => _rightCamOffset_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _rightCamOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _leftCamOrientation { get => _leftCamOrientation_Element.Data; set => _leftCamOrientation_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _leftCamOrientation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rightCamOrientation { get => _rightCamOrientation_Element.Data; set => _rightCamOrientation_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rightCamOrientation_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _cameraRendering { get => _cameraRendering_Element.Data; set => _cameraRendering_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _cameraRendering_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _secondaryCameraRendering { get => _secondaryCameraRendering_Element.Data; set => _secondaryCameraRendering_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _secondaryCameraRendering_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.UserRef>, global::FrooxEngine.UserRef> ExclusiveOperators = new();
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.FieldDrive<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>, Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>>> ControlActiveFields = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.UserRef>, global::FrooxEngine.UserRef> RenderOnlyForUsers = new();
public global::System.Boolean ForceVisualsOff { get => ForceVisualsOff_Element.Data; set => ForceVisualsOff_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceVisualsOff_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.FieldDrive<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>, Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>>> VisualActiveFields = new();
public global::System.Single AutoHideProximity { get => AutoHideProximity_Element.Data; set => AutoHideProximity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AutoHideProximity_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.UserRef>, global::FrooxEngine.UserRef> ForceEyeAttentionUsers = new();
public global::FrooxEngine.UserRef SimulatingUser = new();
public global::FrooxEngine.UserRef DestroyOnUserLeave = new();
public global::FrooxEngine.CameraPositioningMode PositioningMode { get => PositioningMode_Element.Data; set => PositioningMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CameraPositioningMode>, global::FrooxEngine.CameraPositioningMode> PositioningMode_Element = new();
public global::FrooxEngine.InteractiveCameraAnchor ActiveAnchor { get => ActiveAnchor_Element.Data; set => ActiveAnchor_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.InteractiveCameraAnchor>, global::FrooxEngine.InteractiveCameraAnchor> ActiveAnchor_Element = new();
public global::System.Single AnchorInterpolationSpeed { get => AnchorInterpolationSpeed_Element.Data; set => AnchorInterpolationSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AnchorInterpolationSpeed_Element = new();
public global::System.Boolean AnchorLinearInterpolation { get => AnchorLinearInterpolation_Element.Data; set => AnchorLinearInterpolation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AnchorLinearInterpolation_Element = new();
public global::FrooxEngine.UserRef FrameTargetUser = new();
public UnityEngine.Vector3 HeadPointOffset { get => HeadPointOffset_Element.Data; set => HeadPointOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HeadPointOffset_Element = new();
public global::System.Single AnglePosition { get => AnglePosition_Element.Data; set => AnglePosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AnglePosition_Element = new();
public global::System.Single Distance { get => Distance_Element.Data; set => Distance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Distance_Element = new();
public global::System.Single HeightOffset { get => HeightOffset_Element.Data; set => HeightOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeightOffset_Element = new();
public global::System.Single FirstPersonPitch { get => FirstPersonPitch_Element.Data; set => FirstPersonPitch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FirstPersonPitch_Element = new();
public global::System.Single FirstPersonRoll { get => FirstPersonRoll_Element.Data; set => FirstPersonRoll_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FirstPersonRoll_Element = new();
public global::System.Single FirstPersonOffset { get => FirstPersonOffset_Element.Data; set => FirstPersonOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FirstPersonOffset_Element = new();
public global::System.Single GroupIncludeRadius { get => GroupIncludeRadius_Element.Data; set => GroupIncludeRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GroupIncludeRadius_Element = new();
public global::System.Single GroupExcludeRadius { get => GroupExcludeRadius_Element.Data; set => GroupExcludeRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GroupExcludeRadius_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.UserRef>, global::FrooxEngine.UserRef> ForceGroupInclude = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.UserRef>, global::FrooxEngine.UserRef> ForceGroupExclude = new();
public global::System.Single PositionSmoothSpeed { get => PositionSmoothSpeed_Element.Data; set => PositionSmoothSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PositionSmoothSpeed_Element = new();
public global::System.Single AnglePositionSmoothSpeed { get => AnglePositionSmoothSpeed_Element.Data; set => AnglePositionSmoothSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AnglePositionSmoothSpeed_Element = new();
public global::System.Single FramingSmoothSpeed { get => FramingSmoothSpeed_Element.Data; set => FramingSmoothSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FramingSmoothSpeed_Element = new();
public UnityEngine.Vector3 WobbleMagnitude { get => WobbleMagnitude_Element.Data; set => WobbleMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> WobbleMagnitude_Element = new();
public UnityEngine.Vector3 WobbleSeed { get => WobbleSeed_Element.Data; set => WobbleSeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> WobbleSeed_Element = new();
public UnityEngine.Vector3 WobbleSpeed { get => WobbleSpeed_Element.Data; set => WobbleSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> WobbleSpeed_Element = new();
public UnityEngine.Vector2 FramingViewportPosition { get => FramingViewportPosition_Element.Data; set => FramingViewportPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> FramingViewportPosition_Element = new();
public global::System.Boolean AvoidOcclusion { get => AvoidOcclusion_Element.Data; set => AvoidOcclusion_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AvoidOcclusion_Element = new();
public global::System.Boolean OcclusionIncludePlayers { get => OcclusionIncludePlayers_Element.Data; set => OcclusionIncludePlayers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OcclusionIncludePlayers_Element = new();
public global::System.Boolean OcclusionIncludeAnyColliders { get => OcclusionIncludeAnyColliders_Element.Data; set => OcclusionIncludeAnyColliders_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OcclusionIncludeAnyColliders_Element = new();
public global::FrooxEngine.ValueStream<UnityEngine.Vector3> _positionStream { get => _positionStream_Element.Data; set => _positionStream_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<UnityEngine.Vector3>>, global::FrooxEngine.ValueStream<UnityEngine.Vector3>> _positionStream_Element = new();
public global::FrooxEngine.ValueStream<UnityEngine.Quaternion> _rotationStream { get => _rotationStream_Element.Data; set => _rotationStream_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<UnityEngine.Quaternion>>, global::FrooxEngine.ValueStream<UnityEngine.Quaternion>> _rotationStream_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _positionDrive { get => _positionDrive_Element.Data; set => _positionDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _positionDrive_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotationDrive { get => _rotationDrive_Element.Data; set => _rotationDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rotationDrive_Element = new();
public UnityEngine.Vector3 _releasePosition { get => _releasePosition_Element.Data; set => _releasePosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> _releasePosition_Element = new();
public UnityEngine.Quaternion _releaseRotation { get => _releaseRotation_Element.Data; set => _releaseRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> _releaseRotation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CameraMode", CameraMode_Element.ToLinkField(context));
members.Add("PreviewWidth", PreviewWidth_Element.ToLinkField(context));
members.Add("PreviewHeight", PreviewHeight_Element.ToLinkField(context));
members.Add("RenderWidth", RenderWidth_Element.ToLinkField(context));
members.Add("StereoSeparation", StereoSeparation_Element.ToLinkField(context));
members.Add("TimerInterval", TimerInterval_Element.ToLinkField(context));
members.Add("TimerEnabled", TimerEnabled_Element.ToLinkField(context));
members.Add("TimerCountIndicator", TimerCountIndicator_Element.ToLinkReference(context));
members.Add("TimerColorIndicator", TimerColorIndicator_Element.ToLinkReference(context));
members.Add("_timerUser", _timerUser_Element.ToLinkReference(context));
members.Add("MainCamera", MainCamera_Element.ToLinkReference(context));
members.Add("SecondaryCamera", SecondaryCamera_Element.ToLinkReference(context));
members.Add("PreviewTexture", PreviewTexture_Element.ToLinkReference(context));
members.Add("DisplayMaterial", DisplayMaterial_Element.ToLinkReference(context));
members.Add("Format", Format_Element.ToLinkField(context));
members.Add("Quality", Quality_Element.ToLinkField(context));
members.Add("SpawnPhotoInWorld", SpawnPhotoInWorld_Element.ToLinkField(context));
members.Add("PhotoSpawnPoint", PhotoSpawnPoint_Element.ToLinkReference(context));
members.Add("PhotoSpawnSize", PhotoSpawnSize_Element.ToLinkField(context));
members.Add("PanoramaIndicator", PanoramaIndicator_Element.ToLinkReference(context));
members.Add("PanoramaIndicatorSize", PanoramaIndicatorSize_Element.ToLinkReference(context));
members.Add("ObjectTargetSource", ObjectTargetSource_Element.ToLinkReference(context));
members.Add("ObjectTargetSourceActive", ObjectTargetSourceActive_Element.ToLinkReference(context));
members.Add("ObjectAutoPose", ObjectAutoPose_Element.ToLinkField(context));
members.Add("HideLasersOnCapture", HideLasersOnCapture_Element.ToLinkField(context));
members.Add("CaptureSound", CaptureSound_Element.ToLinkReference(context));
members.Add("TimerStartSound", TimerStartSound_Element.ToLinkReference(context));
members.Add("TimerCountdownSlowPlayer", TimerCountdownSlowPlayer_Element.ToLinkReference(context));
members.Add("TimerCountdownFastPlayer", TimerCountdownFastPlayer_Element.ToLinkReference(context));
members.Add("TimerCountdownSlowOutput", TimerCountdownSlowOutput_Element.ToLinkReference(context));
members.Add("TimerCountdownFastOutput", TimerCountdownFastOutput_Element.ToLinkReference(context));
members.Add("PreviewScale", PreviewScale_Element.ToLinkField(context));
members.Add("CameraModelOverride", CameraModelOverride_Element.ToLinkField(context));
members.Add("FrustumVisual", FrustumVisual_Element.ToLinkReference(context));
members.Add("DefaultNearClip", DefaultNearClip_Element.ToLinkField(context));
members.Add("DefaultFarClip", DefaultFarClip_Element.ToLinkField(context));
members.Add("_frustumPosition", _frustumPosition_Element.ToLinkReference(context));
members.Add("_frustumRotation", _frustumRotation_Element.ToLinkReference(context));
members.Add("_frustumVerticalFOV", _frustumVerticalFOV_Element.ToLinkReference(context));
members.Add("_frustumHorizontalFOV", _frustumHorizontalFOV_Element.ToLinkReference(context));
members.Add("_frustumNear", _frustumNear_Element.ToLinkReference(context));
members.Add("_frustumFar", _frustumFar_Element.ToLinkReference(context));
members.Add("_leftCamOffset", _leftCamOffset_Element.ToLinkReference(context));
members.Add("_rightCamOffset", _rightCamOffset_Element.ToLinkReference(context));
members.Add("_leftCamOrientation", _leftCamOrientation_Element.ToLinkReference(context));
members.Add("_rightCamOrientation", _rightCamOrientation_Element.ToLinkReference(context));
members.Add("_cameraRendering", _cameraRendering_Element.ToLinkReference(context));
members.Add("_secondaryCameraRendering", _secondaryCameraRendering_Element.ToLinkReference(context));
members.Add("ExclusiveOperators", ExclusiveOperators.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("ControlActiveFields", ControlActiveFields.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("RenderOnlyForUsers", RenderOnlyForUsers.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("ForceVisualsOff", ForceVisualsOff_Element.ToLinkField(context));
members.Add("VisualActiveFields", VisualActiveFields.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("AutoHideProximity", AutoHideProximity_Element.ToLinkField(context));
members.Add("ForceEyeAttentionUsers", ForceEyeAttentionUsers.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("SimulatingUser", SimulatingUser.ToLinkSyncObject(context));
members.Add("DestroyOnUserLeave", DestroyOnUserLeave.ToLinkSyncObject(context));
members.Add("PositioningMode", PositioningMode_Element.ToLinkField(context));
members.Add("ActiveAnchor", ActiveAnchor_Element.ToLinkReference(context));
members.Add("AnchorInterpolationSpeed", AnchorInterpolationSpeed_Element.ToLinkField(context));
members.Add("AnchorLinearInterpolation", AnchorLinearInterpolation_Element.ToLinkField(context));
members.Add("FrameTargetUser", FrameTargetUser.ToLinkSyncObject(context));
members.Add("HeadPointOffset", HeadPointOffset_Element.ToLinkField(context));
members.Add("AnglePosition", AnglePosition_Element.ToLinkField(context));
members.Add("Distance", Distance_Element.ToLinkField(context));
members.Add("HeightOffset", HeightOffset_Element.ToLinkField(context));
members.Add("FirstPersonPitch", FirstPersonPitch_Element.ToLinkField(context));
members.Add("FirstPersonRoll", FirstPersonRoll_Element.ToLinkField(context));
members.Add("FirstPersonOffset", FirstPersonOffset_Element.ToLinkField(context));
members.Add("GroupIncludeRadius", GroupIncludeRadius_Element.ToLinkField(context));
members.Add("GroupExcludeRadius", GroupExcludeRadius_Element.ToLinkField(context));
members.Add("ForceGroupInclude", ForceGroupInclude.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("ForceGroupExclude", ForceGroupExclude.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("PositionSmoothSpeed", PositionSmoothSpeed_Element.ToLinkField(context));
members.Add("AnglePositionSmoothSpeed", AnglePositionSmoothSpeed_Element.ToLinkField(context));
members.Add("FramingSmoothSpeed", FramingSmoothSpeed_Element.ToLinkField(context));
members.Add("WobbleMagnitude", WobbleMagnitude_Element.ToLinkField(context));
members.Add("WobbleSeed", WobbleSeed_Element.ToLinkField(context));
members.Add("WobbleSpeed", WobbleSpeed_Element.ToLinkField(context));
members.Add("FramingViewportPosition", FramingViewportPosition_Element.ToLinkField(context));
members.Add("AvoidOcclusion", AvoidOcclusion_Element.ToLinkField(context));
members.Add("OcclusionIncludePlayers", OcclusionIncludePlayers_Element.ToLinkField(context));
members.Add("OcclusionIncludeAnyColliders", OcclusionIncludeAnyColliders_Element.ToLinkField(context));
members.Add("_positionStream", _positionStream_Element.ToLinkReference(context));
members.Add("_rotationStream", _rotationStream_Element.ToLinkReference(context));
members.Add("_positionDrive", _positionDrive_Element.ToLinkReference(context));
members.Add("_rotationDrive", _rotationDrive_Element.ToLinkReference(context));
members.Add("_releasePosition", _releasePosition_Element.ToLinkField(context));
members.Add("_releaseRotation", _releaseRotation_Element.ToLinkField(context));
}

}
}
