
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotoCaptureManager
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotoCaptureManager")]
public partial class PhotoCaptureManager : global::FrooxEngine.Component

{
    public global::System.Boolean FingerGestureEnabled { get => FingerGestureEnabled_Element.Data; set => FingerGestureEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FingerGestureEnabled_Element = new();
public global::System.Single MinDistance { get => MinDistance_Element.Data; set => MinDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinDistance_Element = new();
public global::System.Single MaxDistance { get => MaxDistance_Element.Data; set => MaxDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxDistance_Element = new();
public global::System.Single MinFOV { get => MinFOV_Element.Data; set => MinFOV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinFOV_Element = new();
public global::System.Single MaxFOV { get => MaxFOV_Element.Data; set => MaxFOV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxFOV_Element = new();
public UnityEngine.Vector2Int PreviewResolution { get => PreviewResolution_Element.Data; set => PreviewResolution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> PreviewResolution_Element = new();
public UnityEngine.Vector2Int NormalResolution { get => NormalResolution_Element.Data; set => NormalResolution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> NormalResolution_Element = new();
public UnityEngine.Vector2Int TimerResolution { get => TimerResolution_Element.Data; set => TimerResolution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> TimerResolution_Element = new();
public global::System.Boolean CaptureStereo { get => CaptureStereo_Element.Data; set => CaptureStereo_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CaptureStereo_Element = new();
public global::System.Single StereoSeparation { get => StereoSeparation_Element.Data; set => StereoSeparation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StereoSeparation_Element = new();
public global::System.Single TimerSeconds { get => TimerSeconds_Element.Data; set => TimerSeconds_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TimerSeconds_Element = new();
public global::System.Boolean HideAllNameplates { get => HideAllNameplates_Element.Data; set => HideAllNameplates_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HideAllNameplates_Element = new();
public global::FrooxEngine.PhotoEncodeFormat EncodeFormat { get => EncodeFormat_Element.Data; set => EncodeFormat_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PhotoEncodeFormat>, global::FrooxEngine.PhotoEncodeFormat> EncodeFormat_Element = new();
public global::System.Boolean DebugGesture { get => DebugGesture_Element.Data; set => DebugGesture_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DebugGesture_Element = new();
public global::System.Boolean _timerActive { get => _timerActive_Element.Data; set => _timerActive_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _timerActive_Element = new();
public global::FrooxEngine.Slot _originalParent { get => _originalParent_Element.Data; set => _originalParent_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _originalParent_Element = new();
public UnityEngine.Vector3 _originalPosition { get => _originalPosition_Element.Data; set => _originalPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> _originalPosition_Element = new();
public UnityEngine.Quaternion _originalRotation { get => _originalRotation_Element.Data; set => _originalRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> _originalRotation_Element = new();
public UnityEngine.Vector3 _originalScale { get => _originalScale_Element.Data; set => _originalScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> _originalScale_Element = new();
public global::FrooxEngine.Slot _root { get => _root_Element.Data; set => _root_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _root_Element = new();
public global::FrooxEngine.Slot _previewRoot { get => _previewRoot_Element.Data; set => _previewRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _previewRoot_Element = new();
public global::FrooxEngine.RenderTextureProvider _renderTex { get => _renderTex_Element.Data; set => _renderTex_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.RenderTextureProvider>, global::FrooxEngine.RenderTextureProvider> _renderTex_Element = new();
public global::FrooxEngine.QuadMesh _quad { get => _quad_Element.Data; set => _quad_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.QuadMesh>, global::FrooxEngine.QuadMesh> _quad_Element = new();
public global::FrooxEngine.FrameMesh _frame { get => _frame_Element.Data; set => _frame_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.FrameMesh>, global::FrooxEngine.FrameMesh> _frame_Element = new();
public global::FrooxEngine.Slot _cameraRoot { get => _cameraRoot_Element.Data; set => _cameraRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _cameraRoot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _cameraPos { get => _cameraPos_Element.Data; set => _cameraPos_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _cameraPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _cameraRot { get => _cameraRot_Element.Data; set => _cameraRot_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _cameraRot_Element = new();
public global::FrooxEngine.Camera _camera { get => _camera_Element.Data; set => _camera_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Camera>, global::FrooxEngine.Camera> _camera_Element = new();
public global::FrooxEngine.UnlitMaterial _frameMaterial { get => _frameMaterial_Element.Data; set => _frameMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UnlitMaterial>, global::FrooxEngine.UnlitMaterial> _frameMaterial_Element = new();
public global::FrooxEngine.Slot _timerTextRoot { get => _timerTextRoot_Element.Data; set => _timerTextRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _timerTextRoot_Element = new();
public global::FrooxEngine.TextRenderer _timerText { get => _timerText_Element.Data; set => _timerText_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _timerText_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _shutterClip { get => _shutterClip_Element.Data; set => _shutterClip_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> _shutterClip_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _timerStartClip { get => _timerStartClip_Element.Data; set => _timerStartClip_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> _timerStartClip_Element = new();
public global::FrooxEngine.AudioClipPlayer _timerCountdownSlowPlayer { get => _timerCountdownSlowPlayer_Element.Data; set => _timerCountdownSlowPlayer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioClipPlayer>, global::FrooxEngine.AudioClipPlayer> _timerCountdownSlowPlayer_Element = new();
public global::FrooxEngine.AudioClipPlayer _timerCountdownFastPlayer { get => _timerCountdownFastPlayer_Element.Data; set => _timerCountdownFastPlayer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioClipPlayer>, global::FrooxEngine.AudioClipPlayer> _timerCountdownFastPlayer_Element = new();
public global::FrooxEngine.AudioOutput _timerCountdownSlowOutput { get => _timerCountdownSlowOutput_Element.Data; set => _timerCountdownSlowOutput_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioOutput>, global::FrooxEngine.AudioOutput> _timerCountdownSlowOutput_Element = new();
public global::FrooxEngine.AudioOutput _timerCountdownFastOutput { get => _timerCountdownFastOutput_Element.Data; set => _timerCountdownFastOutput_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioOutput>, global::FrooxEngine.AudioOutput> _timerCountdownFastOutput_Element = new();
public global::FrooxEngine.Slot _timerRoot { get => _timerRoot_Element.Data; set => _timerRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _timerRoot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FingerGestureEnabled", FingerGestureEnabled_Element.ToLinkField(context));
members.Add("MinDistance", MinDistance_Element.ToLinkField(context));
members.Add("MaxDistance", MaxDistance_Element.ToLinkField(context));
members.Add("MinFOV", MinFOV_Element.ToLinkField(context));
members.Add("MaxFOV", MaxFOV_Element.ToLinkField(context));
members.Add("PreviewResolution", PreviewResolution_Element.ToLinkField(context));
members.Add("NormalResolution", NormalResolution_Element.ToLinkField(context));
members.Add("TimerResolution", TimerResolution_Element.ToLinkField(context));
members.Add("CaptureStereo", CaptureStereo_Element.ToLinkField(context));
members.Add("StereoSeparation", StereoSeparation_Element.ToLinkField(context));
members.Add("TimerSeconds", TimerSeconds_Element.ToLinkField(context));
members.Add("HideAllNameplates", HideAllNameplates_Element.ToLinkField(context));
members.Add("EncodeFormat", EncodeFormat_Element.ToLinkField(context));
members.Add("DebugGesture", DebugGesture_Element.ToLinkField(context));
members.Add("_timerActive", _timerActive_Element.ToLinkField(context));
members.Add("_originalParent", _originalParent_Element.ToLinkReference(context));
members.Add("_originalPosition", _originalPosition_Element.ToLinkField(context));
members.Add("_originalRotation", _originalRotation_Element.ToLinkField(context));
members.Add("_originalScale", _originalScale_Element.ToLinkField(context));
members.Add("_root", _root_Element.ToLinkReference(context));
members.Add("_previewRoot", _previewRoot_Element.ToLinkReference(context));
members.Add("_renderTex", _renderTex_Element.ToLinkReference(context));
members.Add("_quad", _quad_Element.ToLinkReference(context));
members.Add("_frame", _frame_Element.ToLinkReference(context));
members.Add("_cameraRoot", _cameraRoot_Element.ToLinkReference(context));
members.Add("_cameraPos", _cameraPos_Element.ToLinkReference(context));
members.Add("_cameraRot", _cameraRot_Element.ToLinkReference(context));
members.Add("_camera", _camera_Element.ToLinkReference(context));
members.Add("_frameMaterial", _frameMaterial_Element.ToLinkReference(context));
members.Add("_timerTextRoot", _timerTextRoot_Element.ToLinkReference(context));
members.Add("_timerText", _timerText_Element.ToLinkReference(context));
members.Add("_shutterClip", _shutterClip_Element.ToLinkReference(context));
members.Add("_timerStartClip", _timerStartClip_Element.ToLinkReference(context));
members.Add("_timerCountdownSlowPlayer", _timerCountdownSlowPlayer_Element.ToLinkReference(context));
members.Add("_timerCountdownFastPlayer", _timerCountdownFastPlayer_Element.ToLinkReference(context));
members.Add("_timerCountdownSlowOutput", _timerCountdownSlowOutput_Element.ToLinkReference(context));
members.Add("_timerCountdownFastOutput", _timerCountdownFastOutput_Element.ToLinkReference(context));
members.Add("_timerRoot", _timerRoot_Element.ToLinkReference(context));
}

}
}
