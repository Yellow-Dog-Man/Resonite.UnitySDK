
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DocumentPageMetadata
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DocumentPageMetadata")]
public partial class DocumentPageMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Document> Document;
public global::System.Int32 PageIndex;
public UnityEngine.Vector2Double ReferenceSize;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Document", new ResoniteLink.Reference() { });
members.Add("PageIndex", PageIndex.ToResoniteLinkField());
members.Add("ReferenceSize", ReferenceSize.ToResoniteLinkField());
}

}
}
