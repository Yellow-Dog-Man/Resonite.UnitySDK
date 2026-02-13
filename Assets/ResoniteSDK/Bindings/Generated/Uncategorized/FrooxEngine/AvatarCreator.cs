
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AvatarCreator
// Generated on: pátek 13. února 2026 5:52:29
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_headsetPoint", new ResoniteLink.Reference() { });
members.Add("_leftPoint", new ResoniteLink.Reference() { });
members.Add("_rightPoint", new ResoniteLink.Reference() { });
members.Add("_leftFootPoint", new ResoniteLink.Reference() { });
members.Add("_rightFootPoint", new ResoniteLink.Reference() { });
members.Add("_pelvisPoint", new ResoniteLink.Reference() { });
members.Add("_headsetReference", new ResoniteLink.Reference() { });
members.Add("_pelvisReference", new ResoniteLink.Reference() { });
members.Add("_leftReference", new ResoniteLink.Reference() { });
members.Add("_rightReference", new ResoniteLink.Reference() { });
members.Add("_leftFootReference", new ResoniteLink.Reference() { });
members.Add("_rightFootReference", new ResoniteLink.Reference() { });
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
    Elements = _anchors.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
members.Add("_scale", _scale.ToResoniteLinkField());
members.Add("_protectAvatarEnabled", new ResoniteLink.Reference() { });
members.Add("_createEnabled", new ResoniteLink.Reference() { });
}

}
}
