
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.IcoSphereMeshSH4
// Generated on: čtvrtek 19. února 2026 7:58:53
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.IcoSphereMeshSH4")]
public partial class IcoSphereMeshSH4 : global::FrooxEngine.IcoSphereMesh

{
    public global::Elements.Core.SphericalHarmonicsL4<UnityEngine.ColorX> Colors;
public global::Elements.Core.SphericalHarmonicsL4<global::System.Single> RadiusMultiplier;
public global::System.Boolean NegativeRadiusInvertsColor;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Colors", Colors.ToResoniteLinkField());
members.Add("RadiusMultiplier", RadiusMultiplier.ToResoniteLinkField());
members.Add("NegativeRadiusInvertsColor", NegativeRadiusInvertsColor.ToResoniteLinkField());
}

}
}
