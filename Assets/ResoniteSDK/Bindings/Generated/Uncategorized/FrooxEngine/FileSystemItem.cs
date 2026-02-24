
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FileSystemItem
// Generated on: úterý 24. února 2026 18:20:21
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FileSystemItem")]
public partial class FileSystemItem : global::FrooxEngine.BrowserItem

{
    public global::System.String Name;
public global::System.String BasePath;
public global::FrooxEngine.FileSystemItem.EntryType Type;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Name", Name.ToResoniteLinkField());
members.Add("BasePath", BasePath.ToResoniteLinkField());
members.Add("Type", Type.ToResoniteLinkField());
}

}
}
