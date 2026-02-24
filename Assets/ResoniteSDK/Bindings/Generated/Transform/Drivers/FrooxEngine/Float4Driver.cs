
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Float4Driver
// Generated on: úterý 24. února 2026 18:20:13
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Float4Driver")]
public partial class Float4Driver : global::FrooxEngine.Component

{
    public global::FrooxEngine.Sync<global::System.Single> X;
public global::FrooxEngine.Sync<global::System.Single> Y;
public global::FrooxEngine.Sync<global::System.Single> Z;
public global::FrooxEngine.Sync<global::System.Single> W;
public global::FrooxEngine.IField<UnityEngine.Vector4> Target;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("X", X.ToResoniteReference(context));
members.Add("Y", Y.ToResoniteReference(context));
members.Add("Z", Z.ToResoniteReference(context));
members.Add("W", W.ToResoniteReference(context));
members.Add("Target", Target.ToResoniteReference(context));
}

}
}
