
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SpriteProvider
// Generated on: čtvrtek 26. února 2026 12:26:46
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SpriteProvider")]
public partial class SpriteProvider : global::FrooxEngine.DynamicAssetProvider<global::FrooxEngine.Sprite>

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> Texture_Element = new();
public UnityEngine.Rect Rect { get => Rect_Element.Data; set => Rect_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Rect>, UnityEngine.Rect> Rect_Element = new();
public UnityEngine.Vector4 Borders { get => Borders_Element.Data; set => Borders_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector4>, UnityEngine.Vector4> Borders_Element = new();
public global::System.Single Scale { get => Scale_Element.Data; set => Scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Scale_Element = new();
public global::System.Single FixedSize { get => FixedSize_Element.Data; set => FixedSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FixedSize_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture_Element.ToLinkReference(context));
members.Add("Rect", Rect_Element.ToLinkField(context));
members.Add("Borders", Borders_Element.ToLinkField(context));
members.Add("Scale", Scale_Element.ToLinkField(context));
members.Add("FixedSize", FixedSize_Element.ToLinkField(context));
}

}
}
