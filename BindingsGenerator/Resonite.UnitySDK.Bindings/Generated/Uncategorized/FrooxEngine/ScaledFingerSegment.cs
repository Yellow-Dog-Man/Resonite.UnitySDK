
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaledFingerSegment
// Generated on: středa 25. února 2026 16:14:43
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaledFingerSegment")]
public partial class ScaledFingerSegment : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Vector3> _scale;
public global::FrooxEngine.IField<UnityEngine.Vector3> _offset;
public global::FrooxEngine.Slot _nextJoint;
public global::Renderite.Shared.BodyNode _bodyNode;
public global::System.Single Width;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_scale", _scale.ToResoniteReference(context));
members.Add("_offset", _offset.ToResoniteReference(context));
members.Add("_nextJoint", _nextJoint.ToResoniteReference(context));
members.Add("_bodyNode", _bodyNode.ToResoniteLinkField());
members.Add("Width", Width.ToResoniteLinkField());
}

}
}
