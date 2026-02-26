
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraControl
// Generated on: čtvrtek 26. února 2026 15:09:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraControl")]
public partial class InteractiveCameraControl : global::FrooxEngine.LegacyCanvasPanel

{
    public global::System.Single FieldOfView { get => FieldOfView_Element.Data; set => FieldOfView_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FieldOfView_Element = new();
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
public UnityEngine.Vector2 FramingViewportPosition { get => FramingViewportPosition_Element.Data; set => FramingViewportPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> FramingViewportPosition_Element = new();
public global::System.Boolean Mirror { get => Mirror_Element.Data; set => Mirror_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Mirror_Element = new();
public global::System.Single GroupDetectionRadius { get => GroupDetectionRadius_Element.Data; set => GroupDetectionRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GroupDetectionRadius_Element = new();
public global::System.Single GroupLeaveBoundary { get => GroupLeaveBoundary_Element.Data; set => GroupLeaveBoundary_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GroupLeaveBoundary_Element = new();
public global::System.Single PositionSmoothSpeed { get => PositionSmoothSpeed_Element.Data; set => PositionSmoothSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PositionSmoothSpeed_Element = new();
public global::System.Single AngleSmoothSpeed { get => AngleSmoothSpeed_Element.Data; set => AngleSmoothSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AngleSmoothSpeed_Element = new();
public global::System.Single FramingSmoothSpeed { get => FramingSmoothSpeed_Element.Data; set => FramingSmoothSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FramingSmoothSpeed_Element = new();
public global::System.Boolean InterpolateBetweenAnchors { get => InterpolateBetweenAnchors_Element.Data; set => InterpolateBetweenAnchors_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> InterpolateBetweenAnchors_Element = new();
public global::System.Single AnchorInterpolationSpeed { get => AnchorInterpolationSpeed_Element.Data; set => AnchorInterpolationSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AnchorInterpolationSpeed_Element = new();
public global::System.Boolean AnchorLinearInterpolation { get => AnchorLinearInterpolation_Element.Data; set => AnchorLinearInterpolation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AnchorLinearInterpolation_Element = new();
public global::FrooxEngine.CameraPositioningMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CameraPositioningMode>, global::FrooxEngine.CameraPositioningMode> Mode_Element = new();
public global::System.String FramingTargetOverride { get => FramingTargetOverride_Element.Data; set => FramingTargetOverride_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> FramingTargetOverride_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.String>, global::System.String, Field<global::FrooxEngine.Sync<global::System.String>, global::System.String>> CameraOperators = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.String>, global::System.String, Field<global::FrooxEngine.Sync<global::System.String>, global::System.String>> GroupIncludeUsers = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.String>, global::System.String, Field<global::FrooxEngine.Sync<global::System.String>, global::System.String>> GroupExcludeUsers = new();
public global::System.Boolean RenderForEveryone { get => RenderForEveryone_Element.Data; set => RenderForEveryone_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RenderForEveryone_Element = new();
public global::System.Boolean AnyoneCanInteract { get => AnyoneCanInteract_Element.Data; set => AnyoneCanInteract_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AnyoneCanInteract_Element = new();
public global::System.Boolean RenderPrivateUI { get => RenderPrivateUI_Element.Data; set => RenderPrivateUI_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RenderPrivateUI_Element = new();
public global::System.Boolean MotionBlur { get => MotionBlur_Element.Data; set => MotionBlur_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MotionBlur_Element = new();
public global::System.Boolean ScreenSpaceReflections { get => ScreenSpaceReflections_Element.Data; set => ScreenSpaceReflections_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ScreenSpaceReflections_Element = new();
public global::System.Boolean SpawnPhotoInWorld { get => SpawnPhotoInWorld_Element.Data; set => SpawnPhotoInWorld_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SpawnPhotoInWorld_Element = new();
public global::System.Boolean FlipPreview { get => FlipPreview_Element.Data; set => FlipPreview_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FlipPreview_Element = new();
public global::FrooxEngine.RenderTextureProxyProvider _renderTextureProxy { get => _renderTextureProxy_Element.Data; set => _renderTextureProxy_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.RenderTextureProxyProvider>, global::FrooxEngine.RenderTextureProxyProvider> _renderTextureProxy_Element = new();
public global::FrooxEngine.UIX.RectTransform _framingReticle { get => _framingReticle_Element.Data; set => _framingReticle_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> _framingReticle_Element = new();
public global::FrooxEngine.UIX.RectTransform _mirrorMessage { get => _mirrorMessage_Element.Data; set => _mirrorMessage_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> _mirrorMessage_Element = new();
public global::FrooxEngine.UIX.Button _smoothFirstPersonButton { get => _smoothFirstPersonButton_Element.Data; set => _smoothFirstPersonButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _smoothFirstPersonButton_Element = new();
public global::FrooxEngine.UIX.Button _thirdPersonButton { get => _thirdPersonButton_Element.Data; set => _thirdPersonButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _thirdPersonButton_Element = new();
public global::FrooxEngine.UIX.Button _groupButton { get => _groupButton_Element.Data; set => _groupButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _groupButton_Element = new();
public global::FrooxEngine.UIX.Button _worldButton { get => _worldButton_Element.Data; set => _worldButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _worldButton_Element = new();
public global::FrooxEngine.UIX.Button _manualButton { get => _manualButton_Element.Data; set => _manualButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _manualButton_Element = new();
public global::FrooxEngine.UIX.Button _mirrorButton { get => _mirrorButton_Element.Data; set => _mirrorButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _mirrorButton_Element = new();
public global::FrooxEngine.UIX.Button _usersButton { get => _usersButton_Element.Data; set => _usersButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _usersButton_Element = new();
public global::FrooxEngine.UIX.Button _angleIncreaseButton { get => _angleIncreaseButton_Element.Data; set => _angleIncreaseButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _angleIncreaseButton_Element = new();
public global::FrooxEngine.UIX.Button _angleDecreaseButton { get => _angleDecreaseButton_Element.Data; set => _angleDecreaseButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _angleDecreaseButton_Element = new();
public global::FrooxEngine.UIX.Button _heightIncreaseButton { get => _heightIncreaseButton_Element.Data; set => _heightIncreaseButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _heightIncreaseButton_Element = new();
public global::FrooxEngine.UIX.Button _heightDecreaseButton { get => _heightDecreaseButton_Element.Data; set => _heightDecreaseButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _heightDecreaseButton_Element = new();
public global::FrooxEngine.UIX.Button _distanceIncreaseButton { get => _distanceIncreaseButton_Element.Data; set => _distanceIncreaseButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _distanceIncreaseButton_Element = new();
public global::FrooxEngine.UIX.Button _distanceDecreaseButton { get => _distanceDecreaseButton_Element.Data; set => _distanceDecreaseButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _distanceDecreaseButton_Element = new();
public global::FrooxEngine.UIX.Button _resetButton { get => _resetButton_Element.Data; set => _resetButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _resetButton_Element = new();
public global::FrooxEngine.UIX.Slider<global::System.Single> _fovSlider { get => _fovSlider_Element.Data; set => _fovSlider_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Slider<global::System.Single>>, global::FrooxEngine.UIX.Slider<global::System.Single>> _fovSlider_Element = new();
public global::FrooxEngine.UIX.Checkbox _avoidOcclusion { get => _avoidOcclusion_Element.Data; set => _avoidOcclusion_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _avoidOcclusion_Element = new();
public global::FrooxEngine.UIX.Checkbox _keepInWorldSpace { get => _keepInWorldSpace_Element.Data; set => _keepInWorldSpace_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _keepInWorldSpace_Element = new();
public global::FrooxEngine.UIX.Checkbox _movementWobble { get => _movementWobble_Element.Data; set => _movementWobble_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _movementWobble_Element = new();
public global::FrooxEngine.UIX.Checkbox _aimInFrontOfHead { get => _aimInFrontOfHead_Element.Data; set => _aimInFrontOfHead_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _aimInFrontOfHead_Element = new();
public global::FrooxEngine.UIX.Checkbox _forceEyesOnCamera { get => _forceEyesOnCamera_Element.Data; set => _forceEyesOnCamera_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _forceEyesOnCamera_Element = new();
public global::FrooxEngine.UIX.Checkbox _hideCamera { get => _hideCamera_Element.Data; set => _hideCamera_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _hideCamera_Element = new();
public global::FrooxEngine.UIX.Checkbox _hideBadge { get => _hideBadge_Element.Data; set => _hideBadge_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _hideBadge_Element = new();
public global::FrooxEngine.UIX.Checkbox _hideLasers { get => _hideLasers_Element.Data; set => _hideLasers_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _hideLasers_Element = new();
public global::FrooxEngine.UIX.Checkbox _showFrustum { get => _showFrustum_Element.Data; set => _showFrustum_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _showFrustum_Element = new();
public global::FrooxEngine.UIX.Checkbox _timer { get => _timer_Element.Data; set => _timer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _timer_Element = new();
public global::FrooxEngine.UIX.Checkbox _forceLive { get => _forceLive_Element.Data; set => _forceLive_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _forceLive_Element = new();
public global::FrooxEngine.UIX.Checkbox _audioFromCameraViewpoint { get => _audioFromCameraViewpoint_Element.Data; set => _audioFromCameraViewpoint_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _audioFromCameraViewpoint_Element = new();
public global::FrooxEngine.InteractiveCameraUserControl _userControl { get => _userControl_Element.Data; set => _userControl_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.InteractiveCameraUserControl>, global::FrooxEngine.InteractiveCameraUserControl> _userControl_Element = new();
public global::FrooxEngine.InteractiveCameraControlSettings _settingsDialog { get => _settingsDialog_Element.Data; set => _settingsDialog_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.InteractiveCameraControlSettings>, global::FrooxEngine.InteractiveCameraControlSettings> _settingsDialog_Element = new();
public global::FrooxEngine.InteractiveCameraControlPositioning _positioningDialog { get => _positioningDialog_Element.Data; set => _positioningDialog_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.InteractiveCameraControlPositioning>, global::FrooxEngine.InteractiveCameraControlPositioning> _positioningDialog_Element = new();
public global::FrooxEngine.InteractiveCameraControlAnchors _anchorsDialog { get => _anchorsDialog_Element.Data; set => _anchorsDialog_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.InteractiveCameraControlAnchors>, global::FrooxEngine.InteractiveCameraControlAnchors> _anchorsDialog_Element = new();
public global::FrooxEngine.InteractiveCameraOBS _OBS_Dialog { get => _OBS_Dialog_Element.Data; set => _OBS_Dialog_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.InteractiveCameraOBS>, global::FrooxEngine.InteractiveCameraOBS> _OBS_Dialog_Element = new();
public global::FrooxEngine.TwitchChatDialog _twitchDialog { get => _twitchDialog_Element.Data; set => _twitchDialog_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TwitchChatDialog>, global::FrooxEngine.TwitchChatDialog> _twitchDialog_Element = new();
public global::FrooxEngine.UIX.Button _settingsButton { get => _settingsButton_Element.Data; set => _settingsButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _settingsButton_Element = new();
public global::FrooxEngine.UIX.Button _positioningButton { get => _positioningButton_Element.Data; set => _positioningButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _positioningButton_Element = new();
public global::FrooxEngine.UIX.Button _anchorsButton { get => _anchorsButton_Element.Data; set => _anchorsButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _anchorsButton_Element = new();
public global::FrooxEngine.UIX.Button _OBS_Button { get => _OBS_Button_Element.Data; set => _OBS_Button_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _OBS_Button_Element = new();
public global::FrooxEngine.UIX.Button _twitchButton { get => _twitchButton_Element.Data; set => _twitchButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _twitchButton_Element = new();
public global::FrooxEngine.UI_UnlitMaterial _previewMaterial { get => _previewMaterial_Element.Data; set => _previewMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UI_UnlitMaterial>, global::FrooxEngine.UI_UnlitMaterial> _previewMaterial_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FieldOfView", FieldOfView_Element.ToLinkField(context));
members.Add("AnglePosition", AnglePosition_Element.ToLinkField(context));
members.Add("Distance", Distance_Element.ToLinkField(context));
members.Add("HeightOffset", HeightOffset_Element.ToLinkField(context));
members.Add("FirstPersonPitch", FirstPersonPitch_Element.ToLinkField(context));
members.Add("FirstPersonRoll", FirstPersonRoll_Element.ToLinkField(context));
members.Add("FirstPersonOffset", FirstPersonOffset_Element.ToLinkField(context));
members.Add("FramingViewportPosition", FramingViewportPosition_Element.ToLinkField(context));
members.Add("Mirror", Mirror_Element.ToLinkField(context));
members.Add("GroupDetectionRadius", GroupDetectionRadius_Element.ToLinkField(context));
members.Add("GroupLeaveBoundary", GroupLeaveBoundary_Element.ToLinkField(context));
members.Add("PositionSmoothSpeed", PositionSmoothSpeed_Element.ToLinkField(context));
members.Add("AngleSmoothSpeed", AngleSmoothSpeed_Element.ToLinkField(context));
members.Add("FramingSmoothSpeed", FramingSmoothSpeed_Element.ToLinkField(context));
members.Add("InterpolateBetweenAnchors", InterpolateBetweenAnchors_Element.ToLinkField(context));
members.Add("AnchorInterpolationSpeed", AnchorInterpolationSpeed_Element.ToLinkField(context));
members.Add("AnchorLinearInterpolation", AnchorLinearInterpolation_Element.ToLinkField(context));
members.Add("Mode", Mode_Element.ToLinkField(context));
members.Add("FramingTargetOverride", FramingTargetOverride_Element.ToLinkField(context));
members.Add("CameraOperators", CameraOperators.ToLinkList(context, m => m.ToLinkField(context)));
members.Add("GroupIncludeUsers", GroupIncludeUsers.ToLinkList(context, m => m.ToLinkField(context)));
members.Add("GroupExcludeUsers", GroupExcludeUsers.ToLinkList(context, m => m.ToLinkField(context)));
members.Add("RenderForEveryone", RenderForEveryone_Element.ToLinkField(context));
members.Add("AnyoneCanInteract", AnyoneCanInteract_Element.ToLinkField(context));
members.Add("RenderPrivateUI", RenderPrivateUI_Element.ToLinkField(context));
members.Add("MotionBlur", MotionBlur_Element.ToLinkField(context));
members.Add("ScreenSpaceReflections", ScreenSpaceReflections_Element.ToLinkField(context));
members.Add("SpawnPhotoInWorld", SpawnPhotoInWorld_Element.ToLinkField(context));
members.Add("FlipPreview", FlipPreview_Element.ToLinkField(context));
members.Add("_renderTextureProxy", _renderTextureProxy_Element.ToLinkReference(context));
members.Add("_framingReticle", _framingReticle_Element.ToLinkReference(context));
members.Add("_mirrorMessage", _mirrorMessage_Element.ToLinkReference(context));
members.Add("_smoothFirstPersonButton", _smoothFirstPersonButton_Element.ToLinkReference(context));
members.Add("_thirdPersonButton", _thirdPersonButton_Element.ToLinkReference(context));
members.Add("_groupButton", _groupButton_Element.ToLinkReference(context));
members.Add("_worldButton", _worldButton_Element.ToLinkReference(context));
members.Add("_manualButton", _manualButton_Element.ToLinkReference(context));
members.Add("_mirrorButton", _mirrorButton_Element.ToLinkReference(context));
members.Add("_usersButton", _usersButton_Element.ToLinkReference(context));
members.Add("_angleIncreaseButton", _angleIncreaseButton_Element.ToLinkReference(context));
members.Add("_angleDecreaseButton", _angleDecreaseButton_Element.ToLinkReference(context));
members.Add("_heightIncreaseButton", _heightIncreaseButton_Element.ToLinkReference(context));
members.Add("_heightDecreaseButton", _heightDecreaseButton_Element.ToLinkReference(context));
members.Add("_distanceIncreaseButton", _distanceIncreaseButton_Element.ToLinkReference(context));
members.Add("_distanceDecreaseButton", _distanceDecreaseButton_Element.ToLinkReference(context));
members.Add("_resetButton", _resetButton_Element.ToLinkReference(context));
members.Add("_fovSlider", _fovSlider_Element.ToLinkReference(context));
members.Add("_avoidOcclusion", _avoidOcclusion_Element.ToLinkReference(context));
members.Add("_keepInWorldSpace", _keepInWorldSpace_Element.ToLinkReference(context));
members.Add("_movementWobble", _movementWobble_Element.ToLinkReference(context));
members.Add("_aimInFrontOfHead", _aimInFrontOfHead_Element.ToLinkReference(context));
members.Add("_forceEyesOnCamera", _forceEyesOnCamera_Element.ToLinkReference(context));
members.Add("_hideCamera", _hideCamera_Element.ToLinkReference(context));
members.Add("_hideBadge", _hideBadge_Element.ToLinkReference(context));
members.Add("_hideLasers", _hideLasers_Element.ToLinkReference(context));
members.Add("_showFrustum", _showFrustum_Element.ToLinkReference(context));
members.Add("_timer", _timer_Element.ToLinkReference(context));
members.Add("_forceLive", _forceLive_Element.ToLinkReference(context));
members.Add("_audioFromCameraViewpoint", _audioFromCameraViewpoint_Element.ToLinkReference(context));
members.Add("_userControl", _userControl_Element.ToLinkReference(context));
members.Add("_settingsDialog", _settingsDialog_Element.ToLinkReference(context));
members.Add("_positioningDialog", _positioningDialog_Element.ToLinkReference(context));
members.Add("_anchorsDialog", _anchorsDialog_Element.ToLinkReference(context));
members.Add("_OBS_Dialog", _OBS_Dialog_Element.ToLinkReference(context));
members.Add("_twitchDialog", _twitchDialog_Element.ToLinkReference(context));
members.Add("_settingsButton", _settingsButton_Element.ToLinkReference(context));
members.Add("_positioningButton", _positioningButton_Element.ToLinkReference(context));
members.Add("_anchorsButton", _anchorsButton_Element.ToLinkReference(context));
members.Add("_OBS_Button", _OBS_Button_Element.ToLinkReference(context));
members.Add("_twitchButton", _twitchButton_Element.ToLinkReference(context));
members.Add("_previewMaterial", _previewMaterial_Element.ToLinkReference(context));
}

}
}
