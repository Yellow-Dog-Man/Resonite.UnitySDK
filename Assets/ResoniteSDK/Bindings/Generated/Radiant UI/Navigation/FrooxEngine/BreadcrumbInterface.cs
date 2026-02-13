
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BreadcrumbInterface
// Generated on: pátek 13. února 2026 23:23:02
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ItemName", new ResoniteLink.Reference() { });
members.Add("PathSegment", PathSegment.ToResoniteLinkField());
members.Add("ItemDepth", ItemDepth.ToResoniteLinkField());
}

}
}
