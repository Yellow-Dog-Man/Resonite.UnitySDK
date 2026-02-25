
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BooleanAssetDriver<>
// Generated on: středa 25. února 2026 16:13:05
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("State", State.ToResoniteLinkField());
members.Add("Target", Target.ToResoniteReference(context));
members.Add("FalseTarget", FalseTarget.ToResoniteReference(context));
members.Add("TrueTarget", TrueTarget.ToResoniteReference(context));
}

}
}
