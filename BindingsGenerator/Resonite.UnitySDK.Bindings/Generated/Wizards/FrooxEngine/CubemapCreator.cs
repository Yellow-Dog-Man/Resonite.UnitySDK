
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CubemapCreator
// Generated on: čtvrtek 26. února 2026 15:09:17
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CubemapCreator")]
public partial class CubemapCreator : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector, global::FrooxEngine.IDeveloperInterface

{
    public global::FrooxEngine.CubemapCreator.Rotation TopBottomRotation { get => TopBottomRotation_Element.Data; set => TopBottomRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CubemapCreator.Rotation>, global::FrooxEngine.CubemapCreator.Rotation> TopBottomRotation_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> PosX { get => PosX_Element.Data; set => PosX_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D>> PosX_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> NegX { get => NegX_Element.Data; set => NegX_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D>> NegX_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> PosY { get => PosY_Element.Data; set => PosY_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D>> PosY_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> NegY { get => NegY_Element.Data; set => NegY_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D>> NegY_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> PosZ { get => PosZ_Element.Data; set => PosZ_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D>> PosZ_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> NegZ { get => NegZ_Element.Data; set => NegZ_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D>> NegZ_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TopBottomRotation", TopBottomRotation_Element.ToLinkField(context));
members.Add("PosX", PosX_Element.ToLinkReference(context));
members.Add("NegX", NegX_Element.ToLinkReference(context));
members.Add("PosY", PosY_Element.ToLinkReference(context));
members.Add("NegY", NegY_Element.ToLinkReference(context));
members.Add("PosZ", PosZ_Element.ToLinkReference(context));
members.Add("NegZ", NegZ_Element.ToLinkReference(context));
}

}
}
