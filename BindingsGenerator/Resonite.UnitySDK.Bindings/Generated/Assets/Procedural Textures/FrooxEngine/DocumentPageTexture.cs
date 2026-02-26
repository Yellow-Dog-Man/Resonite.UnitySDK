
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DocumentPageTexture
// Generated on: čtvrtek 26. února 2026 12:26:51
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DocumentPageTexture")]
public partial class DocumentPageTexture : global::FrooxEngine.ProceduralTextureBase

{
    public global::System.Int32 Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Size_Element = new();
public global::System.Boolean Mipmaps { get => Mipmaps_Element.Data; set => Mipmaps_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Mipmaps_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Document> Document { get => Document_Element.Data; set => Document_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Document>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Document>> Document_Element = new();
public global::System.Int32 PageIndex { get => PageIndex_Element.Data; set => PageIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> PageIndex_Element = new();
public UnityEngine.Rect PageRegion { get => PageRegion_Element.Data; set => PageRegion_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Rect>, UnityEngine.Rect> PageRegion_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size_Element.ToLinkField(context));
members.Add("Mipmaps", Mipmaps_Element.ToLinkField(context));
members.Add("Document", Document_Element.ToLinkReference(context));
members.Add("PageIndex", PageIndex_Element.ToLinkField(context));
members.Add("PageRegion", PageRegion_Element.ToLinkField(context));
}

}
}
