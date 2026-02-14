
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxTexture3D_SpatialVariable
// Generated on: sobota 14. února 2026 8:57:05
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture3D> Texture;
public global::System.Boolean UseNormalizedCoordinates;
public UnityEngine.Vector3 Scale;
public UnityEngine.Vector3 Offset;
public global::Elements.Assets.WrapMode WrapU;
public global::Elements.Assets.WrapMode WrapV;
public global::Elements.Assets.WrapMode WrapW;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture.ToResoniteReference(context));
members.Add("UseNormalizedCoordinates", UseNormalizedCoordinates.ToResoniteLinkField());
members.Add("Scale", Scale.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("WrapU", WrapU.ToResoniteLinkField());
members.Add("WrapV", WrapV.ToResoniteLinkField());
members.Add("WrapW", WrapW.ToResoniteLinkField());
}

}
}
