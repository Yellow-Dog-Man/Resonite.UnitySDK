
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProceduralAssetMetadata<>
// Generated on: čtvrtek 26. února 2026 12:26:52
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProceduralAssetMetadata<>")]
public partial class ProceduralAssetMetadata<A> : global::FrooxEngine.Component
	where A : global::FrooxEngine.Asset

{
    public global::FrooxEngine.ProceduralAssetProvider<A> Asset { get => Asset_Element.Data; set => Asset_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProceduralAssetProvider<A>>, global::FrooxEngine.ProceduralAssetProvider<A>> Asset_Element = new();
public global::System.Int32 UpdateCount { get => UpdateCount_Element.Data; set => UpdateCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> UpdateCount_Element = new();
public global::System.Boolean Error { get => Error_Element.Data; set => Error_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> Error_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Asset", Asset_Element.ToLinkReference(context));
members.Add("UpdateCount", UpdateCount_Element.ToLinkField(context));
members.Add("Error", Error_Element.ToLinkField(context));
}

}
}
