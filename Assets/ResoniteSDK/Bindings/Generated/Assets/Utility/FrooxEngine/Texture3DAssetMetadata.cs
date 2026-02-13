
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Texture3DAssetMetadata
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Texture3DAssetMetadata")]
public partial class Texture3DAssetMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture3D> Texture;
public UnityEngine.Vector3Int Size;
public global::System.Int32 Width;
public global::System.Int32 Height;
public global::System.Int32 Depth;
public global::System.Int64 MemoryBytes;
public global::System.String FormattedMemoryBytes;
public global::Renderite.Shared.TextureFormat Format;
public global::System.String ActualLoadedVariant;
public global::Renderite.Shared.ColorProfile Profile;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Texture", new ResoniteLink.Reference() { });
members.Add("Size", Size.ToResoniteLinkField());
members.Add("Width", Width.ToResoniteLinkField());
members.Add("Height", Height.ToResoniteLinkField());
members.Add("Depth", Depth.ToResoniteLinkField());
members.Add("MemoryBytes", MemoryBytes.ToResoniteLinkField());
members.Add("FormattedMemoryBytes", FormattedMemoryBytes.ToResoniteLinkField());
members.Add("Format", Format.ToResoniteLinkField());
members.Add("ActualLoadedVariant", ActualLoadedVariant.ToResoniteLinkField());
members.Add("Profile", Profile.ToResoniteLinkField());
}

}
}
