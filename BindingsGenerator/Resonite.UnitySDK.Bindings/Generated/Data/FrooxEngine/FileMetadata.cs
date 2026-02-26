
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FileMetadata
// Generated on: čtvrtek 26. února 2026 10:03:38
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FileMetadata")]
public partial class FileMetadata : global::FrooxEngine.Component, global::FrooxEngine.ITouchable, global::FrooxEngine.IItemMetadataSource

{
    public global::System.String Filename { get => Filename_Element.Data; set => Filename_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Filename_Element = new();
public global::System.String MIME { get => MIME_Element.Data; set => MIME_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> MIME_Element = new();
public global::System.Boolean IsProcessing { get => IsProcessing_Element.Data; set => IsProcessing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsProcessing_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Filename", Filename_Element.Data.ToResoniteLinkField());
members.Add("MIME", MIME_Element.Data.ToResoniteLinkField());
members.Add("IsProcessing", IsProcessing_Element.Data.ToResoniteLinkField());
}

}
}
