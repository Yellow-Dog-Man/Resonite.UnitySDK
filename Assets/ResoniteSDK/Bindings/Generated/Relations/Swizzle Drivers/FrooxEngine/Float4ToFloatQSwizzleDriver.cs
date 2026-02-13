
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Float4ToFloatQSwizzleDriver
// Generated on: pátek 13. února 2026 23:23:03
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Float4ToFloatQSwizzleDriver")]
public partial class Float4ToFloatQSwizzleDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Vector4> Source;
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
