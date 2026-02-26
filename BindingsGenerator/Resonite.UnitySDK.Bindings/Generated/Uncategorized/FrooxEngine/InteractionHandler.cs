
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractionHandler
// Generated on: čtvrtek 26. února 2026 12:27:57
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::Renderite.Shared.Chirality Side { get => Side_Element.Data; set => Side_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.Chirality>, global::Renderite.Shared.Chirality> Side_Element = new();
public global::FrooxEngine.LocomotionController LocomotionController { get => LocomotionController_Element.Data; set => LocomotionController_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.LocomotionController>, global::FrooxEngine.LocomotionController> LocomotionController_Element = new();
public global::System.Single GrabSmoothing { get => GrabSmoothing_Element.Data; set => GrabSmoothing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GrabSmoothing_Element = new();
public global::FrooxEngine.InteractionHandlerStreamDriver _streamDriver { get => _streamDriver_Element.Data; set => _streamDriver_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.InteractionHandlerStreamDriver>, global::FrooxEngine.InteractionHandlerStreamDriver> _streamDriver_Element = new();
public global::FrooxEngine.ContextMenuItem _undoItem { get => _undoItem_Element.Data; set => _undoItem_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ContextMenuItem>, global::FrooxEngine.ContextMenuItem> _undoItem_Element = new();
public global::FrooxEngine.ContextMenuItem _redoItem { get => _redoItem_Element.Data; set => _redoItem_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ContextMenuItem>, global::FrooxEngine.ContextMenuItem> _redoItem_Element = new();
public global::FrooxEngine.ContextMenu ContextMenu { get => ContextMenu_Element.Data; set => ContextMenu_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ContextMenu>, global::FrooxEngine.ContextMenu> ContextMenu_Element = new();
public global::System.Boolean EquippingEnabled { get => EquippingEnabled_Element.Data; set => EquippingEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EquippingEnabled_Element = new();
public global::System.Boolean MenuEnabled { get => MenuEnabled_Element.Data; set => MenuEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MenuEnabled_Element = new();
public global::System.Boolean UserScalingEnabled { get => UserScalingEnabled_Element.Data; set => UserScalingEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UserScalingEnabled_Element = new();
public global::System.Boolean VisualEnabled { get => VisualEnabled_Element.Data; set => VisualEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> VisualEnabled_Element = new();
public global::System.Boolean PointingGrab { get => PointingGrab_Element.Data; set => PointingGrab_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PointingGrab_Element = new();
public global::System.Boolean PointingTouch { get => PointingTouch_Element.Data; set => PointingTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PointingTouch_Element = new();
public global::FrooxEngine.Slot _toolRoot { get => _toolRoot_Element.Data; set => _toolRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _toolRoot_Element = new();
public global::FrooxEngine.Slot _laserSlot { get => _laserSlot_Element.Data; set => _laserSlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _laserSlot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _laserPosition { get => _laserPosition_Element.Data; set => _laserPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _laserPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _laserRotation { get => _laserRotation_Element.Data; set => _laserRotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _laserRotation_Element = new();
public global::FrooxEngine.InteractionLaser _interactionLaser { get => _interactionLaser_Element.Data; set => _interactionLaser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.InteractionLaser>, global::FrooxEngine.InteractionLaser> _interactionLaser_Element = new();
public global::System.Boolean _laserEnabled { get => _laserEnabled_Element.Data; set => _laserEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _laserEnabled_Element = new();
public global::FrooxEngine.InteractionHandler.HandGrabType _handGrabType { get => _handGrabType_Element.Data; set => _handGrabType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.InteractionHandler.HandGrabType>, global::FrooxEngine.InteractionHandler.HandGrabType> _handGrabType_Element = new();
public global::System.Boolean _grabToggle { get => _grabToggle_Element.Data; set => _grabToggle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _grabToggle_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _holderPos { get => _holderPos_Element.Data; set => _holderPos_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _holderPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _holderRot { get => _holderRot_Element.Data; set => _holderRot_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _holderRot_Element = new();
public global::FrooxEngine.InteractionHandler.LaserRotationType _laserRotationType { get => _laserRotationType_Element.Data; set => _laserRotationType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.InteractionHandler.LaserRotationType>, global::FrooxEngine.InteractionHandler.LaserRotationType> _laserRotationType_Element = new();
public global::System.Single _holderAxisOffset { get => _holderAxisOffset_Element.Data; set => _holderAxisOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _holderAxisOffset_Element = new();
public UnityEngine.Quaternion _holderRotationOffset { get => _holderRotationOffset_Element.Data; set => _holderRotationOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> _holderRotationOffset_Element = new();
public global::System.Nullable<UnityEngine.Quaternion> _holderRotationReference { get => _holderRotationReference_Element.Data; set => _holderRotationReference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Quaternion>>, global::System.Nullable<UnityEngine.Quaternion>> _holderRotationReference_Element = new();
public global::System.Single _originalTwistOffset { get => _originalTwistOffset_Element.Data; set => _originalTwistOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _originalTwistOffset_Element = new();
public global::FrooxEngine.RingMesh _userspaceToggleIndicator { get => _userspaceToggleIndicator_Element.Data; set => _userspaceToggleIndicator_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.RingMesh>, global::FrooxEngine.RingMesh> _userspaceToggleIndicator_Element = new();
public global::FrooxEngine.Slot ToolHolder { get => ToolHolder_Element.Data; set => ToolHolder_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ToolHolder_Element = new();
public global::System.Boolean ShowInteractionHints { get => ShowInteractionHints_Element.Data; set => ShowInteractionHints_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowInteractionHints_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _grabberSphereActive { get => _grabberSphereActive_Element.Data; set => _grabberSphereActive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _grabberSphereActive_Element = new();
public global::FrooxEngine.Slot _grabIgnoreRoot { get => _grabIgnoreRoot_Element.Data; set => _grabIgnoreRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _grabIgnoreRoot_Element = new();
public global::FrooxEngine.Grabber _grabber { get => _grabber_Element.Data; set => _grabber_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Grabber>, global::FrooxEngine.Grabber> _grabber_Element = new();
public global::FrooxEngine.InteractionHandler.GrabType _currentGrabType { get => _currentGrabType_Element.Data; set => _currentGrabType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.InteractionHandler.GrabType>, global::FrooxEngine.InteractionHandler.GrabType> _currentGrabType_Element = new();
public global::FrooxEngine.LinkTarget<global::FrooxEngine.ITool> ActiveToolLink { get => ActiveToolLink_Element.Data; set => ActiveToolLink_Element.Data = value; }
public Field<global::FrooxEngine.LinkTargetRef<global::FrooxEngine.ITool>, global::FrooxEngine.LinkTarget<global::FrooxEngine.ITool>> ActiveToolLink_Element = new();
public global::FrooxEngine.GripPoseReference _activeToolGripPoseReference { get => _activeToolGripPoseReference_Element.Data; set => _activeToolGripPoseReference_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.GripPoseReference>, global::FrooxEngine.GripPoseReference> _activeToolGripPoseReference_Element = new();
public global::System.Boolean _toolLocked { get => _toolLocked_Element.Data; set => _toolLocked_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _toolLocked_Element = new();
public global::FrooxEngine.FresnelMaterial _grabMaterial { get => _grabMaterial_Element.Data; set => _grabMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.FresnelMaterial>, global::FrooxEngine.FresnelMaterial> _grabMaterial_Element = new();
public global::FrooxEngine.Slot _itemShelfSlot { get => _itemShelfSlot_Element.Data; set => _itemShelfSlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _itemShelfSlot_Element = new();
public global::FrooxEngine.ItemShelf _itemShelf { get => _itemShelf_Element.Data; set => _itemShelf_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ItemShelf>, global::FrooxEngine.ItemShelf> _itemShelf_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Side", Side_Element.ToLinkField(context));
members.Add("LocomotionController", LocomotionController_Element.ToLinkReference(context));
members.Add("GrabSmoothing", GrabSmoothing_Element.ToLinkField(context));
members.Add("_streamDriver", _streamDriver_Element.ToLinkReference(context));
members.Add("_undoItem", _undoItem_Element.ToLinkReference(context));
members.Add("_redoItem", _redoItem_Element.ToLinkReference(context));
members.Add("ContextMenu", ContextMenu_Element.ToLinkReference(context));
members.Add("EquippingEnabled", EquippingEnabled_Element.ToLinkField(context));
members.Add("MenuEnabled", MenuEnabled_Element.ToLinkField(context));
members.Add("UserScalingEnabled", UserScalingEnabled_Element.ToLinkField(context));
members.Add("VisualEnabled", VisualEnabled_Element.ToLinkField(context));
members.Add("PointingGrab", PointingGrab_Element.ToLinkField(context));
members.Add("PointingTouch", PointingTouch_Element.ToLinkField(context));
members.Add("_toolRoot", _toolRoot_Element.ToLinkReference(context));
members.Add("_laserSlot", _laserSlot_Element.ToLinkReference(context));
members.Add("_laserPosition", _laserPosition_Element.ToLinkReference(context));
members.Add("_laserRotation", _laserRotation_Element.ToLinkReference(context));
members.Add("_interactionLaser", _interactionLaser_Element.ToLinkReference(context));
members.Add("_laserEnabled", _laserEnabled_Element.ToLinkField(context));
members.Add("_handGrabType", _handGrabType_Element.ToLinkField(context));
members.Add("_grabToggle", _grabToggle_Element.ToLinkField(context));
members.Add("_holderPos", _holderPos_Element.ToLinkReference(context));
members.Add("_holderRot", _holderRot_Element.ToLinkReference(context));
members.Add("_laserRotationType", _laserRotationType_Element.ToLinkField(context));
members.Add("_holderAxisOffset", _holderAxisOffset_Element.ToLinkField(context));
members.Add("_holderRotationOffset", _holderRotationOffset_Element.ToLinkField(context));
members.Add("_holderRotationReference", _holderRotationReference_Element.ToLinkField(context));
members.Add("_originalTwistOffset", _originalTwistOffset_Element.ToLinkField(context));
members.Add("_userspaceToggleIndicator", _userspaceToggleIndicator_Element.ToLinkReference(context));
members.Add("ToolHolder", ToolHolder_Element.ToLinkReference(context));
members.Add("ShowInteractionHints", ShowInteractionHints_Element.ToLinkField(context));
members.Add("_grabberSphereActive", _grabberSphereActive_Element.ToLinkReference(context));
members.Add("_grabIgnoreRoot", _grabIgnoreRoot_Element.ToLinkReference(context));
members.Add("_grabber", _grabber_Element.ToLinkReference(context));
members.Add("_currentGrabType", _currentGrabType_Element.ToLinkField(context));
members.Add("ActiveToolLink", ActiveToolLink_Element.ToLinkReference(context));
members.Add("_activeToolGripPoseReference", _activeToolGripPoseReference_Element.ToLinkReference(context));
members.Add("_toolLocked", _toolLocked_Element.ToLinkField(context));
members.Add("_grabMaterial", _grabMaterial_Element.ToLinkReference(context));
members.Add("_itemShelfSlot", _itemShelfSlot_Element.ToLinkReference(context));
members.Add("_itemShelf", _itemShelf_Element.ToLinkReference(context));
}

}
}
