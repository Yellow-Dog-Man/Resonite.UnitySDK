
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraControl
// Generated on: sobota 14. února 2026 8:58:44
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraControl")]
public partial class InteractiveCameraControl : global::FrooxEngine.LegacyCanvasPanel

{
    public global::System.Single FieldOfView;
public global::System.Single AnglePosition;
public global::System.Single Distance;
public global::System.Single HeightOffset;
public global::System.Single FirstPersonPitch;
public global::System.Single FirstPersonRoll;
public global::System.Single FirstPersonOffset;
public UnityEngine.Vector2 FramingViewportPosition;
public global::System.Boolean Mirror;
public global::System.Single GroupDetectionRadius;
public global::System.Single GroupLeaveBoundary;
public global::System.Single PositionSmoothSpeed;
public global::System.Single AngleSmoothSpeed;
public global::System.Single FramingSmoothSpeed;
public global::System.Boolean InterpolateBetweenAnchors;
public global::System.Single AnchorInterpolationSpeed;
public global::System.Boolean AnchorLinearInterpolation;
public global::FrooxEngine.CameraPositioningMode Mode;
public global::System.String FramingTargetOverride;
public System.Collections.Generic.List<global::System.String> CameraOperators;
public System.Collections.Generic.List<global::System.String> GroupIncludeUsers;
public System.Collections.Generic.List<global::System.String> GroupExcludeUsers;
public global::System.Boolean RenderForEveryone;
public global::System.Boolean AnyoneCanInteract;
public global::System.Boolean RenderPrivateUI;
public global::System.Boolean MotionBlur;
public global::System.Boolean ScreenSpaceReflections;
public global::System.Boolean SpawnPhotoInWorld;
public global::System.Boolean FlipPreview;
public global::FrooxEngine.RenderTextureProxyProvider _renderTextureProxy;
public global::FrooxEngine.UIX.RectTransform _framingReticle;
public global::FrooxEngine.UIX.RectTransform _mirrorMessage;
public global::FrooxEngine.UIX.Button _smoothFirstPersonButton;
public global::FrooxEngine.UIX.Button _thirdPersonButton;
public global::FrooxEngine.UIX.Button _groupButton;
public global::FrooxEngine.UIX.Button _worldButton;
public global::FrooxEngine.UIX.Button _manualButton;
public global::FrooxEngine.UIX.Button _mirrorButton;
public global::FrooxEngine.UIX.Button _usersButton;
public global::FrooxEngine.UIX.Button _angleIncreaseButton;
public global::FrooxEngine.UIX.Button _angleDecreaseButton;
public global::FrooxEngine.UIX.Button _heightIncreaseButton;
public global::FrooxEngine.UIX.Button _heightDecreaseButton;
public global::FrooxEngine.UIX.Button _distanceIncreaseButton;
public global::FrooxEngine.UIX.Button _distanceDecreaseButton;
public global::FrooxEngine.UIX.Button _resetButton;
public global::FrooxEngine.UIX.Slider<global::System.Single> _fovSlider;
public global::FrooxEngine.UIX.Checkbox _avoidOcclusion;
public global::FrooxEngine.UIX.Checkbox _keepInWorldSpace;
public global::FrooxEngine.UIX.Checkbox _movementWobble;
public global::FrooxEngine.UIX.Checkbox _aimInFrontOfHead;
public global::FrooxEngine.UIX.Checkbox _forceEyesOnCamera;
public global::FrooxEngine.UIX.Checkbox _hideCamera;
public global::FrooxEngine.UIX.Checkbox _hideBadge;
public global::FrooxEngine.UIX.Checkbox _hideLasers;
public global::FrooxEngine.UIX.Checkbox _showFrustum;
public global::FrooxEngine.UIX.Checkbox _timer;
public global::FrooxEngine.UIX.Checkbox _forceLive;
public global::FrooxEngine.UIX.Checkbox _audioFromCameraViewpoint;
public global::FrooxEngine.InteractiveCameraUserControl _userControl;
public global::FrooxEngine.InteractiveCameraControlSettings _settingsDialog;
public global::FrooxEngine.InteractiveCameraControlPositioning _positioningDialog;
public global::FrooxEngine.InteractiveCameraControlAnchors _anchorsDialog;
public global::FrooxEngine.InteractiveCameraOBS _OBS_Dialog;
public global::FrooxEngine.TwitchChatDialog _twitchDialog;
public global::FrooxEngine.UIX.Button _settingsButton;
public global::FrooxEngine.UIX.Button _positioningButton;
public global::FrooxEngine.UIX.Button _anchorsButton;
public global::FrooxEngine.UIX.Button _OBS_Button;
public global::FrooxEngine.UIX.Button _twitchButton;
public global::FrooxEngine.UI_UnlitMaterial _previewMaterial;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FieldOfView", FieldOfView.ToResoniteLinkField());
members.Add("AnglePosition", AnglePosition.ToResoniteLinkField());
members.Add("Distance", Distance.ToResoniteLinkField());
members.Add("HeightOffset", HeightOffset.ToResoniteLinkField());
members.Add("FirstPersonPitch", FirstPersonPitch.ToResoniteLinkField());
members.Add("FirstPersonRoll", FirstPersonRoll.ToResoniteLinkField());
members.Add("FirstPersonOffset", FirstPersonOffset.ToResoniteLinkField());
members.Add("FramingViewportPosition", FramingViewportPosition.ToResoniteLinkField());
members.Add("Mirror", Mirror.ToResoniteLinkField());
members.Add("GroupDetectionRadius", GroupDetectionRadius.ToResoniteLinkField());
members.Add("GroupLeaveBoundary", GroupLeaveBoundary.ToResoniteLinkField());
members.Add("PositionSmoothSpeed", PositionSmoothSpeed.ToResoniteLinkField());
members.Add("AngleSmoothSpeed", AngleSmoothSpeed.ToResoniteLinkField());
members.Add("FramingSmoothSpeed", FramingSmoothSpeed.ToResoniteLinkField());
members.Add("InterpolateBetweenAnchors", InterpolateBetweenAnchors.ToResoniteLinkField());
members.Add("AnchorInterpolationSpeed", AnchorInterpolationSpeed.ToResoniteLinkField());
members.Add("AnchorLinearInterpolation", AnchorLinearInterpolation.ToResoniteLinkField());
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("FramingTargetOverride", FramingTargetOverride.ToResoniteLinkField());
members.Add("CameraOperators", new ResoniteLink.SyncList()
{
    Elements = CameraOperators.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("GroupIncludeUsers", new ResoniteLink.SyncList()
{
    Elements = GroupIncludeUsers.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("GroupExcludeUsers", new ResoniteLink.SyncList()
{
    Elements = GroupExcludeUsers.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("RenderForEveryone", RenderForEveryone.ToResoniteLinkField());
members.Add("AnyoneCanInteract", AnyoneCanInteract.ToResoniteLinkField());
members.Add("RenderPrivateUI", RenderPrivateUI.ToResoniteLinkField());
members.Add("MotionBlur", MotionBlur.ToResoniteLinkField());
members.Add("ScreenSpaceReflections", ScreenSpaceReflections.ToResoniteLinkField());
members.Add("SpawnPhotoInWorld", SpawnPhotoInWorld.ToResoniteLinkField());
members.Add("FlipPreview", FlipPreview.ToResoniteLinkField());
members.Add("_renderTextureProxy", _renderTextureProxy.ToResoniteReference(context));
members.Add("_framingReticle", _framingReticle.ToResoniteReference(context));
members.Add("_mirrorMessage", _mirrorMessage.ToResoniteReference(context));
members.Add("_smoothFirstPersonButton", _smoothFirstPersonButton.ToResoniteReference(context));
members.Add("_thirdPersonButton", _thirdPersonButton.ToResoniteReference(context));
members.Add("_groupButton", _groupButton.ToResoniteReference(context));
members.Add("_worldButton", _worldButton.ToResoniteReference(context));
members.Add("_manualButton", _manualButton.ToResoniteReference(context));
members.Add("_mirrorButton", _mirrorButton.ToResoniteReference(context));
members.Add("_usersButton", _usersButton.ToResoniteReference(context));
members.Add("_angleIncreaseButton", _angleIncreaseButton.ToResoniteReference(context));
members.Add("_angleDecreaseButton", _angleDecreaseButton.ToResoniteReference(context));
members.Add("_heightIncreaseButton", _heightIncreaseButton.ToResoniteReference(context));
members.Add("_heightDecreaseButton", _heightDecreaseButton.ToResoniteReference(context));
members.Add("_distanceIncreaseButton", _distanceIncreaseButton.ToResoniteReference(context));
members.Add("_distanceDecreaseButton", _distanceDecreaseButton.ToResoniteReference(context));
members.Add("_resetButton", _resetButton.ToResoniteReference(context));
members.Add("_fovSlider", _fovSlider.ToResoniteReference(context));
members.Add("_avoidOcclusion", _avoidOcclusion.ToResoniteReference(context));
members.Add("_keepInWorldSpace", _keepInWorldSpace.ToResoniteReference(context));
members.Add("_movementWobble", _movementWobble.ToResoniteReference(context));
members.Add("_aimInFrontOfHead", _aimInFrontOfHead.ToResoniteReference(context));
members.Add("_forceEyesOnCamera", _forceEyesOnCamera.ToResoniteReference(context));
members.Add("_hideCamera", _hideCamera.ToResoniteReference(context));
members.Add("_hideBadge", _hideBadge.ToResoniteReference(context));
members.Add("_hideLasers", _hideLasers.ToResoniteReference(context));
members.Add("_showFrustum", _showFrustum.ToResoniteReference(context));
members.Add("_timer", _timer.ToResoniteReference(context));
members.Add("_forceLive", _forceLive.ToResoniteReference(context));
members.Add("_audioFromCameraViewpoint", _audioFromCameraViewpoint.ToResoniteReference(context));
members.Add("_userControl", _userControl.ToResoniteReference(context));
members.Add("_settingsDialog", _settingsDialog.ToResoniteReference(context));
members.Add("_positioningDialog", _positioningDialog.ToResoniteReference(context));
members.Add("_anchorsDialog", _anchorsDialog.ToResoniteReference(context));
members.Add("_OBS_Dialog", _OBS_Dialog.ToResoniteReference(context));
members.Add("_twitchDialog", _twitchDialog.ToResoniteReference(context));
members.Add("_settingsButton", _settingsButton.ToResoniteReference(context));
members.Add("_positioningButton", _positioningButton.ToResoniteReference(context));
members.Add("_anchorsButton", _anchorsButton.ToResoniteReference(context));
members.Add("_OBS_Button", _OBS_Button.ToResoniteReference(context));
members.Add("_twitchButton", _twitchButton.ToResoniteReference(context));
members.Add("_previewMaterial", _previewMaterial.ToResoniteReference(context));
}

}
}
