
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GridTexture+Grid
// Generated on: pátek 13. února 2026 5:51:09
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Spacing", Spacing.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("Width", Width.ToResoniteLinkField());
members.Add("LineColor", LineColor.ToResoniteLinkField());
}

}
            }
}
