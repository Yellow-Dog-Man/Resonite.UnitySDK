
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ShapeTool
// Generated on: pátek 13. února 2026 5:52:24
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ShapeTool")]
public partial class ShapeTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.ShapeTool.Shape activeShape;
public System.Collections.Generic.List<global::FrooxEngine.Slot> shapes;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("activeShape", activeShape.ToResoniteLinkField());
members.Add("shapes", new ResoniteLink.SyncList()
{
    Elements = shapes.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("Material", new ResoniteLink.Reference() { });
}

}
}
