
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotoCaptureManager
// Generated on: pátek 13. února 2026 5:52:35
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotoCaptureManager")]
public partial class PhotoCaptureManager : global::FrooxEngine.Component

{
    public global::System.Boolean FingerGestureEnabled;
public global::System.Single MinDistance;
public global::System.Single MaxDistance;
public global::System.Single MinFOV;
public global::System.Single MaxFOV;
public UnityEngine.Vector2Int PreviewResolution;
public UnityEngine.Vector2Int NormalResolution;
public UnityEngine.Vector2Int TimerResolution;
public global::System.Boolean CaptureStereo;
public global::System.Single StereoSeparation;
public global::System.Single TimerSeconds;
public global::System.Boolean HideAllNameplates;
public global::FrooxEngine.PhotoEncodeFormat EncodeFormat;
public global::System.Boolean DebugGesture;
public global::System.Boolean _timerActive;
public global::FrooxEngine.Slot _originalParent;
public UnityEngine.Vector3 _originalPosition;
public UnityEngine.Quaternion _originalRotation;
public UnityEngine.Vector3 _originalScale;
public global::FrooxEngine.Slot _root;
public global::FrooxEngine.Slot _previewRoot;
public global::FrooxEngine.RenderTextureProvider _renderTex;
public global::FrooxEngine.QuadMesh _quad;
public global::FrooxEngine.FrameMesh _frame;
public global::FrooxEngine.Slot _cameraRoot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _cameraPos;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _cameraRot;
public global::FrooxEngine.Camera _camera;
public global::FrooxEngine.UnlitMaterial _frameMaterial;
public global::FrooxEngine.Slot _timerTextRoot;
public global::FrooxEngine.TextRenderer _timerText;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _shutterClip;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _timerStartClip;
public global::FrooxEngine.AudioClipPlayer _timerCountdownSlowPlayer;
public global::FrooxEngine.AudioClipPlayer _timerCountdownFastPlayer;
public global::FrooxEngine.AudioOutput _timerCountdownSlowOutput;
public global::FrooxEngine.AudioOutput _timerCountdownFastOutput;
public global::FrooxEngine.Slot _timerRoot;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("FingerGestureEnabled", FingerGestureEnabled.ToResoniteLinkField());
members.Add("MinDistance", MinDistance.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance.ToResoniteLinkField());
members.Add("MinFOV", MinFOV.ToResoniteLinkField());
members.Add("MaxFOV", MaxFOV.ToResoniteLinkField());
members.Add("PreviewResolution", PreviewResolution.ToResoniteLinkField());
members.Add("NormalResolution", NormalResolution.ToResoniteLinkField());
members.Add("TimerResolution", TimerResolution.ToResoniteLinkField());
members.Add("CaptureStereo", CaptureStereo.ToResoniteLinkField());
members.Add("StereoSeparation", StereoSeparation.ToResoniteLinkField());
members.Add("TimerSeconds", TimerSeconds.ToResoniteLinkField());
members.Add("HideAllNameplates", HideAllNameplates.ToResoniteLinkField());
members.Add("EncodeFormat", EncodeFormat.ToResoniteLinkField());
members.Add("DebugGesture", DebugGesture.ToResoniteLinkField());
members.Add("_timerActive", _timerActive.ToResoniteLinkField());
members.Add("_originalParent", new ResoniteLink.Reference() { });
members.Add("_originalPosition", _originalPosition.ToResoniteLinkField());
members.Add("_originalRotation", _originalRotation.ToResoniteLinkField());
members.Add("_originalScale", _originalScale.ToResoniteLinkField());
members.Add("_root", new ResoniteLink.Reference() { });
members.Add("_previewRoot", new ResoniteLink.Reference() { });
members.Add("_renderTex", new ResoniteLink.Reference() { });
members.Add("_quad", new ResoniteLink.Reference() { });
members.Add("_frame", new ResoniteLink.Reference() { });
members.Add("_cameraRoot", new ResoniteLink.Reference() { });
members.Add("_cameraPos", new ResoniteLink.Reference() { });
members.Add("_cameraRot", new ResoniteLink.Reference() { });
members.Add("_camera", new ResoniteLink.Reference() { });
members.Add("_frameMaterial", new ResoniteLink.Reference() { });
members.Add("_timerTextRoot", new ResoniteLink.Reference() { });
members.Add("_timerText", new ResoniteLink.Reference() { });
members.Add("_shutterClip", new ResoniteLink.Reference() { });
members.Add("_timerStartClip", new ResoniteLink.Reference() { });
members.Add("_timerCountdownSlowPlayer", new ResoniteLink.Reference() { });
members.Add("_timerCountdownFastPlayer", new ResoniteLink.Reference() { });
members.Add("_timerCountdownSlowOutput", new ResoniteLink.Reference() { });
members.Add("_timerCountdownFastOutput", new ResoniteLink.Reference() { });
members.Add("_timerRoot", new ResoniteLink.Reference() { });
}

}
}
