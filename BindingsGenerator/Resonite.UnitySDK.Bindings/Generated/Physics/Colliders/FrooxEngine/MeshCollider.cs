
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshCollider
// Generated on: čtvrtek 26. února 2026 15:08:02
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.MeshColliderSidedness Sidedness { get => Sidedness_Element.Data; set => Sidedness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.MeshColliderSidedness>, global::FrooxEngine.MeshColliderSidedness> Sidedness_Element = new();
public global::System.Single ActualSpeculativeMargin { get => ActualSpeculativeMargin_Element.Data; set => ActualSpeculativeMargin_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> ActualSpeculativeMargin_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Sidedness", Sidedness_Element.ToLinkField(context));
members.Add("ActualSpeculativeMargin", ActualSpeculativeMargin_Element.ToLinkField(context));
}

}
}
