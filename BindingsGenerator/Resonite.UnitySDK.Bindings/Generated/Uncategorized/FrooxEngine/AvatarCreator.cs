
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AvatarCreator
// Generated on: pátek 6. března 2026 18:29:09
// Resonite version: 2026.3.6.1071
// Resonite Link Version: 0.11.0.0
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
    public global::FrooxEngine.Slot _headsetPoint { get => _headsetPoint_Element.Data; set => _headsetPoint_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _headsetPoint_Element = new();
public global::FrooxEngine.Slot _leftPoint { get => _leftPoint_Element.Data; set => _leftPoint_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _leftPoint_Element = new();
public global::FrooxEngine.Slot _rightPoint { get => _rightPoint_Element.Data; set => _rightPoint_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _rightPoint_Element = new();
public global::FrooxEngine.Slot _leftFootPoint { get => _leftFootPoint_Element.Data; set => _leftFootPoint_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _leftFootPoint_Element = new();
public global::FrooxEngine.Slot _rightFootPoint { get => _rightFootPoint_Element.Data; set => _rightFootPoint_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _rightFootPoint_Element = new();
public global::FrooxEngine.Slot _pelvisPoint { get => _pelvisPoint_Element.Data; set => _pelvisPoint_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _pelvisPoint_Element = new();
public global::FrooxEngine.Slot _headsetReference { get => _headsetReference_Element.Data; set => _headsetReference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _headsetReference_Element = new();
public global::FrooxEngine.Slot _pelvisReference { get => _pelvisReference_Element.Data; set => _pelvisReference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _pelvisReference_Element = new();
public global::FrooxEngine.Slot _leftReference { get => _leftReference_Element.Data; set => _leftReference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _leftReference_Element = new();
public global::FrooxEngine.Slot _rightReference { get => _rightReference_Element.Data; set => _rightReference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _rightReference_Element = new();
public global::FrooxEngine.Slot _leftFootReference { get => _leftFootReference_Element.Data; set => _leftFootReference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _leftFootReference_Element = new();
public global::FrooxEngine.Slot _rightFootReference { get => _rightFootReference_Element.Data; set => _rightFootReference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _rightFootReference_Element = new();
public global::System.Boolean _initialized { get => _initialized_Element.Data; set => _initialized_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _initialized_Element = new();
public global::System.Boolean _showAnchors { get => _showAnchors_Element.Data; set => _showAnchors_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _showAnchors_Element = new();
public global::System.Boolean _useSymmetry { get => _useSymmetry_Element.Data; set => _useSymmetry_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _useSymmetry_Element = new();
public global::System.Boolean _setupVolumeMeter { get => _setupVolumeMeter_Element.Data; set => _setupVolumeMeter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _setupVolumeMeter_Element = new();
public global::System.Boolean _setupProtection { get => _setupProtection_Element.Data; set => _setupProtection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _setupProtection_Element = new();
public global::System.Boolean _setupEyes { get => _setupEyes_Element.Data; set => _setupEyes_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _setupEyes_Element = new();
public global::System.Boolean _setupFaceTracking { get => _setupFaceTracking_Element.Data; set => _setupFaceTracking_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _setupFaceTracking_Element = new();
public global::System.Boolean _calibrateFeet { get => _calibrateFeet_Element.Data; set => _calibrateFeet_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _calibrateFeet_Element = new();
public global::System.Boolean _calibratePelvis { get => _calibratePelvis_Element.Data; set => _calibratePelvis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _calibratePelvis_Element = new();
public global::System.Boolean _canProtect { get => _canProtect_Element.Data; set => _canProtect_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _canProtect_Element = new();
public global::System.Boolean _symmetrySetup { get => _symmetrySetup_Element.Data; set => _symmetrySetup_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _symmetrySetup_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.AvatarCreator.Anchor>, global::FrooxEngine.AvatarCreator.Anchor> _anchors = new();
public global::System.Single _scale { get => _scale_Element.Data; set => _scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _scale_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _protectAvatarEnabled { get => _protectAvatarEnabled_Element.Data; set => _protectAvatarEnabled_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _protectAvatarEnabled_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _createEnabled { get => _createEnabled_Element.Data; set => _createEnabled_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _createEnabled_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_headsetPoint", _headsetPoint_Element.ToLinkReference(context));
members.Add("_leftPoint", _leftPoint_Element.ToLinkReference(context));
members.Add("_rightPoint", _rightPoint_Element.ToLinkReference(context));
members.Add("_leftFootPoint", _leftFootPoint_Element.ToLinkReference(context));
members.Add("_rightFootPoint", _rightFootPoint_Element.ToLinkReference(context));
members.Add("_pelvisPoint", _pelvisPoint_Element.ToLinkReference(context));
members.Add("_headsetReference", _headsetReference_Element.ToLinkReference(context));
members.Add("_pelvisReference", _pelvisReference_Element.ToLinkReference(context));
members.Add("_leftReference", _leftReference_Element.ToLinkReference(context));
members.Add("_rightReference", _rightReference_Element.ToLinkReference(context));
members.Add("_leftFootReference", _leftFootReference_Element.ToLinkReference(context));
members.Add("_rightFootReference", _rightFootReference_Element.ToLinkReference(context));
members.Add("_initialized", _initialized_Element.ToLinkField(context));
members.Add("_showAnchors", _showAnchors_Element.ToLinkField(context));
members.Add("_useSymmetry", _useSymmetry_Element.ToLinkField(context));
members.Add("_setupVolumeMeter", _setupVolumeMeter_Element.ToLinkField(context));
members.Add("_setupProtection", _setupProtection_Element.ToLinkField(context));
members.Add("_setupEyes", _setupEyes_Element.ToLinkField(context));
members.Add("_setupFaceTracking", _setupFaceTracking_Element.ToLinkField(context));
members.Add("_calibrateFeet", _calibrateFeet_Element.ToLinkField(context));
members.Add("_calibratePelvis", _calibratePelvis_Element.ToLinkField(context));
members.Add("_canProtect", _canProtect_Element.ToLinkField(context));
members.Add("_symmetrySetup", _symmetrySetup_Element.ToLinkField(context));
members.Add("_anchors", _anchors.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("_scale", _scale_Element.ToLinkField(context));
members.Add("_protectAvatarEnabled", _protectAvatarEnabled_Element.ToLinkReference(context));
members.Add("_createEnabled", _createEnabled_Element.ToLinkReference(context));
}
public static async System.Threading.Tasks.Task CreateBipedAvatar(global::FrooxEngine.BipedRig biped, global::FrooxEngine.Slot headReference, global::FrooxEngine.Slot leftHandReference, global::FrooxEngine.Slot rightHandReference, global::FrooxEngine.Slot leftFootReference, global::FrooxEngine.Slot rightFootReference, global::FrooxEngine.Slot hipsReference, global::System.Boolean setupEyes, global::System.Boolean setupProtection, global::System.Boolean setupVolumeMeter, global::System.Boolean setupFaceTracking, IConversionContext context)
{
        var __message = new ResoniteLink.CallStaticSyncMethod();
        __message.MethodName = "CreateBipedAvatar";
__message.TargetType = "[FrooxEngine]FrooxEngine.AvatarCreator";
__message.Arguments.Add("biped", new ResoniteLink.Data_Reference() { TargetID = context.GetId(biped) });
__message.Arguments.Add("headReference", new ResoniteLink.Data_Reference() { TargetID = context.GetId(headReference) });
__message.Arguments.Add("leftHandReference", new ResoniteLink.Data_Reference() { TargetID = context.GetId(leftHandReference) });
__message.Arguments.Add("rightHandReference", new ResoniteLink.Data_Reference() { TargetID = context.GetId(rightHandReference) });
__message.Arguments.Add("leftFootReference", new ResoniteLink.Data_Reference() { TargetID = context.GetId(leftFootReference) });
__message.Arguments.Add("rightFootReference", new ResoniteLink.Data_Reference() { TargetID = context.GetId(rightFootReference) });
__message.Arguments.Add("hipsReference", new ResoniteLink.Data_Reference() { TargetID = context.GetId(hipsReference) });
__message.Arguments.Add("setupEyes", setupEyes.ToData());
__message.Arguments.Add("setupProtection", setupProtection.ToData());
__message.Arguments.Add("setupVolumeMeter", setupVolumeMeter.ToData());
__message.Arguments.Add("setupFaceTracking", setupFaceTracking.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
}


}
}
