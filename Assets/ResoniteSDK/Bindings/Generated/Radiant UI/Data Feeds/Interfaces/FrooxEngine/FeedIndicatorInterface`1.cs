
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedIndicatorInterface<>
// Generated on: pátek 13. února 2026 5:52:18
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedIndicatorInterface<>")]
public partial class FeedIndicatorInterface<T> : global::FrooxEngine.FeedItemInterface
	

{
    public global::FrooxEngine.IField<T> Value;
public global::FrooxEngine.IField<global::System.String> Format;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Value", new ResoniteLink.Reference() { });
members.Add("Format", new ResoniteLink.Reference() { });
}

}
}
