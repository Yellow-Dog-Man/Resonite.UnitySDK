
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.RawGraphic
// Generated on: úterý 24. února 2026 18:20:03
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.RawGraphic")]
public partial class RawGraphic : global::FrooxEngine.UIX.Graphic

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.MaterialPropertyBlock> PropertyBlock;
public UnityEngine.Rect FillRect;
public UnityEngine.ColorX Color;
public UnityEngine.Rect UVRect;
public global::Renderite.Shared.RectOrientation Orientation;
public global::System.Nullable<UnityEngine.Vector3> Normal;
public global::System.Nullable<UnityEngine.Vector4> Tangent;
public global::System.Boolean HideWithNoMaterial;
public global::System.Boolean PreserveUVAspectRatio;
public global::System.Boolean InteractionTarget;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Material", Material.ToResoniteReference(context));
members.Add("PropertyBlock", PropertyBlock.ToResoniteReference(context));
members.Add("FillRect", FillRect.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("UVRect", UVRect.ToResoniteLinkField());
members.Add("Orientation", Orientation.ToResoniteLinkField());
members.Add("Normal", Normal.ToResoniteLinkField());
members.Add("Tangent", Tangent.ToResoniteLinkField());
members.Add("HideWithNoMaterial", HideWithNoMaterial.ToResoniteLinkField());
members.Add("PreserveUVAspectRatio", PreserveUVAspectRatio.ToResoniteLinkField());
members.Add("InteractionTarget", InteractionTarget.ToResoniteLinkField());
}

}
}
