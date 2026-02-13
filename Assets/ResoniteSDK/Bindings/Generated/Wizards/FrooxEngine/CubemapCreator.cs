
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CubemapCreator
// Generated on: pátek 13. února 2026 5:52:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CubemapCreator")]
public partial class CubemapCreator : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector, global::FrooxEngine.IDeveloperInterface

{
    public global::FrooxEngine.CubemapCreator.Rotation TopBottomRotation;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> PosX;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> NegX;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> PosY;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> NegY;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> PosZ;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> NegZ;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TopBottomRotation", TopBottomRotation.ToResoniteLinkField());
members.Add("PosX", new ResoniteLink.Reference() { });
members.Add("NegX", new ResoniteLink.Reference() { });
members.Add("PosY", new ResoniteLink.Reference() { });
members.Add("NegY", new ResoniteLink.Reference() { });
members.Add("PosZ", new ResoniteLink.Reference() { });
members.Add("NegZ", new ResoniteLink.Reference() { });
}

}
}
