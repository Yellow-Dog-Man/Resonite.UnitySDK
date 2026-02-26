
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FloatTextEditorParser
// Generated on: čtvrtek 26. února 2026 12:26:53
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FloatTextEditorParser")]
public partial class FloatTextEditorParser : global::FrooxEngine.TextEditorParser<global::System.Single>

{
    public global::System.Single Min { get => Min_Element.Data; set => Min_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Min_Element = new();
public global::System.Single Max { get => Max_Element.Data; set => Max_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Max_Element = new();
public global::System.Int32 DecimalPlaces { get => DecimalPlaces_Element.Data; set => DecimalPlaces_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> DecimalPlaces_Element = new();
public global::System.String StringFormat { get => StringFormat_Element.Data; set => StringFormat_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> StringFormat_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Min", Min_Element.ToLinkField(context));
members.Add("Max", Max_Element.ToLinkField(context));
members.Add("DecimalPlaces", DecimalPlaces_Element.ToLinkField(context));
members.Add("StringFormat", StringFormat_Element.ToLinkField(context));
}

}
}
