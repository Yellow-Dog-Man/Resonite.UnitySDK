
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.IcoSphereMeshSH3
// Generated on: čtvrtek 26. února 2026 12:26:50
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::Elements.Core.SphericalHarmonicsL3<UnityEngine.ColorX> Colors { get => Colors_Element.Data; set => Colors_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Core.SphericalHarmonicsL3<UnityEngine.ColorX>>, global::Elements.Core.SphericalHarmonicsL3<UnityEngine.ColorX>> Colors_Element = new();
public global::Elements.Core.SphericalHarmonicsL3<global::System.Single> RadiusMultiplier { get => RadiusMultiplier_Element.Data; set => RadiusMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Core.SphericalHarmonicsL3<global::System.Single>>, global::Elements.Core.SphericalHarmonicsL3<global::System.Single>> RadiusMultiplier_Element = new();
public global::System.Boolean NegativeRadiusInvertsColor { get => NegativeRadiusInvertsColor_Element.Data; set => NegativeRadiusInvertsColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> NegativeRadiusInvertsColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Colors", Colors_Element.ToLinkField(context));
members.Add("RadiusMultiplier", RadiusMultiplier_Element.ToLinkField(context));
members.Add("NegativeRadiusInvertsColor", NegativeRadiusInvertsColor_Element.ToLinkField(context));
}

}
}
