
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VirtualParent
// Generated on: pátek 13. února 2026 23:23:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VirtualParent")]
public partial class VirtualParent : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot OverrideParent;
public global::FrooxEngine.IField<UnityEngine.Vector3> _targetPos;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _targetRot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _targetScl;
public UnityEngine.Vector3 LocalPosition;
public UnityEngine.Quaternion LocalRotation;
public UnityEngine.Vector3 LocalScale;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("OverrideParent", new ResoniteLink.Reference() { });
members.Add("_targetPos", new ResoniteLink.Reference() { });
members.Add("_targetRot", new ResoniteLink.Reference() { });
members.Add("_targetScl", new ResoniteLink.Reference() { });
members.Add("LocalPosition", LocalPosition.ToResoniteLinkField());
members.Add("LocalRotation", LocalRotation.ToResoniteLinkField());
members.Add("LocalScale", LocalScale.ToResoniteLinkField());
}

}
}
