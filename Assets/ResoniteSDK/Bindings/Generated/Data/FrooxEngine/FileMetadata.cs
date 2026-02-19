
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FileMetadata
// Generated on: čtvrtek 19. února 2026 7:58:57
// Resonite version: 2026.2.19.471
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FileMetadata")]
public partial class FileMetadata : global::FrooxEngine.Component, global::FrooxEngine.ITouchable, global::FrooxEngine.IItemMetadataSource

{
    public global::System.String Filename;
public global::System.String MIME;
public global::System.Boolean IsProcessing;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Filename", Filename.ToResoniteLinkField());
members.Add("MIME", MIME.ToResoniteLinkField());
members.Add("IsProcessing", IsProcessing.ToResoniteLinkField());
}

}
}
