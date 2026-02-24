
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ImageBase
// Generated on: úterý 24. února 2026 18:19:55
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ImageBase")]
public abstract partial class ImageBase : global::FrooxEngine.UIX.Graphic

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite> Sprite;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material;
public global::System.Boolean PreserveAspect;
public global::FrooxEngine.UIX.NineSliceSizing NineSliceSizing;
public global::System.Boolean FlipHorizontally;
public global::System.Boolean FlipVertically;
public global::System.Boolean InteractionTarget;
public UnityEngine.Rect FillRect;
public global::System.Boolean __legacyZWrite;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Sprite", Sprite.ToResoniteReference(context));
members.Add("Material", Material.ToResoniteReference(context));
members.Add("PreserveAspect", PreserveAspect.ToResoniteLinkField());
members.Add("NineSliceSizing", NineSliceSizing.ToResoniteLinkField());
members.Add("FlipHorizontally", FlipHorizontally.ToResoniteLinkField());
members.Add("FlipVertically", FlipVertically.ToResoniteLinkField());
members.Add("InteractionTarget", InteractionTarget.ToResoniteLinkField());
members.Add("FillRect", FillRect.ToResoniteLinkField());
members.Add("__legacyZWrite", __legacyZWrite.ToResoniteLinkField());
}

}
}
