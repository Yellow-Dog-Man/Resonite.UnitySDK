
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BinaryExportable
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BinaryExportable")]
public partial class BinaryExportable : global::FrooxEngine.Component, global::FrooxEngine.IExportable

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Binary> Binary { get => Binary_Element.Data; set => Binary_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Binary>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Binary>> Binary_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Binary", Binary_Element.ToLinkReference(context));
}

}
}
