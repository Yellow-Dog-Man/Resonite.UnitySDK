
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticCubemap
// Generated on: úterý 24. února 2026 18:17:32
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StaticCubemap")]
public partial class StaticCubemap : global::FrooxEngine.StaticTextureProvider<global::FrooxEngine.Cubemap,global::Elements.Assets.BitmapCube,global::Elements.Assets.CubemapMetadata,global::FrooxEngine.CubemapVariantDescriptor>

{
    public global::System.Nullable<global::System.Int32> MaxSize;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxSize", MaxSize.ToResoniteLinkField());
}

}
}
