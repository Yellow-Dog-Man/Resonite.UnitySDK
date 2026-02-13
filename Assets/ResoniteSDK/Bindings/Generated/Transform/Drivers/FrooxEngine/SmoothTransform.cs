
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SmoothTransform
// Generated on: pátek 13. února 2026 23:23:09
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("InterpolationSpace", new ResoniteLink.SyncObject() { Members = InterpolationSpace.CollectMembers() });
members.Add("TargetPosition", TargetPosition.ToResoniteLinkField());
members.Add("TargetRotation", TargetRotation.ToResoniteLinkField());
members.Add("TargetScale", TargetScale.ToResoniteLinkField());
members.Add("Position", new ResoniteLink.Reference() { });
members.Add("Rotation", new ResoniteLink.Reference() { });
members.Add("Scale", new ResoniteLink.Reference() { });
members.Add("SmoothSpeed", SmoothSpeed.ToResoniteLinkField());
members.Add("_updateIndex", _updateIndex.ToResoniteLinkField());
}

}
}
