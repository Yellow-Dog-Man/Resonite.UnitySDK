
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GridContainerAnimatedEditVisual
// Generated on: sobota 14. února 2026 8:58:44
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Grid", Grid.ToResoniteReference(context));
members.Add("_tiledImage", _tiledImage.ToResoniteReference(context));
members.Add("_tiling", _tiling.ToResoniteReference(context));
members.Add("_offset", _offset.ToResoniteReference(context));
members.Add("_tint", _tint.ToResoniteReference(context));
}

}
}
