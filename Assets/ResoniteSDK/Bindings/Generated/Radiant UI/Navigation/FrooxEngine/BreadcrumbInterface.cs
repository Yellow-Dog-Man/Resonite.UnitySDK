
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BreadcrumbInterface
// Generated on: sobota 14. února 2026 8:58:32
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
