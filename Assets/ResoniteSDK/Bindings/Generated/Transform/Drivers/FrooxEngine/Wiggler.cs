
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Wiggler
// Generated on: pátek 13. února 2026 23:23:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Wiggler")]
public partial class Wiggler : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Quaternion> _target;
public UnityEngine.Quaternion _offset;
public UnityEngine.Vector3 _speed;
public UnityEngine.Vector3 _magnitude;
public UnityEngine.Vector3 _seed;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_target", new ResoniteLink.Reference() { });
members.Add("_offset", _offset.ToResoniteLinkField());
members.Add("_speed", _speed.ToResoniteLinkField());
members.Add("_magnitude", _magnitude.ToResoniteLinkField());
members.Add("_seed", _seed.ToResoniteLinkField());
}

}
}
