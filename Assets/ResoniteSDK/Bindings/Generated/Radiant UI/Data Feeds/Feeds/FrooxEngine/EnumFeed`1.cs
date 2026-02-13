
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EnumFeed<>
// Generated on: pátek 13. února 2026 5:52:18
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.EnumFeed<>")]
public partial class EnumFeed<E> : global::FrooxEngine.Component, global::FrooxEngine.IDataFeedComponent, global::FrooxEngine.IDataFeed
	where E : struct, System.Enum

{
    public global::System.Boolean DisplayOrder;
public global::System.Boolean Distinct;
public global::System.Boolean IncludeObsolete;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("DisplayOrder", DisplayOrder.ToResoniteLinkField());
members.Add("Distinct", Distinct.ToResoniteLinkField());
members.Add("IncludeObsolete", IncludeObsolete.ToResoniteLinkField());
}

}
}
