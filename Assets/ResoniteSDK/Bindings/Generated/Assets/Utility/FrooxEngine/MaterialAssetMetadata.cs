
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MaterialAssetMetadata
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MaterialAssetMetadata")]
public partial class MaterialAssetMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material;
public global::System.Nullable<global::System.UInt32> VariantIndex;
public global::System.Nullable<global::System.UInt32> RawVariantIndex;
public global::System.String VariantID;
public global::System.String RawVariantID;
public global::System.Boolean WaitingForApply;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Material", new ResoniteLink.Reference() { });
members.Add("VariantIndex", VariantIndex.ToResoniteLinkField());
members.Add("RawVariantIndex", RawVariantIndex.ToResoniteLinkField());
members.Add("VariantID", VariantID.ToResoniteLinkField());
members.Add("RawVariantID", RawVariantID.ToResoniteLinkField());
members.Add("WaitingForApply", WaitingForApply.ToResoniteLinkField());
}

}
}
