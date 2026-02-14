
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CubemapCreator
// Generated on: sobota 14. února 2026 8:58:51
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TopBottomRotation", TopBottomRotation.ToResoniteLinkField());
members.Add("PosX", PosX.ToResoniteReference(context));
members.Add("NegX", NegX.ToResoniteReference(context));
members.Add("PosY", PosY.ToResoniteReference(context));
members.Add("NegY", NegY.ToResoniteReference(context));
members.Add("PosZ", PosZ.ToResoniteReference(context));
members.Add("NegZ", NegZ.ToResoniteReference(context));
}

}
}
