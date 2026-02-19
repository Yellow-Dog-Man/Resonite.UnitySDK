
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractionLaser
// Generated on: čtvrtek 19. února 2026 8:00:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractionLaser")]
public partial class InteractionLaser : global::FrooxEngine.UserRootComponent

{
    public global::System.Single SmoothSpeed;
public global::System.Single SmoothModulateStartAngle;
public global::System.Single SmoothModulateEndAngle;
public global::System.Single SmoothModulateExp;
public global::System.Single SmoothModulateMultiplier;
public global::System.Single StickThreshold;
public global::System.Boolean ShowInDesktop;
public global::System.Single MaxTouchPenetrationDistance;
public global::FrooxEngine.Slot StickPointSpace;
public UnityEngine.Vector3 StickPointPosition;
public global::FrooxEngine.InteractionHandler _handler;
public global::FrooxEngine.Slot _lastHit;
public global::FrooxEngine.IInteractionTarget _lastInteractionTarget;
public global::FrooxEngine.ILaserInteractionModifier _lastInteractionModifier;
public UnityEngine.ColorX _hitColor;
public global::System.Single _laserTextureSpeed;
public global::FrooxEngine.RelayTouchSource _touchSource;
public global::FrooxEngine.BentTubeMesh _laserMesh;
public global::FrooxEngine.OverlayUnlitMaterial _laserMaterial;
public global::FrooxEngine.StaticTexture2D _laserTexture;
public global::FrooxEngine.IField<UnityEngine.ColorX> _behindLaserTint;
public global::FrooxEngine.IField<global::System.Int32> _laserRenderQueue;
public global::FrooxEngine.IField<UnityEngine.Vector2> _laserFrontTextureOffset;
public global::FrooxEngine.IField<UnityEngine.Vector2> _laserBehindTextureOffset;
public global::FrooxEngine.IField<UnityEngine.Vector3> _directPoint;
public global::FrooxEngine.IField<UnityEngine.Vector3> _actualPoint;
public global::FrooxEngine.IField<UnityEngine.ColorX> _startColor;
public global::FrooxEngine.IField<UnityEngine.ColorX> _endColor;
public global::FrooxEngine.Slot _pointSlot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _pointSlotPos;
public global::FrooxEngine.IField<global::System.Boolean> _laserVisible;
public global::FrooxEngine.IField<global::System.Boolean> _cursorVisible;
public global::FrooxEngine.Slot _cursorRoot;
public global::FrooxEngine.Slot _cursorImageRoot;
public global::FrooxEngine.StaticTexture2D _cursorTexture;
public global::FrooxEngine.OverlayUnlitMaterial _cursorMaterial;
public global::FrooxEngine.IField<UnityEngine.ColorX> _cursorFrontTint;
public global::FrooxEngine.IField<UnityEngine.ColorX> _cursorBehindTint;
public global::FrooxEngine.IField<global::System.Int32> _cursorRenderQueue;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _cursorOrientation;
public UnityEngine.ColorX _cursorTint;
public global::System.Boolean _directCursorVisualsVisible;
public global::FrooxEngine.IField<global::System.Boolean> _directCursorActive;
public global::FrooxEngine.Slot _directCursorRoot;
public global::FrooxEngine.Slot _directCursorImageRoot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _directCursorOffset;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _directCursorOrientation;
public global::FrooxEngine.IField<UnityEngine.Vector3> _directLineTarget;
public global::FrooxEngine.SegmentMesh _directLineMesh;
public global::FrooxEngine.IField<UnityEngine.ColorX> _segmentColorFront;
public global::FrooxEngine.IField<UnityEngine.ColorX> _segmentColorBehind;
public global::FrooxEngine.IField<global::System.Int32> _segmentRenderQueue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SmoothSpeed", SmoothSpeed.ToResoniteLinkField());
members.Add("SmoothModulateStartAngle", SmoothModulateStartAngle.ToResoniteLinkField());
members.Add("SmoothModulateEndAngle", SmoothModulateEndAngle.ToResoniteLinkField());
members.Add("SmoothModulateExp", SmoothModulateExp.ToResoniteLinkField());
members.Add("SmoothModulateMultiplier", SmoothModulateMultiplier.ToResoniteLinkField());
members.Add("StickThreshold", StickThreshold.ToResoniteLinkField());
members.Add("ShowInDesktop", ShowInDesktop.ToResoniteLinkField());
members.Add("MaxTouchPenetrationDistance", MaxTouchPenetrationDistance.ToResoniteLinkField());
members.Add("StickPointSpace", StickPointSpace.ToResoniteReference(context));
members.Add("StickPointPosition", StickPointPosition.ToResoniteLinkField());
members.Add("_handler", _handler.ToResoniteReference(context));
members.Add("_lastHit", _lastHit.ToResoniteReference(context));
members.Add("_lastInteractionTarget", _lastInteractionTarget.ToResoniteReference(context));
members.Add("_lastInteractionModifier", _lastInteractionModifier.ToResoniteReference(context));
members.Add("_hitColor", _hitColor.ToResoniteLinkField());
members.Add("_laserTextureSpeed", _laserTextureSpeed.ToResoniteLinkField());
members.Add("_touchSource", _touchSource.ToResoniteReference(context));
members.Add("_laserMesh", _laserMesh.ToResoniteReference(context));
members.Add("_laserMaterial", _laserMaterial.ToResoniteReference(context));
members.Add("_laserTexture", _laserTexture.ToResoniteReference(context));
members.Add("_behindLaserTint", _behindLaserTint.ToResoniteReference(context));
members.Add("_laserRenderQueue", _laserRenderQueue.ToResoniteReference(context));
members.Add("_laserFrontTextureOffset", _laserFrontTextureOffset.ToResoniteReference(context));
members.Add("_laserBehindTextureOffset", _laserBehindTextureOffset.ToResoniteReference(context));
members.Add("_directPoint", _directPoint.ToResoniteReference(context));
members.Add("_actualPoint", _actualPoint.ToResoniteReference(context));
members.Add("_startColor", _startColor.ToResoniteReference(context));
members.Add("_endColor", _endColor.ToResoniteReference(context));
members.Add("_pointSlot", _pointSlot.ToResoniteReference(context));
members.Add("_pointSlotPos", _pointSlotPos.ToResoniteReference(context));
members.Add("_laserVisible", _laserVisible.ToResoniteReference(context));
members.Add("_cursorVisible", _cursorVisible.ToResoniteReference(context));
members.Add("_cursorRoot", _cursorRoot.ToResoniteReference(context));
members.Add("_cursorImageRoot", _cursorImageRoot.ToResoniteReference(context));
members.Add("_cursorTexture", _cursorTexture.ToResoniteReference(context));
members.Add("_cursorMaterial", _cursorMaterial.ToResoniteReference(context));
members.Add("_cursorFrontTint", _cursorFrontTint.ToResoniteReference(context));
members.Add("_cursorBehindTint", _cursorBehindTint.ToResoniteReference(context));
members.Add("_cursorRenderQueue", _cursorRenderQueue.ToResoniteReference(context));
members.Add("_cursorOrientation", _cursorOrientation.ToResoniteReference(context));
members.Add("_cursorTint", _cursorTint.ToResoniteLinkField());
members.Add("_directCursorVisualsVisible", _directCursorVisualsVisible.ToResoniteLinkField());
members.Add("_directCursorActive", _directCursorActive.ToResoniteReference(context));
members.Add("_directCursorRoot", _directCursorRoot.ToResoniteReference(context));
members.Add("_directCursorImageRoot", _directCursorImageRoot.ToResoniteReference(context));
members.Add("_directCursorOffset", _directCursorOffset.ToResoniteReference(context));
members.Add("_directCursorOrientation", _directCursorOrientation.ToResoniteReference(context));
members.Add("_directLineTarget", _directLineTarget.ToResoniteReference(context));
members.Add("_directLineMesh", _directLineMesh.ToResoniteReference(context));
members.Add("_segmentColorFront", _segmentColorFront.ToResoniteReference(context));
members.Add("_segmentColorBehind", _segmentColorBehind.ToResoniteReference(context));
members.Add("_segmentRenderQueue", _segmentRenderQueue.ToResoniteReference(context));
}

}
}
