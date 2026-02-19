
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCamera
// Generated on: čtvrtek 19. února 2026 7:59:00
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::FrooxEngine.InteractiveCamera.Mode CameraMode;
public global::System.Int32 PreviewWidth;
public global::System.Int32 PreviewHeight;
public global::System.Int32 RenderWidth;
public global::System.Single StereoSeparation;
public global::System.Single TimerInterval;
public global::System.Boolean TimerEnabled;
public global::FrooxEngine.IField<global::System.String> TimerCountIndicator;
public global::FrooxEngine.IField<UnityEngine.ColorX> TimerColorIndicator;
public global::FrooxEngine.User _timerUser;
public global::FrooxEngine.Camera MainCamera;
public global::FrooxEngine.Camera SecondaryCamera;
public global::FrooxEngine.RenderTextureProvider PreviewTexture;
public global::FrooxEngine.IStereoMaterial DisplayMaterial;
public global::FrooxEngine.InteractiveCamera.EncodeFormat Format;
public global::System.Single Quality;
public global::System.Boolean SpawnPhotoInWorld;
public global::FrooxEngine.Slot PhotoSpawnPoint;
public global::System.Single PhotoSpawnSize;
public global::FrooxEngine.Slot PanoramaIndicator;
public global::FrooxEngine.IField<UnityEngine.Vector3> PanoramaIndicatorSize;
public global::FrooxEngine.Slot ObjectTargetSource;
public global::FrooxEngine.IField<global::System.Boolean> ObjectTargetSourceActive;
public global::System.Boolean ObjectAutoPose;
public global::System.Boolean HideLasersOnCapture;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> CaptureSound;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> TimerStartSound;
public global::FrooxEngine.AudioClipPlayer TimerCountdownSlowPlayer;
public global::FrooxEngine.AudioClipPlayer TimerCountdownFastPlayer;
public global::FrooxEngine.AudioOutput TimerCountdownSlowOutput;
public global::FrooxEngine.AudioOutput TimerCountdownFastOutput;
public UnityEngine.Vector2 PreviewScale;
public global::System.String CameraModelOverride;
public global::FrooxEngine.CameraFrustumMesh FrustumVisual;
public global::System.Single DefaultNearClip;
public global::System.Single DefaultFarClip;
public global::FrooxEngine.IField<UnityEngine.Vector3> _frustumPosition;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _frustumRotation;
public global::FrooxEngine.IField<global::System.Single> _frustumVerticalFOV;
public global::FrooxEngine.IField<global::System.Single> _frustumHorizontalFOV;
public global::FrooxEngine.IField<global::System.Single> _frustumNear;
public global::FrooxEngine.IField<global::System.Single> _frustumFar;
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftCamOffset;
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightCamOffset;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _leftCamOrientation;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rightCamOrientation;
public global::FrooxEngine.IField<global::System.Boolean> _cameraRendering;
public global::FrooxEngine.IField<global::System.Boolean> _secondaryCameraRendering;
public System.Collections.Generic.List<global::FrooxEngine.UserRef> ExclusiveOperators;
public System.Collections.Generic.List<global::FrooxEngine.IField<global::System.Boolean>> ControlActiveFields;
public System.Collections.Generic.List<global::FrooxEngine.UserRef> RenderOnlyForUsers;
public global::System.Boolean ForceVisualsOff;
public System.Collections.Generic.List<global::FrooxEngine.IField<global::System.Boolean>> VisualActiveFields;
public global::System.Single AutoHideProximity;
public System.Collections.Generic.List<global::FrooxEngine.UserRef> ForceEyeAttentionUsers;
public global::FrooxEngine.UserRef SimulatingUser;
public global::FrooxEngine.UserRef DestroyOnUserLeave;
public global::FrooxEngine.CameraPositioningMode PositioningMode;
public global::FrooxEngine.InteractiveCameraAnchor ActiveAnchor;
public global::System.Single AnchorInterpolationSpeed;
public global::System.Boolean AnchorLinearInterpolation;
public global::FrooxEngine.UserRef FrameTargetUser;
public UnityEngine.Vector3 HeadPointOffset;
public global::System.Single AnglePosition;
public global::System.Single Distance;
public global::System.Single HeightOffset;
public global::System.Single FirstPersonPitch;
public global::System.Single FirstPersonRoll;
public global::System.Single FirstPersonOffset;
public global::System.Single GroupIncludeRadius;
public global::System.Single GroupExcludeRadius;
public System.Collections.Generic.List<global::FrooxEngine.UserRef> ForceGroupInclude;
public System.Collections.Generic.List<global::FrooxEngine.UserRef> ForceGroupExclude;
public global::System.Single PositionSmoothSpeed;
public global::System.Single AnglePositionSmoothSpeed;
public global::System.Single FramingSmoothSpeed;
public UnityEngine.Vector3 WobbleMagnitude;
public UnityEngine.Vector3 WobbleSeed;
public UnityEngine.Vector3 WobbleSpeed;
public UnityEngine.Vector2 FramingViewportPosition;
public global::System.Boolean AvoidOcclusion;
public global::System.Boolean OcclusionIncludePlayers;
public global::System.Boolean OcclusionIncludeAnyColliders;
public global::FrooxEngine.ValueStream<UnityEngine.Vector3> _positionStream;
public global::FrooxEngine.ValueStream<UnityEngine.Quaternion> _rotationStream;
public global::FrooxEngine.IField<UnityEngine.Vector3> _positionDrive;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotationDrive;
public UnityEngine.Vector3 _releasePosition;
public UnityEngine.Quaternion _releaseRotation;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CameraMode", CameraMode.ToResoniteLinkField());
members.Add("PreviewWidth", PreviewWidth.ToResoniteLinkField());
members.Add("PreviewHeight", PreviewHeight.ToResoniteLinkField());
members.Add("RenderWidth", RenderWidth.ToResoniteLinkField());
members.Add("StereoSeparation", StereoSeparation.ToResoniteLinkField());
members.Add("TimerInterval", TimerInterval.ToResoniteLinkField());
members.Add("TimerEnabled", TimerEnabled.ToResoniteLinkField());
members.Add("TimerCountIndicator", TimerCountIndicator.ToResoniteReference(context));
members.Add("TimerColorIndicator", TimerColorIndicator.ToResoniteReference(context));
members.Add("_timerUser", _timerUser.ToResoniteReference(context));
members.Add("MainCamera", MainCamera.ToResoniteReference(context));
members.Add("SecondaryCamera", SecondaryCamera.ToResoniteReference(context));
members.Add("PreviewTexture", PreviewTexture.ToResoniteReference(context));
members.Add("DisplayMaterial", DisplayMaterial.ToResoniteReference(context));
members.Add("Format", Format.ToResoniteLinkField());
members.Add("Quality", Quality.ToResoniteLinkField());
members.Add("SpawnPhotoInWorld", SpawnPhotoInWorld.ToResoniteLinkField());
members.Add("PhotoSpawnPoint", PhotoSpawnPoint.ToResoniteReference(context));
members.Add("PhotoSpawnSize", PhotoSpawnSize.ToResoniteLinkField());
members.Add("PanoramaIndicator", PanoramaIndicator.ToResoniteReference(context));
members.Add("PanoramaIndicatorSize", PanoramaIndicatorSize.ToResoniteReference(context));
members.Add("ObjectTargetSource", ObjectTargetSource.ToResoniteReference(context));
members.Add("ObjectTargetSourceActive", ObjectTargetSourceActive.ToResoniteReference(context));
members.Add("ObjectAutoPose", ObjectAutoPose.ToResoniteLinkField());
members.Add("HideLasersOnCapture", HideLasersOnCapture.ToResoniteLinkField());
members.Add("CaptureSound", CaptureSound.ToResoniteReference(context));
members.Add("TimerStartSound", TimerStartSound.ToResoniteReference(context));
members.Add("TimerCountdownSlowPlayer", TimerCountdownSlowPlayer.ToResoniteReference(context));
members.Add("TimerCountdownFastPlayer", TimerCountdownFastPlayer.ToResoniteReference(context));
members.Add("TimerCountdownSlowOutput", TimerCountdownSlowOutput.ToResoniteReference(context));
members.Add("TimerCountdownFastOutput", TimerCountdownFastOutput.ToResoniteReference(context));
members.Add("PreviewScale", PreviewScale.ToResoniteLinkField());
members.Add("CameraModelOverride", CameraModelOverride.ToResoniteLinkField());
members.Add("FrustumVisual", FrustumVisual.ToResoniteReference(context));
members.Add("DefaultNearClip", DefaultNearClip.ToResoniteLinkField());
members.Add("DefaultFarClip", DefaultFarClip.ToResoniteLinkField());
members.Add("_frustumPosition", _frustumPosition.ToResoniteReference(context));
members.Add("_frustumRotation", _frustumRotation.ToResoniteReference(context));
members.Add("_frustumVerticalFOV", _frustumVerticalFOV.ToResoniteReference(context));
members.Add("_frustumHorizontalFOV", _frustumHorizontalFOV.ToResoniteReference(context));
members.Add("_frustumNear", _frustumNear.ToResoniteReference(context));
members.Add("_frustumFar", _frustumFar.ToResoniteReference(context));
members.Add("_leftCamOffset", _leftCamOffset.ToResoniteReference(context));
members.Add("_rightCamOffset", _rightCamOffset.ToResoniteReference(context));
members.Add("_leftCamOrientation", _leftCamOrientation.ToResoniteReference(context));
members.Add("_rightCamOrientation", _rightCamOrientation.ToResoniteReference(context));
members.Add("_cameraRendering", _cameraRendering.ToResoniteReference(context));
members.Add("_secondaryCameraRendering", _secondaryCameraRendering.ToResoniteReference(context));
members.Add("ExclusiveOperators", new ResoniteLink.SyncList()
{
    Elements = ExclusiveOperators.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("ControlActiveFields", new ResoniteLink.SyncList()
{
    Elements = ControlActiveFields.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("RenderOnlyForUsers", new ResoniteLink.SyncList()
{
    Elements = RenderOnlyForUsers.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("ForceVisualsOff", ForceVisualsOff.ToResoniteLinkField());
members.Add("VisualActiveFields", new ResoniteLink.SyncList()
{
    Elements = VisualActiveFields.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("AutoHideProximity", AutoHideProximity.ToResoniteLinkField());
members.Add("ForceEyeAttentionUsers", new ResoniteLink.SyncList()
{
    Elements = ForceEyeAttentionUsers.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("SimulatingUser", new ResoniteLink.SyncObject() { Members = SimulatingUser.CollectMembers(context) });
members.Add("DestroyOnUserLeave", new ResoniteLink.SyncObject() { Members = DestroyOnUserLeave.CollectMembers(context) });
members.Add("PositioningMode", PositioningMode.ToResoniteLinkField());
members.Add("ActiveAnchor", ActiveAnchor.ToResoniteReference(context));
members.Add("AnchorInterpolationSpeed", AnchorInterpolationSpeed.ToResoniteLinkField());
members.Add("AnchorLinearInterpolation", AnchorLinearInterpolation.ToResoniteLinkField());
members.Add("FrameTargetUser", new ResoniteLink.SyncObject() { Members = FrameTargetUser.CollectMembers(context) });
members.Add("HeadPointOffset", HeadPointOffset.ToResoniteLinkField());
members.Add("AnglePosition", AnglePosition.ToResoniteLinkField());
members.Add("Distance", Distance.ToResoniteLinkField());
members.Add("HeightOffset", HeightOffset.ToResoniteLinkField());
members.Add("FirstPersonPitch", FirstPersonPitch.ToResoniteLinkField());
members.Add("FirstPersonRoll", FirstPersonRoll.ToResoniteLinkField());
members.Add("FirstPersonOffset", FirstPersonOffset.ToResoniteLinkField());
members.Add("GroupIncludeRadius", GroupIncludeRadius.ToResoniteLinkField());
members.Add("GroupExcludeRadius", GroupExcludeRadius.ToResoniteLinkField());
members.Add("ForceGroupInclude", new ResoniteLink.SyncList()
{
    Elements = ForceGroupInclude.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("ForceGroupExclude", new ResoniteLink.SyncList()
{
    Elements = ForceGroupExclude.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("PositionSmoothSpeed", PositionSmoothSpeed.ToResoniteLinkField());
members.Add("AnglePositionSmoothSpeed", AnglePositionSmoothSpeed.ToResoniteLinkField());
members.Add("FramingSmoothSpeed", FramingSmoothSpeed.ToResoniteLinkField());
members.Add("WobbleMagnitude", WobbleMagnitude.ToResoniteLinkField());
members.Add("WobbleSeed", WobbleSeed.ToResoniteLinkField());
members.Add("WobbleSpeed", WobbleSpeed.ToResoniteLinkField());
members.Add("FramingViewportPosition", FramingViewportPosition.ToResoniteLinkField());
members.Add("AvoidOcclusion", AvoidOcclusion.ToResoniteLinkField());
members.Add("OcclusionIncludePlayers", OcclusionIncludePlayers.ToResoniteLinkField());
members.Add("OcclusionIncludeAnyColliders", OcclusionIncludeAnyColliders.ToResoniteLinkField());
members.Add("_positionStream", _positionStream.ToResoniteReference(context));
members.Add("_rotationStream", _rotationStream.ToResoniteReference(context));
members.Add("_positionDrive", _positionDrive.ToResoniteReference(context));
members.Add("_rotationDrive", _rotationDrive.ToResoniteReference(context));
members.Add("_releasePosition", _releasePosition.ToResoniteLinkField());
members.Add("_releaseRotation", _releaseRotation.ToResoniteLinkField());
}

}
}
