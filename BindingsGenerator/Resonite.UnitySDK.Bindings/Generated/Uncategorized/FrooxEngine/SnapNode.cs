
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SnapNode
// Generated on: středa 25. února 2026 16:14:43
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
    public global::System.Single SnapRadius;
public global::FrooxEngine.IField<global::System.Single> _colliderRadius;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SnapRadius", SnapRadius.ToResoniteLinkField());
members.Add("_colliderRadius", _colliderRadius.ToResoniteReference(context));
}

}
}
