
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Collider
// Generated on: čtvrtek 26. února 2026 12:26:58
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Collider")]
public abstract partial class Collider : global::FrooxEngine.Component, global::FrooxEngine.ICollider, global::FrooxEngine.ICollidable, global::FrooxEngine.IBounded

{
    public UnityEngine.Vector3 Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Offset_Element = new();
public global::FrooxEngine.ColliderType Type { get => Type_Element.Data; set => Type_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ColliderType>, global::FrooxEngine.ColliderType> Type_Element = new();
public global::System.Single Mass { get => Mass_Element.Data; set => Mass_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Mass_Element = new();
public global::System.Boolean CharacterCollider { get => CharacterCollider_Element.Data; set => CharacterCollider_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CharacterCollider_Element = new();
public global::System.Boolean IgnoreRaycasts { get => IgnoreRaycasts_Element.Data; set => IgnoreRaycasts_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IgnoreRaycasts_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Offset", Offset_Element.ToLinkField(context));
members.Add("Type", Type_Element.ToLinkField(context));
members.Add("Mass", Mass_Element.ToLinkField(context));
members.Add("CharacterCollider", CharacterCollider_Element.ToLinkField(context));
members.Add("IgnoreRaycasts", IgnoreRaycasts_Element.ToLinkField(context));
}

}
}
