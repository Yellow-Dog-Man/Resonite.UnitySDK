
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FileSystemItem
// Generated on: čtvrtek 26. února 2026 15:09:11
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.String Name { get => Name_Element.Data; set => Name_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Name_Element = new();
public global::System.String BasePath { get => BasePath_Element.Data; set => BasePath_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> BasePath_Element = new();
public global::FrooxEngine.FileSystemItem.EntryType Type { get => Type_Element.Data; set => Type_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.FileSystemItem.EntryType>, global::FrooxEngine.FileSystemItem.EntryType> Type_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Name", Name_Element.ToLinkField(context));
members.Add("BasePath", BasePath_Element.ToLinkField(context));
members.Add("Type", Type_Element.ToLinkField(context));
}

}
}
