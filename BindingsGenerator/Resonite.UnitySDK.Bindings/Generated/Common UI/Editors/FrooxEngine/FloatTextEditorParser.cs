
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FloatTextEditorParser
// Generated on: středa 25. února 2026 16:13:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FloatTextEditorParser")]
public partial class FloatTextEditorParser : global::FrooxEngine.TextEditorParser<global::System.Single>

{
    public global::System.Single Min;
public global::System.Single Max;
public global::System.Int32 DecimalPlaces;
public global::System.String StringFormat;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Min", Min.ToResoniteLinkField());
members.Add("Max", Max.ToResoniteLinkField());
members.Add("DecimalPlaces", DecimalPlaces.ToResoniteLinkField());
members.Add("StringFormat", StringFormat.ToResoniteLinkField());
}

}
}
