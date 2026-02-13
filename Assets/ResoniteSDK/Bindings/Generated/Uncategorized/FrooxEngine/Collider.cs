
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Collider
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Collider")]
public abstract partial class Collider : global::FrooxEngine.Component, global::FrooxEngine.ICollider, global::FrooxEngine.ICollidable, global::FrooxEngine.IBounded

{
    public UnityEngine.Vector3 Offset;
public global::FrooxEngine.ColliderType Type;
public global::System.Single Mass;
public global::System.Boolean CharacterCollider;
public global::System.Boolean IgnoreRaycasts;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("Type", Type.ToResoniteLinkField());
members.Add("Mass", Mass.ToResoniteLinkField());
members.Add("CharacterCollider", CharacterCollider.ToResoniteLinkField());
members.Add("IgnoreRaycasts", IgnoreRaycasts.ToResoniteLinkField());
}

}
}
