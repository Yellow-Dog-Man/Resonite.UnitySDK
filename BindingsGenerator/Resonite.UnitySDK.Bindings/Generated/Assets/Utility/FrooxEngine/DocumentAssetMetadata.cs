
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DocumentAssetMetadata
// Generated on: pondělí 2. března 2026 17:52:26
// Resonite version: 2026.3.2.1000
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DocumentAssetMetadata")]
public partial class DocumentAssetMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Document> Document { get => Document_Element.Data; set => Document_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Document>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Document>> Document_Element = new();
public global::System.Int32 PageCount { get => PageCount_Element.Data; set => PageCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> PageCount_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Document", Document_Element.ToLinkReference(context));
members.Add("PageCount", PageCount_Element.ToLinkField(context));
}

}
}
