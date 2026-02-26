
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.IntTextEditorParser
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.IntTextEditorParser")]
public partial class IntTextEditorParser : global::FrooxEngine.TextEditorParser<global::System.Int32>

{
    public global::System.Int32 Min { get => Min_Element.Data; set => Min_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Min_Element = new();
public global::System.Int32 Max { get => Max_Element.Data; set => Max_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Max_Element = new();
public global::System.Int32 Increments { get => Increments_Element.Data; set => Increments_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Increments_Element = new();
public global::System.String StringFormat { get => StringFormat_Element.Data; set => StringFormat_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> StringFormat_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Min", Min_Element.Data.ToResoniteLinkField());
members.Add("Max", Max_Element.Data.ToResoniteLinkField());
members.Add("Increments", Increments_Element.Data.ToResoniteLinkField());
members.Add("StringFormat", StringFormat_Element.Data.ToResoniteLinkField());
}

}
}
