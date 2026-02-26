
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FontChain
// Generated on: čtvrtek 26. února 2026 12:28:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FontChain")]
public partial class FontChain : global::FrooxEngine.DynamicAssetProvider<global::FrooxEngine.FontSet>

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Font> MainFont { get => MainFont_Element.Data; set => MainFont_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Font>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Font>> MainFont_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncAssetList<global::FrooxEngine.Font>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Font>, Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Font>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Font>>> FallbackFonts = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MainFont", MainFont_Element.ToLinkReference(context));
members.Add("FallbackFonts", FallbackFonts.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
