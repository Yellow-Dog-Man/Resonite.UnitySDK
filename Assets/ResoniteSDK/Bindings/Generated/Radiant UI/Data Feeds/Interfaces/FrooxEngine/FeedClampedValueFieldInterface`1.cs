
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedClampedValueFieldInterface<>
// Generated on: pátek 13. února 2026 23:23:01
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedClampedValueFieldInterface<>")]
public partial class FeedClampedValueFieldInterface<T> : global::FrooxEngine.FeedValueItemInterface<T>
	

{
    public global::FrooxEngine.IField<T> Min;
public global::FrooxEngine.IField<T> Max;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Min", new ResoniteLink.Reference() { });
members.Add("Max", new ResoniteLink.Reference() { });
}

}
}
