
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GridContainerAnimatedEditVisual
// Generated on: pátek 13. února 2026 23:23:14
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GridContainerAnimatedEditVisual")]
public partial class GridContainerAnimatedEditVisual : global::FrooxEngine.Component

{
    public global::FrooxEngine.GridContainer Grid;
public global::FrooxEngine.UIX.TiledRawImage _tiledImage;
public global::FrooxEngine.IField<UnityEngine.Vector2> _tiling;
public global::FrooxEngine.IField<UnityEngine.Vector2> _offset;
public global::FrooxEngine.IField<UnityEngine.ColorX> _tint;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Grid", new ResoniteLink.Reference() { });
members.Add("_tiledImage", new ResoniteLink.Reference() { });
members.Add("_tiling", new ResoniteLink.Reference() { });
members.Add("_offset", new ResoniteLink.Reference() { });
members.Add("_tint", new ResoniteLink.Reference() { });
}

}
}
