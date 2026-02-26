
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SimpleAwayIndicator
// Generated on: čtvrtek 26. února 2026 12:28:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SimpleAwayIndicator")]
public partial class SimpleAwayIndicator : global::FrooxEngine.Component, global::FrooxEngine.IMeshBakeEventReceiver, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.User User { get => User_Element.Data; set => User_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> User_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> AwayMaterial { get => AwayMaterial_Element.Data; set => AwayMaterial_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> AwayMaterial_Element = new();
public global::FrooxEngine.MeshRenderer Renderer { get => Renderer_Element.Data; set => Renderer_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer> Renderer_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncAssetList<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>, Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>>> _oldMaterials = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User_Element.ToLinkReference(context));
members.Add("AwayMaterial", AwayMaterial_Element.ToLinkReference(context));
members.Add("Renderer", Renderer_Element.ToLinkReference(context));
members.Add("_oldMaterials", _oldMaterials.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
