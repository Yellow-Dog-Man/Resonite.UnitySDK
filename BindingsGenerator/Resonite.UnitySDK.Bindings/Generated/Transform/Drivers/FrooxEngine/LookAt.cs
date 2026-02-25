
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LookAt
// Generated on: středa 25. února 2026 16:14:30
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
    public global::FrooxEngine.Slot Target;
public UnityEngine.Vector3 TargetPoint;
public global::FrooxEngine.RootSpace TargetPointSpace;
public UnityEngine.Vector3 Up;
public UnityEngine.Quaternion RotationOffset;
public UnityEngine.Vector3 SwingReference;
public UnityEngine.Vector3 TwistReference;
public global::System.Single MaxSwing;
public global::System.Single MaxTwist;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _target;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("TargetPoint", TargetPoint.ToResoniteLinkField());
members.Add("TargetPointSpace", new ResoniteLink.SyncObject() { Members = TargetPointSpace.CollectMembers(context) });
members.Add("Up", Up.ToResoniteLinkField());
members.Add("RotationOffset", RotationOffset.ToResoniteLinkField());
members.Add("SwingReference", SwingReference.ToResoniteLinkField());
members.Add("TwistReference", TwistReference.ToResoniteLinkField());
members.Add("MaxSwing", MaxSwing.ToResoniteLinkField());
members.Add("MaxTwist", MaxTwist.ToResoniteLinkField());
members.Add("_target", _target.ToResoniteReference(context));
}

}
}
