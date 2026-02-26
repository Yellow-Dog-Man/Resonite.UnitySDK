
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EnumFeed<>
// Generated on: čtvrtek 26. února 2026 10:04:35
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.EnumFeed<>")]
public partial class EnumFeed<E> : global::FrooxEngine.Component, global::FrooxEngine.IDataFeedComponent, global::FrooxEngine.IDataFeed
	where E : struct, System.Enum

{
    public global::System.Boolean DisplayOrder { get => DisplayOrder_Element.Data; set => DisplayOrder_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DisplayOrder_Element = new();
public global::System.Boolean Distinct { get => Distinct_Element.Data; set => Distinct_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Distinct_Element = new();
public global::System.Boolean IncludeObsolete { get => IncludeObsolete_Element.Data; set => IncludeObsolete_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IncludeObsolete_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DisplayOrder", DisplayOrder_Element.Data.ToResoniteLinkField());
members.Add("Distinct", Distinct_Element.Data.ToResoniteLinkField());
members.Add("IncludeObsolete", IncludeObsolete_Element.Data.ToResoniteLinkField());
}

}
}
