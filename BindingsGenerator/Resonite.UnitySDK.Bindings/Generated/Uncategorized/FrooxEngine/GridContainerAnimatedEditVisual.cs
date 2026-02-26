
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GridContainerAnimatedEditVisual
// Generated on: čtvrtek 26. února 2026 10:04:45
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GridContainerAnimatedEditVisual")]
public partial class GridContainerAnimatedEditVisual : global::FrooxEngine.Component

{
    public global::FrooxEngine.GridContainer Grid { get => Grid_Element.Data; set => Grid_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.GridContainer>, global::FrooxEngine.GridContainer> Grid_Element = new();
public global::FrooxEngine.UIX.TiledRawImage _tiledImage { get => _tiledImage_Element.Data; set => _tiledImage_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TiledRawImage>, global::FrooxEngine.UIX.TiledRawImage> _tiledImage_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _tiling { get => _tiling_Element.Data; set => _tiling_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _tiling_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _offset { get => _offset_Element.Data; set => _offset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _offset_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _tint { get => _tint_Element.Data; set => _tint_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _tint_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Grid", Grid_Element.Data.ToResoniteReference(context));
members.Add("_tiledImage", _tiledImage_Element.Data.ToResoniteReference(context));
members.Add("_tiling", _tiling_Element.Data.ToResoniteReference(context));
members.Add("_offset", _offset_Element.Data.ToResoniteReference(context));
members.Add("_tint", _tint_Element.Data.ToResoniteReference(context));
}

}
}
