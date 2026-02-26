
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.RawImage
// Generated on: čtvrtek 26. února 2026 15:09:09
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.RawImage")]
public partial class RawImage : global::FrooxEngine.UIX.Graphic

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> Texture_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material { get => Material_Element.Data; set => Material_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> Material_Element = new();
public UnityEngine.ColorX Tint { get => Tint_Element.Data; set => Tint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Tint_Element = new();
public UnityEngine.Rect UVRect { get => UVRect_Element.Data; set => UVRect_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Rect>, UnityEngine.Rect> UVRect_Element = new();
public global::Renderite.Shared.RectOrientation Orientation { get => Orientation_Element.Data; set => Orientation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.RectOrientation>, global::Renderite.Shared.RectOrientation> Orientation_Element = new();
public global::System.Boolean PreserveAspect { get => PreserveAspect_Element.Data; set => PreserveAspect_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PreserveAspect_Element = new();
public global::System.Boolean InteractionTarget { get => InteractionTarget_Element.Data; set => InteractionTarget_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> InteractionTarget_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture_Element.ToLinkReference(context));
members.Add("Material", Material_Element.ToLinkReference(context));
members.Add("Tint", Tint_Element.ToLinkField(context));
members.Add("UVRect", UVRect_Element.ToLinkField(context));
members.Add("Orientation", Orientation_Element.ToLinkField(context));
members.Add("PreserveAspect", PreserveAspect_Element.ToLinkField(context));
members.Add("InteractionTarget", InteractionTarget_Element.ToLinkField(context));
}

}
}
