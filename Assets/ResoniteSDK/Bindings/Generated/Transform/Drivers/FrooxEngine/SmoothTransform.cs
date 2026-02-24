
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SmoothTransform
// Generated on: úterý 24. února 2026 18:20:14
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SmoothTransform")]
public partial class SmoothTransform : global::FrooxEngine.Component

{
    public global::FrooxEngine.RootSpace InterpolationSpace;
public UnityEngine.Vector3 TargetPosition;
public UnityEngine.Quaternion TargetRotation;
public UnityEngine.Vector3 TargetScale;
public global::FrooxEngine.IField<UnityEngine.Vector3> Position;
public global::FrooxEngine.IField<UnityEngine.Quaternion> Rotation;
public global::FrooxEngine.IField<UnityEngine.Vector3> Scale;
public global::System.Single SmoothSpeed;
public global::System.Int32 _updateIndex;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InterpolationSpace", new ResoniteLink.SyncObject() { Members = InterpolationSpace.CollectMembers(context) });
members.Add("TargetPosition", TargetPosition.ToResoniteLinkField());
members.Add("TargetRotation", TargetRotation.ToResoniteLinkField());
members.Add("TargetScale", TargetScale.ToResoniteLinkField());
members.Add("Position", Position.ToResoniteReference(context));
members.Add("Rotation", Rotation.ToResoniteReference(context));
members.Add("Scale", Scale.ToResoniteReference(context));
members.Add("SmoothSpeed", SmoothSpeed.ToResoniteLinkField());
members.Add("_updateIndex", _updateIndex.ToResoniteLinkField());
}

}
}
