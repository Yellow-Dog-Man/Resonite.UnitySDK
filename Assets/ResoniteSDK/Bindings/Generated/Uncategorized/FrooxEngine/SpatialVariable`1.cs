
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SpatialVariable<>
// Generated on: pátek 13. února 2026 23:21:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SpatialVariable<>")]
public abstract partial class SpatialVariable<T> : global::FrooxEngine.Component, global::FrooxEngine.ISpatialVariable<T>, global::FrooxEngine.ISpatialVariable
	

{
    public global::System.String VariableName;
public global::System.Int32 Priority;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("VariableName", VariableName.ToResoniteLinkField());
members.Add("Priority", Priority.ToResoniteLinkField());
}

}
}
