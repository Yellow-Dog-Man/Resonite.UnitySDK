
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DocumentPageMetadata
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DocumentPageMetadata")]
public partial class DocumentPageMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Document> Document { get => Document_Element.Data; set => Document_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Document>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Document>> Document_Element = new();
public global::System.Int32 PageIndex { get => PageIndex_Element.Data; set => PageIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> PageIndex_Element = new();
public UnityEngine.Vector2Double ReferenceSize { get => ReferenceSize_Element.Data; set => ReferenceSize_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Vector2Double>, UnityEngine.Vector2Double> ReferenceSize_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Document", Document_Element.ToLinkReference(context));
members.Add("PageIndex", PageIndex_Element.ToLinkField(context));
members.Add("ReferenceSize", ReferenceSize_Element.ToLinkField(context));
}

}
}
