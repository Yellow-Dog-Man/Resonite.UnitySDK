
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxTexture3D_SpatialVariable
// Generated on: čtvrtek 26. února 2026 10:03:38
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BoxTexture3D_SpatialVariable")]
public partial class BoxTexture3D_SpatialVariable : global::FrooxEngine.BoxSpatialVariable<UnityEngine.ColorX>

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture3D> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture3D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture3D>> Texture_Element = new();
public global::System.Boolean UseNormalizedCoordinates { get => UseNormalizedCoordinates_Element.Data; set => UseNormalizedCoordinates_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseNormalizedCoordinates_Element = new();
public UnityEngine.Vector3 Scale { get => Scale_Element.Data; set => Scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Scale_Element = new();
public UnityEngine.Vector3 Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Offset_Element = new();
public global::Elements.Assets.WrapMode WrapU { get => WrapU_Element.Data; set => WrapU_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.WrapMode>, global::Elements.Assets.WrapMode> WrapU_Element = new();
public global::Elements.Assets.WrapMode WrapV { get => WrapV_Element.Data; set => WrapV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.WrapMode>, global::Elements.Assets.WrapMode> WrapV_Element = new();
public global::Elements.Assets.WrapMode WrapW { get => WrapW_Element.Data; set => WrapW_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.WrapMode>, global::Elements.Assets.WrapMode> WrapW_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture_Element.Data.ToResoniteReference(context));
members.Add("UseNormalizedCoordinates", UseNormalizedCoordinates_Element.Data.ToResoniteLinkField());
members.Add("Scale", Scale_Element.Data.ToResoniteLinkField());
members.Add("Offset", Offset_Element.Data.ToResoniteLinkField());
members.Add("WrapU", WrapU_Element.Data.ToResoniteLinkField());
members.Add("WrapV", WrapV_Element.Data.ToResoniteLinkField());
members.Add("WrapW", WrapW_Element.Data.ToResoniteLinkField());
}

}
}
