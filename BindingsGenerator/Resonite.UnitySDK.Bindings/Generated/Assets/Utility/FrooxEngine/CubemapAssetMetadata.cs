
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CubemapAssetMetadata
// Generated on: čtvrtek 26. února 2026 10:03:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CubemapAssetMetadata")]
public partial class CubemapAssetMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Cubemap> Cubemap { get => Cubemap_Element.Data; set => Cubemap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Cubemap>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Cubemap>> Cubemap_Element = new();
public global::System.Int32 Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> Size_Element = new();
public global::System.Boolean HasMipMaps { get => HasMipMaps_Element.Data; set => HasMipMaps_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> HasMipMaps_Element = new();
public global::System.Int32 MipMapCount { get => MipMapCount_Element.Data; set => MipMapCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> MipMapCount_Element = new();
public global::System.Int64 MemoryBytes { get => MemoryBytes_Element.Data; set => MemoryBytes_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int64>, global::System.Int64> MemoryBytes_Element = new();
public global::System.String FormattedMemoryBytes { get => FormattedMemoryBytes_Element.Data; set => FormattedMemoryBytes_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> FormattedMemoryBytes_Element = new();
public global::Renderite.Shared.TextureFormat Format { get => Format_Element.Data; set => Format_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::Renderite.Shared.TextureFormat>, global::Renderite.Shared.TextureFormat> Format_Element = new();
public global::System.String ActualLoadedVariant { get => ActualLoadedVariant_Element.Data; set => ActualLoadedVariant_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> ActualLoadedVariant_Element = new();
public global::Renderite.Shared.ColorProfile Profile { get => Profile_Element.Data; set => Profile_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::Renderite.Shared.ColorProfile>, global::Renderite.Shared.ColorProfile> Profile_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Cubemap", Cubemap_Element.Data.ToResoniteReference(context));
members.Add("Size", Size_Element.Data.ToResoniteLinkField());
members.Add("HasMipMaps", HasMipMaps_Element.Data.ToResoniteLinkField());
members.Add("MipMapCount", MipMapCount_Element.Data.ToResoniteLinkField());
members.Add("MemoryBytes", MemoryBytes_Element.Data.ToResoniteLinkField());
members.Add("FormattedMemoryBytes", FormattedMemoryBytes_Element.Data.ToResoniteLinkField());
members.Add("Format", Format_Element.Data.ToResoniteLinkField());
members.Add("ActualLoadedVariant", ActualLoadedVariant_Element.Data.ToResoniteLinkField());
members.Add("Profile", Profile_Element.Data.ToResoniteLinkField());
}

}
}
