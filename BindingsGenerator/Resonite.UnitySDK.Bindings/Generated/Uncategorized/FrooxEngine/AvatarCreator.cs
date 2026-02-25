
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AvatarCreator
// Generated on: středa 25. února 2026 16:14:35
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AvatarCreator")]
public partial class AvatarCreator : global::FrooxEngine.Component, global::FrooxEngine.IMaterialApplyPolicy

{
    public global::FrooxEngine.Slot _headsetPoint;
public global::FrooxEngine.Slot _leftPoint;
public global::FrooxEngine.Slot _rightPoint;
public global::FrooxEngine.Slot _leftFootPoint;
public global::FrooxEngine.Slot _rightFootPoint;
public global::FrooxEngine.Slot _pelvisPoint;
public global::FrooxEngine.Slot _headsetReference;
public global::FrooxEngine.Slot _pelvisReference;
public global::FrooxEngine.Slot _leftReference;
public global::FrooxEngine.Slot _rightReference;
public global::FrooxEngine.Slot _leftFootReference;
public global::FrooxEngine.Slot _rightFootReference;
public global::System.Boolean _initialized;
public global::System.Boolean _showAnchors;
public global::System.Boolean _useSymmetry;
public global::System.Boolean _setupVolumeMeter;
public global::System.Boolean _setupProtection;
public global::System.Boolean _setupEyes;
public global::System.Boolean _setupFaceTracking;
public global::System.Boolean _calibrateFeet;
public global::System.Boolean _calibratePelvis;
public global::System.Boolean _canProtect;
public global::System.Boolean _symmetrySetup;
public System.Collections.Generic.List<global::FrooxEngine.AvatarCreator.Anchor> _anchors;
public global::System.Single _scale;
public global::FrooxEngine.IField<global::System.Boolean> _protectAvatarEnabled;
public global::FrooxEngine.IField<global::System.Boolean> _createEnabled;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_headsetPoint", _headsetPoint.ToResoniteReference(context));
members.Add("_leftPoint", _leftPoint.ToResoniteReference(context));
members.Add("_rightPoint", _rightPoint.ToResoniteReference(context));
members.Add("_leftFootPoint", _leftFootPoint.ToResoniteReference(context));
members.Add("_rightFootPoint", _rightFootPoint.ToResoniteReference(context));
members.Add("_pelvisPoint", _pelvisPoint.ToResoniteReference(context));
members.Add("_headsetReference", _headsetReference.ToResoniteReference(context));
members.Add("_pelvisReference", _pelvisReference.ToResoniteReference(context));
members.Add("_leftReference", _leftReference.ToResoniteReference(context));
members.Add("_rightReference", _rightReference.ToResoniteReference(context));
members.Add("_leftFootReference", _leftFootReference.ToResoniteReference(context));
members.Add("_rightFootReference", _rightFootReference.ToResoniteReference(context));
members.Add("_initialized", _initialized.ToResoniteLinkField());
members.Add("_showAnchors", _showAnchors.ToResoniteLinkField());
members.Add("_useSymmetry", _useSymmetry.ToResoniteLinkField());
members.Add("_setupVolumeMeter", _setupVolumeMeter.ToResoniteLinkField());
members.Add("_setupProtection", _setupProtection.ToResoniteLinkField());
members.Add("_setupEyes", _setupEyes.ToResoniteLinkField());
members.Add("_setupFaceTracking", _setupFaceTracking.ToResoniteLinkField());
members.Add("_calibrateFeet", _calibrateFeet.ToResoniteLinkField());
members.Add("_calibratePelvis", _calibratePelvis.ToResoniteLinkField());
members.Add("_canProtect", _canProtect.ToResoniteLinkField());
members.Add("_symmetrySetup", _symmetrySetup.ToResoniteLinkField());
members.Add("_anchors", new ResoniteLink.SyncList()
{
    Elements = _anchors.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("_scale", _scale.ToResoniteLinkField());
members.Add("_protectAvatarEnabled", _protectAvatarEnabled.ToResoniteReference(context));
members.Add("_createEnabled", _createEnabled.ToResoniteReference(context));
}

}
}
