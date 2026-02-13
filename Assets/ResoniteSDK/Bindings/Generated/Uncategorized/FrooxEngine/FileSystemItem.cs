
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FileSystemItem
// Generated on: pátek 13. února 2026 23:23:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FileSystemItem")]
public partial class FileSystemItem : global::FrooxEngine.BrowserItem

{
    public global::System.String Name;
public global::System.String BasePath;
public global::FrooxEngine.FileSystemItem.EntryType Type;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Name", Name.ToResoniteLinkField());
members.Add("BasePath", BasePath.ToResoniteLinkField());
members.Add("Type", Type.ToResoniteLinkField());
}

}
}
