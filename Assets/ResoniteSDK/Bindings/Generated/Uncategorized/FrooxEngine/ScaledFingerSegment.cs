
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaledFingerSegment
// Generated on: pátek 13. února 2026 23:23:17
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaledFingerSegment")]
public partial class ScaledFingerSegment : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Vector3> _scale;
public global::FrooxEngine.IField<UnityEngine.Vector3> _offset;
public global::FrooxEngine.Slot _nextJoint;
public global::Renderite.Shared.BodyNode _bodyNode;
public global::System.Single Width;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_scale", new ResoniteLink.Reference() { });
members.Add("_offset", new ResoniteLink.Reference() { });
members.Add("_nextJoint", new ResoniteLink.Reference() { });
members.Add("_bodyNode", _bodyNode.ToResoniteLinkField());
members.Add("Width", Width.ToResoniteLinkField());
}

}
}
