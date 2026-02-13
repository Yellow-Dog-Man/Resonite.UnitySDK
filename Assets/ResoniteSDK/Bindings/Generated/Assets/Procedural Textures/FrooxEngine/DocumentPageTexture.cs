
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DocumentPageTexture
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DocumentPageTexture")]
public partial class DocumentPageTexture : global::FrooxEngine.ProceduralTextureBase

{
    public global::System.Int32 Size;
public global::System.Boolean Mipmaps;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Document> Document;
public global::System.Int32 PageIndex;
public UnityEngine.Rect PageRegion;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Size", Size.ToResoniteLinkField());
members.Add("Mipmaps", Mipmaps.ToResoniteLinkField());
members.Add("Document", new ResoniteLink.Reference() { });
members.Add("PageIndex", PageIndex.ToResoniteLinkField());
members.Add("PageRegion", PageRegion.ToResoniteLinkField());
}

}
}
