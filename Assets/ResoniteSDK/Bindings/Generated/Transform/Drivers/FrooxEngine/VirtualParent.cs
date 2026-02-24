
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VirtualParent
// Generated on: úterý 24. února 2026 18:20:15
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OverrideParent", OverrideParent.ToResoniteReference(context));
members.Add("_targetPos", _targetPos.ToResoniteReference(context));
members.Add("_targetRot", _targetRot.ToResoniteReference(context));
members.Add("_targetScl", _targetScl.ToResoniteReference(context));
members.Add("LocalPosition", LocalPosition.ToResoniteLinkField());
members.Add("LocalRotation", LocalRotation.ToResoniteLinkField());
members.Add("LocalScale", LocalScale.ToResoniteLinkField());
}

}
}
