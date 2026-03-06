
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VolumeExportable
// Generated on: pátek 6. března 2026 14:18:03
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VolumeExportable")]
public partial class VolumeExportable : global::FrooxEngine.Component, global::FrooxEngine.IExportable

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture3D> Volume { get => Volume_Element.Data; set => Volume_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture3D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture3D>> Volume_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Volume", Volume_Element.ToLinkReference(context));
}

}
}
