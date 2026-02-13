
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LabelContentDriver
// Generated on: pátek 13. února 2026 5:52:33
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("AutoUpdate", AutoUpdate.ToResoniteLinkField());
members.Add("Padding", Padding.ToResoniteLinkField());
members.Add("BaseWidth", BaseWidth.ToResoniteLinkField());
members.Add("ContentOrientSpace", new ResoniteLink.SyncObject() { Members = ContentOrientSpace.CollectMembers() });
members.Add("OrientAtLocalUser", OrientAtLocalUser.ToResoniteLinkField());
members.Add("_contentRoot", new ResoniteLink.Reference() { });
members.Add("_targetPoint", new ResoniteLink.Reference() { });
members.Add("_contentRotation", _contentRotation.ToResoniteLinkField());
members.Add("_contentRotationDrive", new ResoniteLink.Reference() { });
members.Add("_labelPosition", new ResoniteLink.Reference() { });
members.Add("_labelWidth", new ResoniteLink.Reference() { });
members.Add("_lineWidth", new ResoniteLink.Reference() { });
members.Add("_labelRotation", new ResoniteLink.Reference() { });
members.Add("_pointPosition", new ResoniteLink.Reference() { });
}

}
}
