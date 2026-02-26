
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ParentDataLink<>
// Generated on: čtvrtek 26. února 2026 10:03:38
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ParentDataLink<>")]
public abstract partial class ParentDataLink<T> : global::FrooxEngine.Component
	

{
    public global::System.String MatchTag { get => MatchTag_Element.Data; set => MatchTag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> MatchTag_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MatchTag", MatchTag_Element.Data.ToResoniteLinkField());
}

}
}
