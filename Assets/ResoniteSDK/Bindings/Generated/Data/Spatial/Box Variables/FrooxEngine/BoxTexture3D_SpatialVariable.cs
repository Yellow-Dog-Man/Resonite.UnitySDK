
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxTexture3D_SpatialVariable
// Generated on: pátek 13. února 2026 5:51:12
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Texture", new ResoniteLink.Reference() { });
members.Add("UseNormalizedCoordinates", UseNormalizedCoordinates.ToResoniteLinkField());
members.Add("Scale", Scale.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("WrapU", WrapU.ToResoniteLinkField());
members.Add("WrapV", WrapV.ToResoniteLinkField());
members.Add("WrapW", WrapW.ToResoniteLinkField());
}

}
}
