
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StringConcatenationDriver
// Generated on: čtvrtek 26. února 2026 10:04:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StringConcatenationDriver")]
public partial class StringConcatenationDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.String> TargetString { get => TargetString_Element.Data; set => TargetString_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> TargetString_Element = new();
public global::System.String Separator { get => Separator_Element.Data; set => Separator_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Separator_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.String>, global::System.String, Field<global::FrooxEngine.Sync<global::System.String>, global::System.String>> Strings = new();
public global::System.Boolean NullOutputWhenAllAreNull { get => NullOutputWhenAllAreNull_Element.Data; set => NullOutputWhenAllAreNull_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> NullOutputWhenAllAreNull_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetString", TargetString_Element.Data.ToResoniteReference(context));
members.Add("Separator", Separator_Element.Data.ToResoniteLinkField());
members.Add("Strings", new ResoniteLink.SyncList()
{
    Elements = Strings.Data.ConvertList(m => m.Data.ToResoniteLinkField())
});
members.Add("NullOutputWhenAllAreNull", NullOutputWhenAllAreNull_Element.Data.ToResoniteLinkField());
}

}
}
