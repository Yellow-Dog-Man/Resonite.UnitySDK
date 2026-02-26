
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetLoadStatus
// Generated on: čtvrtek 26. února 2026 10:04:51
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AssetLoadStatus")]
public partial class AssetLoadStatus : global::FrooxEngine.Component

{
    public global::SyncFieldList<global::FrooxEngine.SyncAssetList<global::FrooxEngine.IAsset>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.IAsset>, Field<global::FrooxEngine.AssetRef<global::FrooxEngine.IAsset>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.IAsset>>> Assets = new();
public global::System.Boolean IsLoaded { get => IsLoaded_Element.Data; set => IsLoaded_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsLoaded_Element = new();
public global::System.Single LoadProgress { get => LoadProgress_Element.Data; set => LoadProgress_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LoadProgress_Element = new();
public global::System.Single ProgressWeight { get => ProgressWeight_Element.Data; set => ProgressWeight_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> ProgressWeight_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Assets", new ResoniteLink.SyncList()
{
    Elements = Assets.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("IsLoaded", IsLoaded_Element.Data.ToResoniteLinkField());
members.Add("LoadProgress", LoadProgress_Element.Data.ToResoniteLinkField());
members.Add("ProgressWeight", ProgressWeight_Element.Data.ToResoniteLinkField());
}

}
}
