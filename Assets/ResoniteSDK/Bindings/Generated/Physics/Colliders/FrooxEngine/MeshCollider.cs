
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshCollider
// Generated on: sobota 14. února 2026 8:57:10
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
