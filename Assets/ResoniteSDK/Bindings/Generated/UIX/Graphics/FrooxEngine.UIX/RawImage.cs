
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.RawImage
// Generated on: úterý 24. února 2026 18:20:17
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material;
public UnityEngine.ColorX Tint;
public UnityEngine.Rect UVRect;
public global::Renderite.Shared.RectOrientation Orientation;
public global::System.Boolean PreserveAspect;
public global::System.Boolean InteractionTarget;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture.ToResoniteReference(context));
members.Add("Material", Material.ToResoniteReference(context));
members.Add("Tint", Tint.ToResoniteLinkField());
members.Add("UVRect", UVRect.ToResoniteLinkField());
members.Add("Orientation", Orientation.ToResoniteLinkField());
members.Add("PreserveAspect", PreserveAspect.ToResoniteLinkField());
members.Add("InteractionTarget", InteractionTarget.ToResoniteLinkField());
}

}
}
