
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Panner2D
// Generated on: čtvrtek 26. února 2026 15:09:08
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.IField<UnityEngine.Vector2> _target { get => _target_Element.Data; set => _target_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _target_Element = new();
public UnityEngine.Vector2 _offset { get => _offset_Element.Data; set => _offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> _offset_Element = new();
public UnityEngine.Vector2 _preOffset { get => _preOffset_Element.Data; set => _preOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> _preOffset_Element = new();
public UnityEngine.Vector2 _speed { get => _speed_Element.Data; set => _speed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> _speed_Element = new();
public UnityEngine.Vector2 _repeat { get => _repeat_Element.Data; set => _repeat_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> _repeat_Element = new();
public global::System.Boolean PingPong { get => PingPong_Element.Data; set => PingPong_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PingPong_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_target", _target_Element.ToLinkReference(context));
members.Add("_offset", _offset_Element.ToLinkField(context));
members.Add("_preOffset", _preOffset_Element.ToLinkField(context));
members.Add("_speed", _speed_Element.ToLinkField(context));
members.Add("_repeat", _repeat_Element.ToLinkField(context));
members.Add("PingPong", PingPong_Element.ToLinkField(context));
}

}
}
