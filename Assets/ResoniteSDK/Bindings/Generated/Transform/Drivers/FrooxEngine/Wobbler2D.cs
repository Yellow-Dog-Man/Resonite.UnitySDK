
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Wobbler2D
// Generated on: čtvrtek 19. února 2026 8:00:24
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Wobbler2D")]
public partial class Wobbler2D : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Vector2> Target;
public UnityEngine.Vector2 Offset;
public UnityEngine.Vector2 Speed;
public UnityEngine.Vector2 Magnitude;
public UnityEngine.Vector2 Seed;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("Speed", Speed.ToResoniteLinkField());
members.Add("Magnitude", Magnitude.ToResoniteLinkField());
members.Add("Seed", Seed.ToResoniteLinkField());
}

}
}
