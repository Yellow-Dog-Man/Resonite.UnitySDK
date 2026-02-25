
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DocumentPageTexture
// Generated on: středa 25. února 2026 16:13:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DocumentPageTexture")]
public partial class DocumentPageTexture : global::FrooxEngine.ProceduralTextureBase

{
    public global::System.Int32 Size;
public global::System.Boolean Mipmaps;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Document> Document;
public global::System.Int32 PageIndex;
public UnityEngine.Rect PageRegion;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size.ToResoniteLinkField());
members.Add("Mipmaps", Mipmaps.ToResoniteLinkField());
members.Add("Document", Document.ToResoniteReference(context));
members.Add("PageIndex", PageIndex.ToResoniteLinkField());
members.Add("PageRegion", PageRegion.ToResoniteLinkField());
}

}
}
