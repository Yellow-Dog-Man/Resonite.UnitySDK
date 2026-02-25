
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Panner2D
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Panner2D")]
public partial class Panner2D : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Vector2> _target;
public UnityEngine.Vector2 _offset;
public UnityEngine.Vector2 _preOffset;
public UnityEngine.Vector2 _speed;
public UnityEngine.Vector2 _repeat;
public global::System.Boolean PingPong;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_target", _target.ToResoniteReference(context));
members.Add("_offset", _offset.ToResoniteLinkField());
members.Add("_preOffset", _preOffset.ToResoniteLinkField());
members.Add("_speed", _speed.ToResoniteLinkField());
members.Add("_repeat", _repeat.ToResoniteLinkField());
members.Add("PingPong", PingPong.ToResoniteLinkField());
}

}
}
