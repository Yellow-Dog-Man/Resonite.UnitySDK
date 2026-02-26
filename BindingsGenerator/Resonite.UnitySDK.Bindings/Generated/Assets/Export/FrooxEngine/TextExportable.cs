
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextExportable
// Generated on: čtvrtek 26. února 2026 15:07:52
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextExportable")]
public partial class TextExportable : global::FrooxEngine.Component, global::FrooxEngine.IExportable

{
    public global::FrooxEngine.IValue<global::System.String> TextSource { get => TextSource_Element.Data; set => TextSource_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IValue<global::System.String>>, global::FrooxEngine.IValue<global::System.String>> TextSource_Element = new();
public global::System.String Extension { get => Extension_Element.Data; set => Extension_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Extension_Element = new();
public global::System.String Description { get => Description_Element.Data; set => Description_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Description_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TextSource", TextSource_Element.ToLinkReference(context));
members.Add("Extension", Extension_Element.ToLinkField(context));
members.Add("Description", Description_Element.ToLinkField(context));
}

}
}
