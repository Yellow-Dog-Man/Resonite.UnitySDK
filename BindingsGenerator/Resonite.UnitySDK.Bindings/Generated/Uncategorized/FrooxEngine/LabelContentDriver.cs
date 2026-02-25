
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LabelContentDriver
// Generated on: středa 25. února 2026 16:14:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LabelContentDriver")]
public partial class LabelContentDriver : global::FrooxEngine.Component

{
    public global::System.Boolean AutoUpdate;
public UnityEngine.Vector2 Padding;
public global::System.Single BaseWidth;
public global::FrooxEngine.RootSpace ContentOrientSpace;
public global::System.Boolean OrientAtLocalUser;
public global::FrooxEngine.Slot _contentRoot;
public global::FrooxEngine.Slot _targetPoint;
public UnityEngine.Quaternion _contentRotation;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _contentRotationDrive;
public global::FrooxEngine.IField<UnityEngine.Vector3> _labelPosition;
public global::FrooxEngine.IField<global::System.Single> _labelWidth;
public global::FrooxEngine.IField<global::System.Single> _lineWidth;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _labelRotation;
public global::FrooxEngine.IField<UnityEngine.Vector3> _pointPosition;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AutoUpdate", AutoUpdate.ToResoniteLinkField());
members.Add("Padding", Padding.ToResoniteLinkField());
members.Add("BaseWidth", BaseWidth.ToResoniteLinkField());
members.Add("ContentOrientSpace", new ResoniteLink.SyncObject() { Members = ContentOrientSpace.CollectMembers(context) });
members.Add("OrientAtLocalUser", OrientAtLocalUser.ToResoniteLinkField());
members.Add("_contentRoot", _contentRoot.ToResoniteReference(context));
members.Add("_targetPoint", _targetPoint.ToResoniteReference(context));
members.Add("_contentRotation", _contentRotation.ToResoniteLinkField());
members.Add("_contentRotationDrive", _contentRotationDrive.ToResoniteReference(context));
members.Add("_labelPosition", _labelPosition.ToResoniteReference(context));
members.Add("_labelWidth", _labelWidth.ToResoniteReference(context));
members.Add("_lineWidth", _lineWidth.ToResoniteReference(context));
members.Add("_labelRotation", _labelRotation.ToResoniteReference(context));
members.Add("_pointPosition", _pointPosition.ToResoniteReference(context));
}

}
}
