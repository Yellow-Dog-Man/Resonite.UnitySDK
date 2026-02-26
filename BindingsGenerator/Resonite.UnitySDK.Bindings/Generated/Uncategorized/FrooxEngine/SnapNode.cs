
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SnapNode
// Generated on: čtvrtek 26. února 2026 10:04:48
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SnapNode")]
public partial class SnapNode : global::FrooxEngine.Component

{
    public global::System.Single SnapRadius { get => SnapRadius_Element.Data; set => SnapRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SnapRadius_Element = new();
public global::FrooxEngine.IField<global::System.Single> _colliderRadius { get => _colliderRadius_Element.Data; set => _colliderRadius_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _colliderRadius_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SnapRadius", SnapRadius_Element.Data.ToResoniteLinkField());
members.Add("_colliderRadius", _colliderRadius_Element.Data.ToResoniteReference(context));
}

}
}
