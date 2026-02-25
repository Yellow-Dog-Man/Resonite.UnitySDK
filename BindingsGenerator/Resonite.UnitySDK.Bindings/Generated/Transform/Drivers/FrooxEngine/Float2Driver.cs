
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Float2Driver
// Generated on: středa 25. února 2026 16:14:29
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Float2Driver")]
public partial class Float2Driver : global::FrooxEngine.Component

{
    public global::FrooxEngine.Sync<global::System.Single> X;
public global::FrooxEngine.Sync<global::System.Single> Y;
public global::FrooxEngine.IField<UnityEngine.Vector2> Target;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("X", X.ToResoniteReference(context));
members.Add("Y", Y.ToResoniteReference(context));
members.Add("Target", Target.ToResoniteReference(context));
}

}
}
