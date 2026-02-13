
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Wobbler3D
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Wobbler3D")]
public partial class Wobbler3D : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Vector3> Target;
public UnityEngine.Vector3 Offset;
public UnityEngine.Vector3 Speed;
public UnityEngine.Vector3 Magnitude;
public UnityEngine.Vector3 Seed;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("Speed", Speed.ToResoniteLinkField());
members.Add("Magnitude", Magnitude.ToResoniteLinkField());
members.Add("Seed", Seed.ToResoniteLinkField());
}

}
}
