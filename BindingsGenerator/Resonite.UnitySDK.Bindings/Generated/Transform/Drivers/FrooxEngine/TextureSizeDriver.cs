
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextureSizeDriver
// Generated on: čtvrtek 26. února 2026 10:04:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextureSizeDriver")]
public partial class TextureSizeDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> Texture_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> Target_Element = new();
public global::FrooxEngine.TextureSizeDriver.Mode DriveMode { get => DriveMode_Element.Data; set => DriveMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.TextureSizeDriver.Mode>, global::FrooxEngine.TextureSizeDriver.Mode> DriveMode_Element = new();
public UnityEngine.Vector2 Premultiply { get => Premultiply_Element.Data; set => Premultiply_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Premultiply_Element = new();
public UnityEngine.Vector2 Ratio { get => Ratio_Element.Data; set => Ratio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Ratio_Element = new();
public UnityEngine.Vector2 MaxSize { get => MaxSize_Element.Data; set => MaxSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> MaxSize_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture_Element.Data.ToResoniteReference(context));
members.Add("Target", Target_Element.Data.ToResoniteReference(context));
members.Add("DriveMode", DriveMode_Element.Data.ToResoniteLinkField());
members.Add("Premultiply", Premultiply_Element.Data.ToResoniteLinkField());
members.Add("Ratio", Ratio_Element.Data.ToResoniteLinkField());
members.Add("MaxSize", MaxSize_Element.Data.ToResoniteLinkField());
}

}
}
