
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshCollider
// Generated on: úterý 24. února 2026 18:17:54
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeshCollider")]
public partial class MeshCollider : global::FrooxEngine.MeshBasedCollider<global::BepuPhysics.Collidables.Mesh,global::FrooxEngine.MeshColliderData>, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.MeshColliderSidedness Sidedness;
public global::System.Single ActualSpeculativeMargin;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Sidedness", Sidedness.ToResoniteLinkField());
members.Add("ActualSpeculativeMargin", ActualSpeculativeMargin.ToResoniteLinkField());
}

}
}
