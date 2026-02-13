
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractionLaser
// Generated on: pátek 13. února 2026 23:22:57
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SmoothSpeed", SmoothSpeed.ToResoniteLinkField());
members.Add("SmoothModulateStartAngle", SmoothModulateStartAngle.ToResoniteLinkField());
members.Add("SmoothModulateEndAngle", SmoothModulateEndAngle.ToResoniteLinkField());
members.Add("SmoothModulateExp", SmoothModulateExp.ToResoniteLinkField());
members.Add("SmoothModulateMultiplier", SmoothModulateMultiplier.ToResoniteLinkField());
members.Add("StickThreshold", StickThreshold.ToResoniteLinkField());
members.Add("ShowInDesktop", ShowInDesktop.ToResoniteLinkField());
members.Add("MaxTouchPenetrationDistance", MaxTouchPenetrationDistance.ToResoniteLinkField());
members.Add("StickPointSpace", new ResoniteLink.Reference() { });
members.Add("StickPointPosition", StickPointPosition.ToResoniteLinkField());
members.Add("_handler", new ResoniteLink.Reference() { });
members.Add("_lastHit", new ResoniteLink.Reference() { });
members.Add("_lastInteractionTarget", new ResoniteLink.Reference() { });
members.Add("_lastInteractionModifier", new ResoniteLink.Reference() { });
members.Add("_hitColor", _hitColor.ToResoniteLinkField());
members.Add("_laserTextureSpeed", _laserTextureSpeed.ToResoniteLinkField());
members.Add("_touchSource", new ResoniteLink.Reference() { });
members.Add("_laserMesh", new ResoniteLink.Reference() { });
members.Add("_laserMaterial", new ResoniteLink.Reference() { });
members.Add("_laserTexture", new ResoniteLink.Reference() { });
members.Add("_behindLaserTint", new ResoniteLink.Reference() { });
members.Add("_laserRenderQueue", new ResoniteLink.Reference() { });
members.Add("_laserFrontTextureOffset", new ResoniteLink.Reference() { });
members.Add("_laserBehindTextureOffset", new ResoniteLink.Reference() { });
members.Add("_directPoint", new ResoniteLink.Reference() { });
members.Add("_actualPoint", new ResoniteLink.Reference() { });
members.Add("_startColor", new ResoniteLink.Reference() { });
members.Add("_endColor", new ResoniteLink.Reference() { });
members.Add("_pointSlot", new ResoniteLink.Reference() { });
members.Add("_pointSlotPos", new ResoniteLink.Reference() { });
members.Add("_laserVisible", new ResoniteLink.Reference() { });
members.Add("_cursorVisible", new ResoniteLink.Reference() { });
members.Add("_cursorRoot", new ResoniteLink.Reference() { });
members.Add("_cursorImageRoot", new ResoniteLink.Reference() { });
members.Add("_cursorTexture", new ResoniteLink.Reference() { });
members.Add("_cursorMaterial", new ResoniteLink.Reference() { });
members.Add("_cursorFrontTint", new ResoniteLink.Reference() { });
members.Add("_cursorBehindTint", new ResoniteLink.Reference() { });
members.Add("_cursorRenderQueue", new ResoniteLink.Reference() { });
members.Add("_cursorOrientation", new ResoniteLink.Reference() { });
members.Add("_cursorTint", _cursorTint.ToResoniteLinkField());
members.Add("_directCursorVisualsVisible", _directCursorVisualsVisible.ToResoniteLinkField());
members.Add("_directCursorActive", new ResoniteLink.Reference() { });
members.Add("_directCursorRoot", new ResoniteLink.Reference() { });
members.Add("_directCursorImageRoot", new ResoniteLink.Reference() { });
members.Add("_directCursorOffset", new ResoniteLink.Reference() { });
members.Add("_directCursorOrientation", new ResoniteLink.Reference() { });
members.Add("_directLineTarget", new ResoniteLink.Reference() { });
members.Add("_directLineMesh", new ResoniteLink.Reference() { });
members.Add("_segmentColorFront", new ResoniteLink.Reference() { });
members.Add("_segmentColorBehind", new ResoniteLink.Reference() { });
members.Add("_segmentRenderQueue", new ResoniteLink.Reference() { });
}

}
}
