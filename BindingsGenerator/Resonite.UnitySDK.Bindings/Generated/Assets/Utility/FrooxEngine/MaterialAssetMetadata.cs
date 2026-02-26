
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MaterialAssetMetadata
// Generated on: čtvrtek 26. února 2026 15:07:56
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material { get => Material_Element.Data; set => Material_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> Material_Element = new();
public global::System.Nullable<global::System.UInt32> VariantIndex { get => VariantIndex_Element.Data; set => VariantIndex_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.UInt32>>, global::System.Nullable<global::System.UInt32>> VariantIndex_Element = new();
public global::System.Nullable<global::System.UInt32> RawVariantIndex { get => RawVariantIndex_Element.Data; set => RawVariantIndex_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.UInt32>>, global::System.Nullable<global::System.UInt32>> RawVariantIndex_Element = new();
public global::System.String VariantID { get => VariantID_Element.Data; set => VariantID_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> VariantID_Element = new();
public global::System.String RawVariantID { get => RawVariantID_Element.Data; set => RawVariantID_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> RawVariantID_Element = new();
public global::System.Boolean WaitingForApply { get => WaitingForApply_Element.Data; set => WaitingForApply_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> WaitingForApply_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Material", Material_Element.ToLinkReference(context));
members.Add("VariantIndex", VariantIndex_Element.ToLinkField(context));
members.Add("RawVariantIndex", RawVariantIndex_Element.ToLinkField(context));
members.Add("VariantID", VariantID_Element.ToLinkField(context));
members.Add("RawVariantID", RawVariantID_Element.ToLinkField(context));
members.Add("WaitingForApply", WaitingForApply_Element.ToLinkField(context));
}

}
}
