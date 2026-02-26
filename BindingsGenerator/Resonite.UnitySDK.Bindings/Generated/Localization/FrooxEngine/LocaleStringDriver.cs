
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocaleStringDriver
// Generated on: čtvrtek 26. února 2026 15:08:00
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocaleStringDriver")]
public partial class LocaleStringDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.String> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> Target_Element = new();
public global::System.String Key { get => Key_Element.Data; set => Key_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Key_Element = new();
public global::System.String Format { get => Format_Element.Data; set => Format_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Format_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.LocaleResource> Locale { get => Locale_Element.Data; set => Locale_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.LocaleResource>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.LocaleResource>> Locale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("Key", Key_Element.ToLinkField(context));
members.Add("Format", Format_Element.ToLinkField(context));
members.Add("Locale", Locale_Element.ToLinkReference(context));
}

}
}
