
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserDistanceValueDriver<>
// Generated on: pátek 13. února 2026 23:23:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserDistanceValueDriver<>")]
public partial class UserDistanceValueDriver<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.UserRoot.UserNode Node;
public global::System.Single Distance;
public global::FrooxEngine.IField<T> TargetField;
public T NearValue;
public T FarValue;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Node", Node.ToResoniteLinkField());
members.Add("Distance", Distance.ToResoniteLinkField());
members.Add("TargetField", new ResoniteLink.Reference() { });
members.Add("NearValue", NearValue.ToResoniteLinkField());
members.Add("FarValue", FarValue.ToResoniteLinkField());
}

}
}
