
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.RawGraphic
// Generated on: čtvrtek 26. února 2026 15:09:02
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.RawGraphic")]
public partial class RawGraphic : global::FrooxEngine.UIX.Graphic

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material { get => Material_Element.Data; set => Material_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> Material_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.MaterialPropertyBlock> PropertyBlock { get => PropertyBlock_Element.Data; set => PropertyBlock_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.MaterialPropertyBlock>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.MaterialPropertyBlock>> PropertyBlock_Element = new();
public UnityEngine.Rect FillRect { get => FillRect_Element.Data; set => FillRect_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Rect>, UnityEngine.Rect> FillRect_Element = new();
public UnityEngine.ColorX Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color_Element = new();
public UnityEngine.Rect UVRect { get => UVRect_Element.Data; set => UVRect_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Rect>, UnityEngine.Rect> UVRect_Element = new();
public global::Renderite.Shared.RectOrientation Orientation { get => Orientation_Element.Data; set => Orientation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.RectOrientation>, global::Renderite.Shared.RectOrientation> Orientation_Element = new();
public global::System.Nullable<UnityEngine.Vector3> Normal { get => Normal_Element.Data; set => Normal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector3>>, global::System.Nullable<UnityEngine.Vector3>> Normal_Element = new();
public global::System.Nullable<UnityEngine.Vector4> Tangent { get => Tangent_Element.Data; set => Tangent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector4>>, global::System.Nullable<UnityEngine.Vector4>> Tangent_Element = new();
public global::System.Boolean HideWithNoMaterial { get => HideWithNoMaterial_Element.Data; set => HideWithNoMaterial_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HideWithNoMaterial_Element = new();
public global::System.Boolean PreserveUVAspectRatio { get => PreserveUVAspectRatio_Element.Data; set => PreserveUVAspectRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PreserveUVAspectRatio_Element = new();
public global::System.Boolean InteractionTarget { get => InteractionTarget_Element.Data; set => InteractionTarget_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> InteractionTarget_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Material", Material_Element.ToLinkReference(context));
members.Add("PropertyBlock", PropertyBlock_Element.ToLinkReference(context));
members.Add("FillRect", FillRect_Element.ToLinkField(context));
members.Add("Color", Color_Element.ToLinkField(context));
members.Add("UVRect", UVRect_Element.ToLinkField(context));
members.Add("Orientation", Orientation_Element.ToLinkField(context));
members.Add("Normal", Normal_Element.ToLinkField(context));
members.Add("Tangent", Tangent_Element.ToLinkField(context));
members.Add("HideWithNoMaterial", HideWithNoMaterial_Element.ToLinkField(context));
members.Add("PreserveUVAspectRatio", PreserveUVAspectRatio_Element.ToLinkField(context));
members.Add("InteractionTarget", InteractionTarget_Element.ToLinkField(context));
}

}
}
