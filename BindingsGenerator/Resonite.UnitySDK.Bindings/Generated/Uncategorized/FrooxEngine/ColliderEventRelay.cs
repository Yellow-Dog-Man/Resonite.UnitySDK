
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColliderEventRelay
// Generated on: pátek 6. března 2026 14:19:08
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ColliderEventRelay")]
public partial class ColliderEventRelay : global::FrooxEngine.Component

{
    public global::FrooxEngine.ICollider Collider { get => Collider_Element.Data; set => Collider_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ICollider>, global::FrooxEngine.ICollider> Collider_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Collider", Collider_Element.ToLinkReference(context));
}

}
}
