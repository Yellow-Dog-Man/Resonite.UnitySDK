
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserDistanceValueDriver<>
// Generated on: úterý 24. února 2026 18:20:15
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Node", Node.ToResoniteLinkField());
members.Add("Distance", Distance.ToResoniteLinkField());
members.Add("TargetField", TargetField.ToResoniteReference(context));
members.Add("NearValue", NearValue.ToResoniteLinkField());
members.Add("FarValue", FarValue.ToResoniteLinkField());
}

}
}
