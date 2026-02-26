
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MazeGenerator
// Generated on: čtvrtek 26. února 2026 10:03:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MazeGenerator")]
public partial class MazeGenerator : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::System.Int32 Seed { get => Seed_Element.Data; set => Seed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Seed_Element = new();
public UnityEngine.Vector2Int Cells { get => Cells_Element.Data; set => Cells_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> Cells_Element = new();
public UnityEngine.Vector2 WallSize { get => WallSize_Element.Data; set => WallSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> WallSize_Element = new();
public UnityEngine.Vector2Int Point0 { get => Point0_Element.Data; set => Point0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> Point0_Element = new();
public UnityEngine.Vector2Int Point1 { get => Point1_Element.Data; set => Point1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> Point1_Element = new();
public global::FrooxEngine.MaterialProvider Material { get => Material_Element.Data; set => Material_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.MaterialProvider>, global::FrooxEngine.MaterialProvider> Material_Element = new();
public global::System.Boolean Bake { get => Bake_Element.Data; set => Bake_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Bake_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Seed", Seed_Element.Data.ToResoniteLinkField());
members.Add("Cells", Cells_Element.Data.ToResoniteLinkField());
members.Add("WallSize", WallSize_Element.Data.ToResoniteLinkField());
members.Add("Point0", Point0_Element.Data.ToResoniteLinkField());
members.Add("Point1", Point1_Element.Data.ToResoniteLinkField());
members.Add("Material", Material_Element.Data.ToResoniteReference(context));
members.Add("Bake", Bake_Element.Data.ToResoniteLinkField());
}

}
}
