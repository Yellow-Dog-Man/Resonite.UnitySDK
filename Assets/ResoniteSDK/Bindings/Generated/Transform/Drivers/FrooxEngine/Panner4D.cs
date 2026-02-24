
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Panner4D
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Panner4D")]
public partial class Panner4D : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Vector4> _target;
public UnityEngine.Vector4 _offset;
public UnityEngine.Vector4 _preOffset;
public UnityEngine.Vector4 _speed;
public UnityEngine.Vector4 _repeat;
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
