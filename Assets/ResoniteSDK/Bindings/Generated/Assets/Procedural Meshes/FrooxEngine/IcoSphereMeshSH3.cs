
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.IcoSphereMeshSH3
// Generated on: úterý 24. února 2026 18:17:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.IcoSphereMeshSH3")]
public partial class IcoSphereMeshSH3 : global::FrooxEngine.IcoSphereMesh

{
    public global::Elements.Core.SphericalHarmonicsL3<UnityEngine.ColorX> Colors;
public global::Elements.Core.SphericalHarmonicsL3<global::System.Single> RadiusMultiplier;
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
