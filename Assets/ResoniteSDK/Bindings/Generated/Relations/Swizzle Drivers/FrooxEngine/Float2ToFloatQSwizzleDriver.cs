
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Float2ToFloatQSwizzleDriver
// Generated on: pátek 13. února 2026 5:52:20
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Float2ToFloatQSwizzleDriver")]
public partial class Float2ToFloatQSwizzleDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Vector2> Source;
public global::FrooxEngine.IField<UnityEngine.Quaternion> Target;
public global::System.Int32 X;
public global::System.Int32 Y;
public global::System.Int32 Z;
public global::System.Int32 W;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Source", new ResoniteLink.Reference() { });
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("X", X.ToResoniteLinkField());
members.Add("Y", Y.ToResoniteLinkField());
members.Add("Z", Z.ToResoniteLinkField());
members.Add("W", W.ToResoniteLinkField());
}

}
}
