
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicField<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicField<>")]
public partial class DynamicField<T> : global::FrooxEngine.DynamicVariableBase<T>
	

{
    public global::FrooxEngine.IField<T> TargetField;
public global::System.Boolean OverrideOnLink;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetField", new ResoniteLink.Reference() { });
members.Add("OverrideOnLink", OverrideOnLink.ToResoniteLinkField());
}

}
}
