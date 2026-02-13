
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshCollider
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeshCollider")]
public partial class MeshCollider : global::FrooxEngine.MeshBasedCollider<global::BepuPhysics.Collidables.Mesh,global::FrooxEngine.MeshColliderData>, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.MeshColliderSidedness Sidedness;
public global::System.Single ActualSpeculativeMargin;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Sidedness", Sidedness.ToResoniteLinkField());
members.Add("ActualSpeculativeMargin", ActualSpeculativeMargin.ToResoniteLinkField());
}

}
}
