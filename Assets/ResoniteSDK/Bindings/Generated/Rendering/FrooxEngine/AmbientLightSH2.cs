
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AmbientLightSH2
// Generated on: čtvrtek 19. února 2026 8:00:19
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AmbientLightSH2")]
public partial class AmbientLightSH2 : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::Elements.Core.SphericalHarmonicsL2<UnityEngine.ColorX> AmbientLight;
public global::System.Boolean IsActive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AmbientLight", AmbientLight.ToResoniteLinkField());
members.Add("IsActive", IsActive.ToResoniteLinkField());
}

}
}
