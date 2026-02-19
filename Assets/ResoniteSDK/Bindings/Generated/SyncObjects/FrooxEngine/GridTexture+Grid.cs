
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GridTexture+Grid
// Generated on: čtvrtek 19. února 2026 7:58:54
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
    public partial class GridTexture
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GridTexture+Grid")]
public partial class Grid : global::FrooxEngine.SyncObject

{
    public UnityEngine.Vector2Int Spacing;
public UnityEngine.Vector2Int Offset;
public UnityEngine.Vector2Int Width;
public UnityEngine.ColorX LineColor;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Spacing", Spacing.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("Width", Width.ToResoniteLinkField());
members.Add("LineColor", LineColor.ToResoniteLinkField());
}

}
            }
}
