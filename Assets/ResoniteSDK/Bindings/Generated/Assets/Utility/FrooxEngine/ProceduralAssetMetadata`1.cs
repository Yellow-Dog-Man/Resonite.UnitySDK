
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProceduralAssetMetadata<>
// Generated on: pátek 13. února 2026 23:21:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProceduralAssetMetadata<>")]
public partial class ProceduralAssetMetadata<A> : global::FrooxEngine.Component
	where A : global::FrooxEngine.Asset

{
    public global::FrooxEngine.ProceduralAssetProvider<A> Asset;
public global::System.Int32 UpdateCount;
public global::System.Boolean Error;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Asset", new ResoniteLink.Reference() { });
members.Add("UpdateCount", UpdateCount.ToResoniteLinkField());
members.Add("Error", Error.ToResoniteLinkField());
}

}
}
