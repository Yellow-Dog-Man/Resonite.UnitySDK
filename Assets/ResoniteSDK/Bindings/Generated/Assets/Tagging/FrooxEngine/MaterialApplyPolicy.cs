
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MaterialApplyPolicy
// Generated on: čtvrtek 19. února 2026 7:58:54
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MaterialApplyPolicy")]
public partial class MaterialApplyPolicy : global::FrooxEngine.Component, global::FrooxEngine.IMaterialApplyPolicy

{
    public global::System.Boolean CanApply;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CanApply", CanApply.ToResoniteLinkField());
}

}
}
