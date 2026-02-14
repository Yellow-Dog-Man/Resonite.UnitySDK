
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Ulong4ToUlong2SwizzleDriver
// Generated on: sobota 14. února 2026 8:58:33
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Ulong4ToUlong2SwizzleDriver")]
public partial class Ulong4ToUlong2SwizzleDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Vector4Ulong> Source;
public global::FrooxEngine.IField<UnityEngine.Vector2Ulong> Target;
public global::System.Int32 X;
public global::System.Int32 Y;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source.ToResoniteReference(context));
members.Add("Target", Target.ToResoniteReference(context));
members.Add("X", X.ToResoniteLinkField());
members.Add("Y", Y.ToResoniteLinkField());
}

}
}
