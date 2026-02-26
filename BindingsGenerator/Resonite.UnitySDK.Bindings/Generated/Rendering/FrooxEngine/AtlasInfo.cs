
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AtlasInfo
// Generated on: čtvrtek 26. února 2026 10:03:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AtlasInfo")]
public partial class AtlasInfo : global::FrooxEngine.Component

{
    public UnityEngine.Vector2Int GridSize { get => GridSize_Element.Data; set => GridSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> GridSize_Element = new();
public global::System.Int32 GridFrames { get => GridFrames_Element.Data; set => GridFrames_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> GridFrames_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("GridSize", GridSize_Element.Data.ToResoniteLinkField());
members.Add("GridFrames", GridFrames_Element.Data.ToResoniteLinkField());
}

}
}
