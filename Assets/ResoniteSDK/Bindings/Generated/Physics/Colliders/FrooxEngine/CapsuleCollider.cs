
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CapsuleCollider
// Generated on: pátek 13. února 2026 23:21:42
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CapsuleCollider")]
public partial class CapsuleCollider : global::FrooxEngine.PrimitiveShapeCollider<global::BepuPhysics.Collidables.Capsule>, global::FrooxEngine.IHighlightable

{
    public global::System.Single Height;
public global::System.Single Radius;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Height", Height.ToResoniteLinkField());
members.Add("Radius", Radius.ToResoniteLinkField());
}

}
}
