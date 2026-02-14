
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CapsuleCollider
// Generated on: sobota 14. února 2026 8:57:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CapsuleCollider")]
public partial class CapsuleCollider : global::FrooxEngine.PrimitiveShapeCollider<global::BepuPhysics.Collidables.Capsule>, global::FrooxEngine.IHighlightable

{
    public global::System.Single Height;
public global::System.Single Radius;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Height", Height.ToResoniteLinkField());
members.Add("Radius", Radius.ToResoniteLinkField());
}

}
}
