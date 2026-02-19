
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedSliderInterface<>
// Generated on: čtvrtek 19. února 2026 8:00:17
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ReferenceValue", ReferenceValue.ToResoniteReference(context));
members.Add("ReferenceValueCleanupRoot", ReferenceValueCleanupRoot.ToResoniteReference(context));
}

}
}
