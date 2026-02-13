
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MazeGenerator
// Generated on: pátek 13. února 2026 23:21:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MazeGenerator")]
public partial class MazeGenerator : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::System.Int32 Seed;
public UnityEngine.Vector2Int Cells;
public UnityEngine.Vector2 WallSize;
public UnityEngine.Vector2Int Point0;
public UnityEngine.Vector2Int Point1;
public global::FrooxEngine.MaterialProvider Material;
public global::System.Boolean Bake;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Seed", Seed.ToResoniteLinkField());
members.Add("Cells", Cells.ToResoniteLinkField());
members.Add("WallSize", WallSize.ToResoniteLinkField());
members.Add("Point0", Point0.ToResoniteLinkField());
members.Add("Point1", Point1.ToResoniteLinkField());
members.Add("Material", new ResoniteLink.Reference() { });
members.Add("Bake", Bake.ToResoniteLinkField());
}

}
}
