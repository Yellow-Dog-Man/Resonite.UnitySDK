
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Spinner
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Spinner")]
public partial class Spinner : global::FrooxEngine.Component

{
    public UnityEngine.Vector3 Range { get => Range_Element.Data; set => Range_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Range_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _target { get => _target_Element.Data; set => _target_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _target_Element = new();
public UnityEngine.Quaternion _offset { get => _offset_Element.Data; set => _offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> _offset_Element = new();
public UnityEngine.Vector3 _speed { get => _speed_Element.Data; set => _speed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> _speed_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Range", Range_Element.ToLinkField(context));
members.Add("_target", _target_Element.ToLinkReference(context));
members.Add("_offset", _offset_Element.ToLinkField(context));
members.Add("_speed", _speed_Element.ToLinkField(context));
}

}
}
