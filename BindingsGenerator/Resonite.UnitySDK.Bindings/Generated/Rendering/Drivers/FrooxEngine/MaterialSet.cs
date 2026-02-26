
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MaterialSet
// Generated on: čtvrtek 26. února 2026 10:04:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MaterialSet")]
public partial class MaterialSet : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::System.Int32 ActiveSetIndex { get => ActiveSetIndex_Element.Data; set => ActiveSetIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> ActiveSetIndex_Element = new();
public global::FrooxEngine.SyncAssetList<global::FrooxEngine.Material> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.SyncAssetList<global::FrooxEngine.Material>>, global::FrooxEngine.SyncAssetList<global::FrooxEngine.Material>> Target_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.SyncAssetList<global::FrooxEngine.Material>>, global::SyncFieldList<global::FrooxEngine.SyncAssetList<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>, Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>>>> Sets = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ActiveSetIndex", ActiveSetIndex_Element.Data.ToResoniteLinkField());
members.Add("Target", Target_Element.Data.ToResoniteReference(context));
members.Add("Sets", new ResoniteLink.SyncList()
{
    Elements = Sets.Data.ConvertList(m => new ResoniteLink.SyncList()
{
    Elements = m.Data.ConvertList(m => m.Data.ToResoniteReference(context))
})
});
}

}
}
