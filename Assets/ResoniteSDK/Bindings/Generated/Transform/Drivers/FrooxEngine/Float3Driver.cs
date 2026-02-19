
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Float3Driver
// Generated on: čtvrtek 19. února 2026 8:00:23
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Float3Driver")]
public partial class Float3Driver : global::FrooxEngine.Component

{
    public global::FrooxEngine.Sync<global::System.Single> X;
public global::FrooxEngine.Sync<global::System.Single> Y;
public global::FrooxEngine.Sync<global::System.Single> Z;
public global::FrooxEngine.IField<UnityEngine.Vector3> Target;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("X", X.ToResoniteReference(context));
members.Add("Y", Y.ToResoniteReference(context));
members.Add("Z", Z.ToResoniteReference(context));
members.Add("Target", Target.ToResoniteReference(context));
}

}
}
