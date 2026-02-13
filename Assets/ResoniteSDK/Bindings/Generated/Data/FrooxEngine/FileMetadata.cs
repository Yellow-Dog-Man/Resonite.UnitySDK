
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FileMetadata
// Generated on: pátek 13. února 2026 23:21:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FileMetadata")]
public partial class FileMetadata : global::FrooxEngine.Component, global::FrooxEngine.ITouchable, global::FrooxEngine.IItemMetadataSource

{
    public global::System.String Filename;
public global::System.String MIME;
public global::System.Boolean IsProcessing;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Filename", Filename.ToResoniteLinkField());
members.Add("MIME", MIME.ToResoniteLinkField());
members.Add("IsProcessing", IsProcessing.ToResoniteLinkField());
}

}
}
