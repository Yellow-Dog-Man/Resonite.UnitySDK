
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VolumeUnlitMaterial+Highlight
// Generated on: čtvrtek 19. února 2026 7:58:52
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class VolumeUnlitMaterial
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VolumeUnlitMaterial+Highlight")]
public partial class Highlight : global::FrooxEngine.VolumeUnlitMaterial.SlicePlane

{
    public global::System.Single Range;
public UnityEngine.ColorX Color;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Range", Range.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
}

}
            }
}
