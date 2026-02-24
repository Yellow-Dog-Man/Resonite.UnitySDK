
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotoCaptureManager
// Generated on: úterý 24. února 2026 18:20:26
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
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
members.Add("_originalParent", _originalParent.ToResoniteReference(context));
members.Add("_originalPosition", _originalPosition.ToResoniteLinkField());
members.Add("_originalRotation", _originalRotation.ToResoniteLinkField());
members.Add("_originalScale", _originalScale.ToResoniteLinkField());
members.Add("_root", _root.ToResoniteReference(context));
members.Add("_previewRoot", _previewRoot.ToResoniteReference(context));
members.Add("_renderTex", _renderTex.ToResoniteReference(context));
members.Add("_quad", _quad.ToResoniteReference(context));
members.Add("_frame", _frame.ToResoniteReference(context));
members.Add("_cameraRoot", _cameraRoot.ToResoniteReference(context));
members.Add("_cameraPos", _cameraPos.ToResoniteReference(context));
members.Add("_cameraRot", _cameraRot.ToResoniteReference(context));
members.Add("_camera", _camera.ToResoniteReference(context));
members.Add("_frameMaterial", _frameMaterial.ToResoniteReference(context));
members.Add("_timerTextRoot", _timerTextRoot.ToResoniteReference(context));
members.Add("_timerText", _timerText.ToResoniteReference(context));
members.Add("_shutterClip", _shutterClip.ToResoniteReference(context));
members.Add("_timerStartClip", _timerStartClip.ToResoniteReference(context));
members.Add("_timerCountdownSlowPlayer", _timerCountdownSlowPlayer.ToResoniteReference(context));
members.Add("_timerCountdownFastPlayer", _timerCountdownFastPlayer.ToResoniteReference(context));
members.Add("_timerCountdownSlowOutput", _timerCountdownSlowOutput.ToResoniteReference(context));
members.Add("_timerCountdownFastOutput", _timerCountdownFastOutput.ToResoniteReference(context));
members.Add("_timerRoot", _timerRoot.ToResoniteReference(context));
}

}
}
