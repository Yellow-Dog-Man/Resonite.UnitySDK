
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedSliderInterface<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedSliderInterface<>")]
public partial class FeedSliderInterface<T> : global::FrooxEngine.FeedClampedValueFieldInterface<T>
	

{
    public global::FrooxEngine.IField<T> ReferenceValue;
public global::FrooxEngine.Slot ReferenceValueCleanupRoot;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ReferenceValue", new ResoniteLink.Reference() { });
members.Add("ReferenceValueCleanupRoot", new ResoniteLink.Reference() { });
}

}
}
