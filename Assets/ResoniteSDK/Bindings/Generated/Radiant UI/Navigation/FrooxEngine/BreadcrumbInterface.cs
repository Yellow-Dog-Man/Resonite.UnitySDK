
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BreadcrumbInterface
// Generated on: čtvrtek 19. února 2026 8:00:17
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BreadcrumbInterface")]
public partial class BreadcrumbInterface : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.String> ItemName;
public global::System.String PathSegment;
public global::System.Int32 ItemDepth;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ItemName", ItemName.ToResoniteReference(context));
members.Add("PathSegment", PathSegment.ToResoniteLinkField());
members.Add("ItemDepth", ItemDepth.ToResoniteLinkField());
}

}
}
