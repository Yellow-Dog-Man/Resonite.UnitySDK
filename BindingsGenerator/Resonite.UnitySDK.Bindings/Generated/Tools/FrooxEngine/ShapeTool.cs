
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ShapeTool
// Generated on: čtvrtek 26. února 2026 12:28:06
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ShapeTool")]
public partial class ShapeTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.ShapeTool.Shape activeShape { get => activeShape_Element.Data; set => activeShape_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ShapeTool.Shape>, global::FrooxEngine.ShapeTool.Shape> activeShape_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>>, global::FrooxEngine.Slot, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot>> shapes = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material { get => Material_Element.Data; set => Material_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> Material_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("activeShape", activeShape_Element.ToLinkField(context));
members.Add("shapes", shapes.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("Material", Material_Element.ToLinkReference(context));
}

}
}
