
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabbableSetterTool
// Generated on: čtvrtek 19. února 2026 8:00:22
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabbableSetterTool")]
public partial class GrabbableSetterTool : global::FrooxEngine.BuilderActionTool

{
    public global::System.Boolean SetScalable;
public global::FrooxEngine.IField<UnityEngine.ColorX> _indicatorColor;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SetScalable", SetScalable.ToResoniteLinkField());
members.Add("_indicatorColor", _indicatorColor.ToResoniteReference(context));
}

}
}
