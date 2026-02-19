
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MaterialAssetMetadata
// Generated on: čtvrtek 19. února 2026 7:58:54
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MaterialAssetMetadata")]
public partial class MaterialAssetMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material;
public global::System.Nullable<global::System.UInt32> VariantIndex;
public global::System.Nullable<global::System.UInt32> RawVariantIndex;
public global::System.String VariantID;
public global::System.String RawVariantID;
public global::System.Boolean WaitingForApply;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Material", Material.ToResoniteReference(context));
members.Add("VariantIndex", VariantIndex.ToResoniteLinkField());
members.Add("RawVariantIndex", RawVariantIndex.ToResoniteLinkField());
members.Add("VariantID", VariantID.ToResoniteLinkField());
members.Add("RawVariantID", RawVariantID.ToResoniteLinkField());
members.Add("WaitingForApply", WaitingForApply.ToResoniteLinkField());
}

}
}
