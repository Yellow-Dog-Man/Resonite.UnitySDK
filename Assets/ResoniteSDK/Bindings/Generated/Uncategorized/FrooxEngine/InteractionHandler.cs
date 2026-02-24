
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractionHandler
// Generated on: úterý 24. února 2026 18:19:56
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractionHandler")]
public partial class InteractionHandler : global::FrooxEngine.UserRootComponent, global::FrooxEngine.IVibrationDeviceComponent, global::FrooxEngine.ILocomotionReference, global::FrooxEngine.IInputUpdateReceiver, global::FrooxEngine.IHandTargetInfoSource

{
    public global::Renderite.Shared.Chirality Side;
public global::FrooxEngine.LocomotionController LocomotionController;
public global::System.Single GrabSmoothing;
public global::FrooxEngine.InteractionHandlerStreamDriver _streamDriver;
public global::FrooxEngine.ContextMenuItem _undoItem;
public global::FrooxEngine.ContextMenuItem _redoItem;
public global::FrooxEngine.ContextMenu ContextMenu;
public global::System.Boolean EquippingEnabled;
public global::System.Boolean MenuEnabled;
public global::System.Boolean UserScalingEnabled;
public global::System.Boolean VisualEnabled;
public global::System.Boolean PointingGrab;
public global::System.Boolean PointingTouch;
public global::FrooxEngine.Slot _toolRoot;
public global::FrooxEngine.Slot _laserSlot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _laserPosition;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _laserRotation;
public global::FrooxEngine.InteractionLaser _interactionLaser;
public global::System.Boolean _laserEnabled;
public global::FrooxEngine.InteractionHandler.HandGrabType _handGrabType;
public global::System.Boolean _grabToggle;
public global::FrooxEngine.IField<UnityEngine.Vector3> _holderPos;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _holderRot;
public global::FrooxEngine.InteractionHandler.LaserRotationType _laserRotationType;
public global::System.Single _holderAxisOffset;
public UnityEngine.Quaternion _holderRotationOffset;
public global::System.Nullable<UnityEngine.Quaternion> _holderRotationReference;
public global::System.Single _originalTwistOffset;
public global::FrooxEngine.RingMesh _userspaceToggleIndicator;
public global::FrooxEngine.Slot ToolHolder;
public global::System.Boolean ShowInteractionHints;
public global::FrooxEngine.IField<global::System.Boolean> _grabberSphereActive;
public global::FrooxEngine.Slot _grabIgnoreRoot;
public global::FrooxEngine.Grabber _grabber;
public global::FrooxEngine.InteractionHandler.GrabType _currentGrabType;
public global::FrooxEngine.LinkTarget<global::FrooxEngine.ITool> ActiveToolLink;
public global::FrooxEngine.GripPoseReference _activeToolGripPoseReference;
public global::System.Boolean _toolLocked;
public global::FrooxEngine.FresnelMaterial _grabMaterial;
public global::FrooxEngine.Slot _itemShelfSlot;
public global::FrooxEngine.ItemShelf _itemShelf;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Side", Side.ToResoniteLinkField());
members.Add("LocomotionController", LocomotionController.ToResoniteReference(context));
members.Add("GrabSmoothing", GrabSmoothing.ToResoniteLinkField());
members.Add("_streamDriver", _streamDriver.ToResoniteReference(context));
members.Add("_undoItem", _undoItem.ToResoniteReference(context));
members.Add("_redoItem", _redoItem.ToResoniteReference(context));
members.Add("ContextMenu", ContextMenu.ToResoniteReference(context));
members.Add("EquippingEnabled", EquippingEnabled.ToResoniteLinkField());
members.Add("MenuEnabled", MenuEnabled.ToResoniteLinkField());
members.Add("UserScalingEnabled", UserScalingEnabled.ToResoniteLinkField());
members.Add("VisualEnabled", VisualEnabled.ToResoniteLinkField());
members.Add("PointingGrab", PointingGrab.ToResoniteLinkField());
members.Add("PointingTouch", PointingTouch.ToResoniteLinkField());
members.Add("_toolRoot", _toolRoot.ToResoniteReference(context));
members.Add("_laserSlot", _laserSlot.ToResoniteReference(context));
members.Add("_laserPosition", _laserPosition.ToResoniteReference(context));
members.Add("_laserRotation", _laserRotation.ToResoniteReference(context));
members.Add("_interactionLaser", _interactionLaser.ToResoniteReference(context));
members.Add("_laserEnabled", _laserEnabled.ToResoniteLinkField());
members.Add("_handGrabType", _handGrabType.ToResoniteLinkField());
members.Add("_grabToggle", _grabToggle.ToResoniteLinkField());
members.Add("_holderPos", _holderPos.ToResoniteReference(context));
members.Add("_holderRot", _holderRot.ToResoniteReference(context));
members.Add("_laserRotationType", _laserRotationType.ToResoniteLinkField());
members.Add("_holderAxisOffset", _holderAxisOffset.ToResoniteLinkField());
members.Add("_holderRotationOffset", _holderRotationOffset.ToResoniteLinkField());
members.Add("_holderRotationReference", _holderRotationReference.ToResoniteLinkField());
members.Add("_originalTwistOffset", _originalTwistOffset.ToResoniteLinkField());
members.Add("_userspaceToggleIndicator", _userspaceToggleIndicator.ToResoniteReference(context));
members.Add("ToolHolder", ToolHolder.ToResoniteReference(context));
members.Add("ShowInteractionHints", ShowInteractionHints.ToResoniteLinkField());
members.Add("_grabberSphereActive", _grabberSphereActive.ToResoniteReference(context));
members.Add("_grabIgnoreRoot", _grabIgnoreRoot.ToResoniteReference(context));
members.Add("_grabber", _grabber.ToResoniteReference(context));
members.Add("_currentGrabType", _currentGrabType.ToResoniteLinkField());
members.Add("ActiveToolLink", ActiveToolLink.ToResoniteReference(context));
members.Add("_activeToolGripPoseReference", _activeToolGripPoseReference.ToResoniteReference(context));
members.Add("_toolLocked", _toolLocked.ToResoniteLinkField());
members.Add("_grabMaterial", _grabMaterial.ToResoniteReference(context));
members.Add("_itemShelfSlot", _itemShelfSlot.ToResoniteReference(context));
members.Add("_itemShelf", _itemShelf.ToResoniteReference(context));
}

}
}
