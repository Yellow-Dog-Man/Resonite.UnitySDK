
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProceduralAssetMetadata<>
// Generated on: sobota 14. února 2026 8:57:01
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProceduralAssetMetadata<>")]
public partial class ProceduralAssetMetadata<A> : global::FrooxEngine.Component
	where A : global::FrooxEngine.Asset

{
    public global::FrooxEngine.ProceduralAssetProvider<A> Asset;
public global::System.Int32 UpdateCount;
public global::System.Boolean Error;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Asset", Asset.ToResoniteReference(context));
members.Add("UpdateCount", UpdateCount.ToResoniteLinkField());
members.Add("Error", Error.ToResoniteLinkField());
}

}
}
