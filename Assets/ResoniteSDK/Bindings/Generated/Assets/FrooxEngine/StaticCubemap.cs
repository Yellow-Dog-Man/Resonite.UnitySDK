
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticCubemap
// Generated on: sobota 14. února 2026 8:56:54
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
