
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Wobbler4D
// Generated on: pátek 13. února 2026 5:52:27
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Wobbler4D")]
public partial class Wobbler4D : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Vector4> Target;
public UnityEngine.Vector4 Offset;
public UnityEngine.Vector4 Speed;
public UnityEngine.Vector4 Magnitude;
public UnityEngine.Vector4 Seed;

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
