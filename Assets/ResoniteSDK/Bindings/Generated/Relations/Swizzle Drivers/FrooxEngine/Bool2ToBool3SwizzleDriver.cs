
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Bool2ToBool3SwizzleDriver
// Generated on: sobota 14. února 2026 8:58:32
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Bool2ToBool3SwizzleDriver")]
public partial class Bool2ToBool3SwizzleDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Vector2Bool> Source;
public global::FrooxEngine.IField<UnityEngine.Vector3Bool> Target;
public global::System.Int32 X;
public global::System.Int32 Y;
public global::System.Int32 Z;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source.ToResoniteReference(context));
members.Add("Target", Target.ToResoniteReference(context));
members.Add("X", X.ToResoniteLinkField());
members.Add("Y", Y.ToResoniteLinkField());
members.Add("Z", Z.ToResoniteLinkField());
}

}
}
