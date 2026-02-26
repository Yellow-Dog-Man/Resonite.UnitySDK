
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractionLaser
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractionLaser")]
public partial class InteractionLaser : global::FrooxEngine.UserRootComponent

{
    public global::System.Single SmoothSpeed { get => SmoothSpeed_Element.Data; set => SmoothSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SmoothSpeed_Element = new();
public global::System.Single SmoothModulateStartAngle { get => SmoothModulateStartAngle_Element.Data; set => SmoothModulateStartAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SmoothModulateStartAngle_Element = new();
public global::System.Single SmoothModulateEndAngle { get => SmoothModulateEndAngle_Element.Data; set => SmoothModulateEndAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SmoothModulateEndAngle_Element = new();
public global::System.Single SmoothModulateExp { get => SmoothModulateExp_Element.Data; set => SmoothModulateExp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SmoothModulateExp_Element = new();
public global::System.Single SmoothModulateMultiplier { get => SmoothModulateMultiplier_Element.Data; set => SmoothModulateMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SmoothModulateMultiplier_Element = new();
public global::System.Single StickThreshold { get => StickThreshold_Element.Data; set => StickThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StickThreshold_Element = new();
public global::System.Boolean ShowInDesktop { get => ShowInDesktop_Element.Data; set => ShowInDesktop_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowInDesktop_Element = new();
public global::System.Single MaxTouchPenetrationDistance { get => MaxTouchPenetrationDistance_Element.Data; set => MaxTouchPenetrationDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxTouchPenetrationDistance_Element = new();
public global::FrooxEngine.Slot StickPointSpace { get => StickPointSpace_Element.Data; set => StickPointSpace_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> StickPointSpace_Element = new();
public UnityEngine.Vector3 StickPointPosition { get => StickPointPosition_Element.Data; set => StickPointPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> StickPointPosition_Element = new();
public global::FrooxEngine.InteractionHandler _handler { get => _handler_Element.Data; set => _handler_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.InteractionHandler>, global::FrooxEngine.InteractionHandler> _handler_Element = new();
public global::FrooxEngine.Slot _lastHit { get => _lastHit_Element.Data; set => _lastHit_Element.Data = value; }
public Field<global::FrooxEngine.AutoSyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _lastHit_Element = new();
public global::FrooxEngine.IInteractionTarget _lastInteractionTarget { get => _lastInteractionTarget_Element.Data; set => _lastInteractionTarget_Element.Data = value; }
public Field<global::FrooxEngine.AutoSyncRef<global::FrooxEngine.IInteractionTarget>, global::FrooxEngine.IInteractionTarget> _lastInteractionTarget_Element = new();
public global::FrooxEngine.ILaserInteractionModifier _lastInteractionModifier { get => _lastInteractionModifier_Element.Data; set => _lastInteractionModifier_Element.Data = value; }
public Field<global::FrooxEngine.AutoSyncRef<global::FrooxEngine.ILaserInteractionModifier>, global::FrooxEngine.ILaserInteractionModifier> _lastInteractionModifier_Element = new();
public UnityEngine.ColorX _hitColor { get => _hitColor_Element.Data; set => _hitColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> _hitColor_Element = new();
public global::System.Single _laserTextureSpeed { get => _laserTextureSpeed_Element.Data; set => _laserTextureSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _laserTextureSpeed_Element = new();
public global::FrooxEngine.RelayTouchSource _touchSource { get => _touchSource_Element.Data; set => _touchSource_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.RelayTouchSource>, global::FrooxEngine.RelayTouchSource> _touchSource_Element = new();
public global::FrooxEngine.BentTubeMesh _laserMesh { get => _laserMesh_Element.Data; set => _laserMesh_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.BentTubeMesh>, global::FrooxEngine.BentTubeMesh> _laserMesh_Element = new();
public global::FrooxEngine.OverlayUnlitMaterial _laserMaterial { get => _laserMaterial_Element.Data; set => _laserMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.OverlayUnlitMaterial>, global::FrooxEngine.OverlayUnlitMaterial> _laserMaterial_Element = new();
public global::FrooxEngine.StaticTexture2D _laserTexture { get => _laserTexture_Element.Data; set => _laserTexture_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.StaticTexture2D>, global::FrooxEngine.StaticTexture2D> _laserTexture_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _behindLaserTint { get => _behindLaserTint_Element.Data; set => _behindLaserTint_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _behindLaserTint_Element = new();
public global::FrooxEngine.IField<global::System.Int32> _laserRenderQueue { get => _laserRenderQueue_Element.Data; set => _laserRenderQueue_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Int32>, global::FrooxEngine.IField<global::System.Int32>> _laserRenderQueue_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _laserFrontTextureOffset { get => _laserFrontTextureOffset_Element.Data; set => _laserFrontTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _laserFrontTextureOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _laserBehindTextureOffset { get => _laserBehindTextureOffset_Element.Data; set => _laserBehindTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _laserBehindTextureOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _directPoint { get => _directPoint_Element.Data; set => _directPoint_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _directPoint_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _actualPoint { get => _actualPoint_Element.Data; set => _actualPoint_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _actualPoint_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _startColor { get => _startColor_Element.Data; set => _startColor_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _startColor_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _endColor { get => _endColor_Element.Data; set => _endColor_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _endColor_Element = new();
public global::FrooxEngine.Slot _pointSlot { get => _pointSlot_Element.Data; set => _pointSlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _pointSlot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _pointSlotPos { get => _pointSlotPos_Element.Data; set => _pointSlotPos_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _pointSlotPos_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _laserVisible { get => _laserVisible_Element.Data; set => _laserVisible_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _laserVisible_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _cursorVisible { get => _cursorVisible_Element.Data; set => _cursorVisible_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _cursorVisible_Element = new();
public global::FrooxEngine.Slot _cursorRoot { get => _cursorRoot_Element.Data; set => _cursorRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _cursorRoot_Element = new();
public global::FrooxEngine.Slot _cursorImageRoot { get => _cursorImageRoot_Element.Data; set => _cursorImageRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _cursorImageRoot_Element = new();
public global::FrooxEngine.StaticTexture2D _cursorTexture { get => _cursorTexture_Element.Data; set => _cursorTexture_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.StaticTexture2D>, global::FrooxEngine.StaticTexture2D> _cursorTexture_Element = new();
public global::FrooxEngine.OverlayUnlitMaterial _cursorMaterial { get => _cursorMaterial_Element.Data; set => _cursorMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.OverlayUnlitMaterial>, global::FrooxEngine.OverlayUnlitMaterial> _cursorMaterial_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _cursorFrontTint { get => _cursorFrontTint_Element.Data; set => _cursorFrontTint_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _cursorFrontTint_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _cursorBehindTint { get => _cursorBehindTint_Element.Data; set => _cursorBehindTint_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _cursorBehindTint_Element = new();
public global::FrooxEngine.IField<global::System.Int32> _cursorRenderQueue { get => _cursorRenderQueue_Element.Data; set => _cursorRenderQueue_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Int32>, global::FrooxEngine.IField<global::System.Int32>> _cursorRenderQueue_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _cursorOrientation { get => _cursorOrientation_Element.Data; set => _cursorOrientation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _cursorOrientation_Element = new();
public UnityEngine.ColorX _cursorTint { get => _cursorTint_Element.Data; set => _cursorTint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> _cursorTint_Element = new();
public global::System.Boolean _directCursorVisualsVisible { get => _directCursorVisualsVisible_Element.Data; set => _directCursorVisualsVisible_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _directCursorVisualsVisible_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _directCursorActive { get => _directCursorActive_Element.Data; set => _directCursorActive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _directCursorActive_Element = new();
public global::FrooxEngine.Slot _directCursorRoot { get => _directCursorRoot_Element.Data; set => _directCursorRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _directCursorRoot_Element = new();
public global::FrooxEngine.Slot _directCursorImageRoot { get => _directCursorImageRoot_Element.Data; set => _directCursorImageRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _directCursorImageRoot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _directCursorOffset { get => _directCursorOffset_Element.Data; set => _directCursorOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _directCursorOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _directCursorOrientation { get => _directCursorOrientation_Element.Data; set => _directCursorOrientation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _directCursorOrientation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _directLineTarget { get => _directLineTarget_Element.Data; set => _directLineTarget_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _directLineTarget_Element = new();
public global::FrooxEngine.SegmentMesh _directLineMesh { get => _directLineMesh_Element.Data; set => _directLineMesh_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SegmentMesh>, global::FrooxEngine.SegmentMesh> _directLineMesh_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _segmentColorFront { get => _segmentColorFront_Element.Data; set => _segmentColorFront_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _segmentColorFront_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _segmentColorBehind { get => _segmentColorBehind_Element.Data; set => _segmentColorBehind_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _segmentColorBehind_Element = new();
public global::FrooxEngine.IField<global::System.Int32> _segmentRenderQueue { get => _segmentRenderQueue_Element.Data; set => _segmentRenderQueue_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Int32>, global::FrooxEngine.IField<global::System.Int32>> _segmentRenderQueue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SmoothSpeed", SmoothSpeed_Element.ToLinkField(context));
members.Add("SmoothModulateStartAngle", SmoothModulateStartAngle_Element.ToLinkField(context));
members.Add("SmoothModulateEndAngle", SmoothModulateEndAngle_Element.ToLinkField(context));
members.Add("SmoothModulateExp", SmoothModulateExp_Element.ToLinkField(context));
members.Add("SmoothModulateMultiplier", SmoothModulateMultiplier_Element.ToLinkField(context));
members.Add("StickThreshold", StickThreshold_Element.ToLinkField(context));
members.Add("ShowInDesktop", ShowInDesktop_Element.ToLinkField(context));
members.Add("MaxTouchPenetrationDistance", MaxTouchPenetrationDistance_Element.ToLinkField(context));
members.Add("StickPointSpace", StickPointSpace_Element.ToLinkReference(context));
members.Add("StickPointPosition", StickPointPosition_Element.ToLinkField(context));
members.Add("_handler", _handler_Element.ToLinkReference(context));
members.Add("_lastHit", _lastHit_Element.ToLinkReference(context));
members.Add("_lastInteractionTarget", _lastInteractionTarget_Element.ToLinkReference(context));
members.Add("_lastInteractionModifier", _lastInteractionModifier_Element.ToLinkReference(context));
members.Add("_hitColor", _hitColor_Element.ToLinkField(context));
members.Add("_laserTextureSpeed", _laserTextureSpeed_Element.ToLinkField(context));
members.Add("_touchSource", _touchSource_Element.ToLinkReference(context));
members.Add("_laserMesh", _laserMesh_Element.ToLinkReference(context));
members.Add("_laserMaterial", _laserMaterial_Element.ToLinkReference(context));
members.Add("_laserTexture", _laserTexture_Element.ToLinkReference(context));
members.Add("_behindLaserTint", _behindLaserTint_Element.ToLinkReference(context));
members.Add("_laserRenderQueue", _laserRenderQueue_Element.ToLinkReference(context));
members.Add("_laserFrontTextureOffset", _laserFrontTextureOffset_Element.ToLinkReference(context));
members.Add("_laserBehindTextureOffset", _laserBehindTextureOffset_Element.ToLinkReference(context));
members.Add("_directPoint", _directPoint_Element.ToLinkReference(context));
members.Add("_actualPoint", _actualPoint_Element.ToLinkReference(context));
members.Add("_startColor", _startColor_Element.ToLinkReference(context));
members.Add("_endColor", _endColor_Element.ToLinkReference(context));
members.Add("_pointSlot", _pointSlot_Element.ToLinkReference(context));
members.Add("_pointSlotPos", _pointSlotPos_Element.ToLinkReference(context));
members.Add("_laserVisible", _laserVisible_Element.ToLinkReference(context));
members.Add("_cursorVisible", _cursorVisible_Element.ToLinkReference(context));
members.Add("_cursorRoot", _cursorRoot_Element.ToLinkReference(context));
members.Add("_cursorImageRoot", _cursorImageRoot_Element.ToLinkReference(context));
members.Add("_cursorTexture", _cursorTexture_Element.ToLinkReference(context));
members.Add("_cursorMaterial", _cursorMaterial_Element.ToLinkReference(context));
members.Add("_cursorFrontTint", _cursorFrontTint_Element.ToLinkReference(context));
members.Add("_cursorBehindTint", _cursorBehindTint_Element.ToLinkReference(context));
members.Add("_cursorRenderQueue", _cursorRenderQueue_Element.ToLinkReference(context));
members.Add("_cursorOrientation", _cursorOrientation_Element.ToLinkReference(context));
members.Add("_cursorTint", _cursorTint_Element.ToLinkField(context));
members.Add("_directCursorVisualsVisible", _directCursorVisualsVisible_Element.ToLinkField(context));
members.Add("_directCursorActive", _directCursorActive_Element.ToLinkReference(context));
members.Add("_directCursorRoot", _directCursorRoot_Element.ToLinkReference(context));
members.Add("_directCursorImageRoot", _directCursorImageRoot_Element.ToLinkReference(context));
members.Add("_directCursorOffset", _directCursorOffset_Element.ToLinkReference(context));
members.Add("_directCursorOrientation", _directCursorOrientation_Element.ToLinkReference(context));
members.Add("_directLineTarget", _directLineTarget_Element.ToLinkReference(context));
members.Add("_directLineMesh", _directLineMesh_Element.ToLinkReference(context));
members.Add("_segmentColorFront", _segmentColorFront_Element.ToLinkReference(context));
members.Add("_segmentColorBehind", _segmentColorBehind_Element.ToLinkReference(context));
members.Add("_segmentRenderQueue", _segmentRenderQueue_Element.ToLinkReference(context));
}

}
}
