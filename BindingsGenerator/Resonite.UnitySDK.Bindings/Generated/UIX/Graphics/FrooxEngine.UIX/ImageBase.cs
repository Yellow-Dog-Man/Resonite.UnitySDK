
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ImageBase
// Generated on: čtvrtek 26. února 2026 10:04:32
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ImageBase")]
public abstract partial class ImageBase : global::FrooxEngine.UIX.Graphic

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite> Sprite { get => Sprite_Element.Data; set => Sprite_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Sprite>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite>> Sprite_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material { get => Material_Element.Data; set => Material_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> Material_Element = new();
public global::System.Boolean PreserveAspect { get => PreserveAspect_Element.Data; set => PreserveAspect_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PreserveAspect_Element = new();
public global::FrooxEngine.UIX.NineSliceSizing NineSliceSizing { get => NineSliceSizing_Element.Data; set => NineSliceSizing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UIX.NineSliceSizing>, global::FrooxEngine.UIX.NineSliceSizing> NineSliceSizing_Element = new();
public global::System.Boolean FlipHorizontally { get => FlipHorizontally_Element.Data; set => FlipHorizontally_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FlipHorizontally_Element = new();
public global::System.Boolean FlipVertically { get => FlipVertically_Element.Data; set => FlipVertically_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FlipVertically_Element = new();
public global::System.Boolean InteractionTarget { get => InteractionTarget_Element.Data; set => InteractionTarget_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> InteractionTarget_Element = new();
public UnityEngine.Rect FillRect { get => FillRect_Element.Data; set => FillRect_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Rect>, UnityEngine.Rect> FillRect_Element = new();
public global::System.Boolean __legacyZWrite { get => __legacyZWrite_Element.Data; set => __legacyZWrite_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> __legacyZWrite_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Sprite", Sprite_Element.Data.ToResoniteReference(context));
members.Add("Material", Material_Element.Data.ToResoniteReference(context));
members.Add("PreserveAspect", PreserveAspect_Element.Data.ToResoniteLinkField());
members.Add("NineSliceSizing", NineSliceSizing_Element.Data.ToResoniteLinkField());
members.Add("FlipHorizontally", FlipHorizontally_Element.Data.ToResoniteLinkField());
members.Add("FlipVertically", FlipVertically_Element.Data.ToResoniteLinkField());
members.Add("InteractionTarget", InteractionTarget_Element.Data.ToResoniteLinkField());
members.Add("FillRect", FillRect_Element.Data.ToResoniteLinkField());
members.Add("__legacyZWrite", __legacyZWrite_Element.Data.ToResoniteLinkField());
}

}
}
