
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ShapeTool
// Generated on: čtvrtek 19. února 2026 8:00:22
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ShapeTool")]
public partial class ShapeTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.ShapeTool.Shape activeShape;
public System.Collections.Generic.List<global::FrooxEngine.Slot> shapes;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("activeShape", activeShape.ToResoniteLinkField());
members.Add("shapes", new ResoniteLink.SyncList()
{
    Elements = shapes.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("Material", Material.ToResoniteReference(context));
}

}
}
