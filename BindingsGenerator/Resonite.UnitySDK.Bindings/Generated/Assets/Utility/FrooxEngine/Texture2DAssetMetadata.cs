
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Texture2DAssetMetadata
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Texture2DAssetMetadata")]
public partial class Texture2DAssetMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D>> Texture_Element = new();
public UnityEngine.Vector2Int Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> Size_Element = new();
public global::System.Int32 Width { get => Width_Element.Data; set => Width_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> Width_Element = new();
public global::System.Int32 Height { get => Height_Element.Data; set => Height_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> Height_Element = new();
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
members.Add("Texture", Texture_Element.Data.ToResoniteReference(context));
members.Add("Size", Size_Element.Data.ToResoniteLinkField());
members.Add("Width", Width_Element.Data.ToResoniteLinkField());
members.Add("Height", Height_Element.Data.ToResoniteLinkField());
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
