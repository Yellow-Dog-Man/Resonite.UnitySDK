
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Spinner
// Generated on: pátek 13. února 2026 23:23:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Spinner")]
public partial class Spinner : global::FrooxEngine.Component

{
    public UnityEngine.Vector3 Range;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _target;
public UnityEngine.Quaternion _offset;
public UnityEngine.Vector3 _speed;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Range", Range.ToResoniteLinkField());
members.Add("_target", new ResoniteLink.Reference() { });
members.Add("_offset", _offset.ToResoniteLinkField());
members.Add("_speed", _speed.ToResoniteLinkField());
}

}
}
