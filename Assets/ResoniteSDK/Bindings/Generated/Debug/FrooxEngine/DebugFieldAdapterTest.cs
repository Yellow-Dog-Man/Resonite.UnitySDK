
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugFieldAdapterTest
// Generated on: úterý 24. února 2026 18:17:48
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugFieldAdapterTest")]
public partial class DebugFieldAdapterTest : global::FrooxEngine.Component

{
    public UnityEngine.ColorX InvertedColor;
public UnityEngine.ColorX SourceColor;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InvertedColor", InvertedColor.ToResoniteLinkField());
members.Add("SourceColor", SourceColor.ToResoniteLinkField());
}

}
}
