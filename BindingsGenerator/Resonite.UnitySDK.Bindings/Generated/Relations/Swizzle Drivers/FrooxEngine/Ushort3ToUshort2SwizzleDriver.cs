
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Ushort3ToUshort2SwizzleDriver
// Generated on: středa 25. února 2026 16:14:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Ushort3ToUshort2SwizzleDriver")]
public partial class Ushort3ToUshort2SwizzleDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Vector3Ushort> Source;
public global::FrooxEngine.IField<UnityEngine.Vector2Ushort> Target;
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
