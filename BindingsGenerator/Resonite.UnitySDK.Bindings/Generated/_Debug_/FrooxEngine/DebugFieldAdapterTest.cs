
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugFieldAdapterTest
// Generated on: pátek 6. března 2026 14:18:08
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public UnityEngine.ColorX InvertedColor { get => InvertedColor_Element.Data; set => InvertedColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> InvertedColor_Element = new();
public UnityEngine.ColorX SourceColor { get => SourceColor_Element.Data; set => SourceColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SourceColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InvertedColor", InvertedColor_Element.ToLinkField(context));
members.Add("SourceColor", SourceColor_Element.ToLinkField(context));
}

}
}
