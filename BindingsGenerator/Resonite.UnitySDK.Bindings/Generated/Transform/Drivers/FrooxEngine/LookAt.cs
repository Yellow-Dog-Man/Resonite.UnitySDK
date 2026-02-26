
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LookAt
// Generated on: čtvrtek 26. února 2026 10:04:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LookAt")]
public partial class LookAt : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.Slot Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Target_Element = new();
public UnityEngine.Vector3 TargetPoint { get => TargetPoint_Element.Data; set => TargetPoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> TargetPoint_Element = new();
public global::FrooxEngine.RootSpace TargetPointSpace = new();
public UnityEngine.Vector3 Up { get => Up_Element.Data; set => Up_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Up_Element = new();
public UnityEngine.Quaternion RotationOffset { get => RotationOffset_Element.Data; set => RotationOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> RotationOffset_Element = new();
public UnityEngine.Vector3 SwingReference { get => SwingReference_Element.Data; set => SwingReference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> SwingReference_Element = new();
public UnityEngine.Vector3 TwistReference { get => TwistReference_Element.Data; set => TwistReference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> TwistReference_Element = new();
public global::System.Single MaxSwing { get => MaxSwing_Element.Data; set => MaxSwing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxSwing_Element = new();
public global::System.Single MaxTwist { get => MaxTwist_Element.Data; set => MaxTwist_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxTwist_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _target { get => _target_Element.Data; set => _target_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _target_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.Data.ToResoniteReference(context));
members.Add("TargetPoint", TargetPoint_Element.Data.ToResoniteLinkField());
members.Add("TargetPointSpace", new ResoniteLink.SyncObject() { Members = TargetPointSpace.CollectMembers(context) });
members.Add("Up", Up_Element.Data.ToResoniteLinkField());
members.Add("RotationOffset", RotationOffset_Element.Data.ToResoniteLinkField());
members.Add("SwingReference", SwingReference_Element.Data.ToResoniteLinkField());
members.Add("TwistReference", TwistReference_Element.Data.ToResoniteLinkField());
members.Add("MaxSwing", MaxSwing_Element.Data.ToResoniteLinkField());
members.Add("MaxTwist", MaxTwist_Element.Data.ToResoniteLinkField());
members.Add("_target", _target_Element.Data.ToResoniteReference(context));
}

}
}
