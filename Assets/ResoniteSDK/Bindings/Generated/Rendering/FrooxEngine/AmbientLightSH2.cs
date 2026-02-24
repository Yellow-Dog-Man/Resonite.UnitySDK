
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AmbientLightSH2
// Generated on: úterý 24. února 2026 18:20:06
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
