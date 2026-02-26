
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Panner1D
// Generated on: čtvrtek 26. února 2026 10:04:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Panner1D")]
public partial class Panner1D : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.Single> _target { get => _target_Element.Data; set => _target_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _target_Element = new();
public global::System.Single _offset { get => _offset_Element.Data; set => _offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _offset_Element = new();
public global::System.Single _preOffset { get => _preOffset_Element.Data; set => _preOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _preOffset_Element = new();
public global::System.Single _speed { get => _speed_Element.Data; set => _speed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _speed_Element = new();
public global::System.Single _repeat { get => _repeat_Element.Data; set => _repeat_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _repeat_Element = new();
public global::System.Boolean PingPong { get => PingPong_Element.Data; set => PingPong_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PingPong_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_target", _target_Element.Data.ToResoniteReference(context));
members.Add("_offset", _offset_Element.Data.ToResoniteLinkField());
members.Add("_preOffset", _preOffset_Element.Data.ToResoniteLinkField());
members.Add("_speed", _speed_Element.Data.ToResoniteLinkField());
members.Add("_repeat", _repeat_Element.Data.ToResoniteLinkField());
members.Add("PingPong", PingPong_Element.Data.ToResoniteLinkField());
}

}
}
