
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.IcoSphereMeshSH1
// Generated on: pátek 13. února 2026 23:21:35
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.IcoSphereMeshSH1")]
public partial class IcoSphereMeshSH1 : global::FrooxEngine.IcoSphereMesh

{
    public global::Elements.Core.SphericalHarmonicsL1<UnityEngine.ColorX> Colors;
public global::Elements.Core.SphericalHarmonicsL1<global::System.Single> RadiusMultiplier;
public global::System.Boolean NegativeRadiusInvertsColor;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Colors", Colors.ToResoniteLinkField());
members.Add("RadiusMultiplier", RadiusMultiplier.ToResoniteLinkField());
members.Add("NegativeRadiusInvertsColor", NegativeRadiusInvertsColor.ToResoniteLinkField());
}

}
}
