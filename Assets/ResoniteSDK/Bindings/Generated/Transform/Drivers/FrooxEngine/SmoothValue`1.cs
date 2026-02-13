
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SmoothValue<>
// Generated on: pátek 13. února 2026 23:23:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SmoothValue<>")]
public partial class SmoothValue<T> : global::FrooxEngine.Component
	

{
    public T TargetValue;
public global::System.Single Speed;
public global::System.Boolean WriteBack;
public global::FrooxEngine.IField<T> Value;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetValue", TargetValue.ToResoniteLinkField());
members.Add("Speed", Speed.ToResoniteLinkField());
members.Add("WriteBack", WriteBack.ToResoniteLinkField());
members.Add("Value", new ResoniteLink.Reference() { });
}

}
}
