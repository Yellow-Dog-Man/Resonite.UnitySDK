
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BooleanAssetDriver<>
// Generated on: pátek 13. února 2026 5:51:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BooleanAssetDriver<>")]
public partial class BooleanAssetDriver<A> : global::FrooxEngine.Component
	where A : class, global::FrooxEngine.IAsset

{
    public global::System.Boolean State;
public global::FrooxEngine.AssetRef<A> Target;
public global::FrooxEngine.IAssetProvider<A> FalseTarget;
public global::FrooxEngine.IAssetProvider<A> TrueTarget;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("State", State.ToResoniteLinkField());
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("FalseTarget", new ResoniteLink.Reference() { });
members.Add("TrueTarget", new ResoniteLink.Reference() { });
}

}
}
