
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GridTexture+Grid
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
    public partial class GridTexture
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GridTexture+Grid")]
public partial class Grid : global::FrooxEngine.SyncObject

{
    public UnityEngine.Vector2Int Spacing { get => Spacing_Element.Data; set => Spacing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> Spacing_Element = new();
public UnityEngine.Vector2Int Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> Offset_Element = new();
public UnityEngine.Vector2Int Width { get => Width_Element.Data; set => Width_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> Width_Element = new();
public UnityEngine.ColorX LineColor { get => LineColor_Element.Data; set => LineColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> LineColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Spacing", Spacing_Element.Data.ToResoniteLinkField());
members.Add("Offset", Offset_Element.Data.ToResoniteLinkField());
members.Add("Width", Width_Element.Data.ToResoniteLinkField());
members.Add("LineColor", LineColor_Element.Data.ToResoniteLinkField());
}

}
            }
}
