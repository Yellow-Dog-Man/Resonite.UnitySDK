
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Spinner
// Generated on: středa 25. února 2026 16:14:31
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Spinner")]
public partial class Spinner : global::FrooxEngine.Component

{
    public UnityEngine.Vector3 Range;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _target;
public UnityEngine.Quaternion _offset;
public UnityEngine.Vector3 _speed;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Range", Range.ToResoniteLinkField());
members.Add("_target", _target.ToResoniteReference(context));
members.Add("_offset", _offset.ToResoniteLinkField());
members.Add("_speed", _speed.ToResoniteLinkField());
}

}
}
