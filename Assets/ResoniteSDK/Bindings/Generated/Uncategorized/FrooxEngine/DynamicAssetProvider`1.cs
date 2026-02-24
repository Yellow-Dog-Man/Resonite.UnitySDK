
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicAssetProvider<>
// Generated on: úterý 24. února 2026 18:17:32
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicAssetProvider<>")]
public abstract partial class DynamicAssetProvider<A> : global::FrooxEngine.AssetProvider<A>
	where A : global::FrooxEngine.Asset

{
    public global::System.Boolean HighPriorityIntegration;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HighPriorityIntegration", HighPriorityIntegration.ToResoniteLinkField());
}

}
}
