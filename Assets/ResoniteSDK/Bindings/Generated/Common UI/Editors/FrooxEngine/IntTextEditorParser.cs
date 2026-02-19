
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.IntTextEditorParser
// Generated on: čtvrtek 19. února 2026 7:58:56
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::System.Int32 Min;
public global::System.Int32 Max;
public global::System.Int32 Increments;
public global::System.String StringFormat;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Min", Min.ToResoniteLinkField());
members.Add("Max", Max.ToResoniteLinkField());
members.Add("Increments", Increments.ToResoniteLinkField());
members.Add("StringFormat", StringFormat.ToResoniteLinkField());
}

}
}
