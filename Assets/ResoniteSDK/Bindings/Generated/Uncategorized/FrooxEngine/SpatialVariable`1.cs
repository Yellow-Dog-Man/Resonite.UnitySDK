
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SpatialVariable<>
// Generated on: sobota 14. února 2026 8:57:04
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SpatialVariable<>")]
public abstract partial class SpatialVariable<T> : global::FrooxEngine.Component, global::FrooxEngine.ISpatialVariable<T>, global::FrooxEngine.ISpatialVariable
	

{
    public global::System.String VariableName;
public global::System.Int32 Priority;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VariableName", VariableName.ToResoniteLinkField());
members.Add("Priority", Priority.ToResoniteLinkField());
}

}
}
