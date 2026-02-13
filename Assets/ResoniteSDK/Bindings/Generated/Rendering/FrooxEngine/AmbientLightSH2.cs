
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AmbientLightSH2
// Generated on: pátek 13. února 2026 5:52:21
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AmbientLightSH2")]
public partial class AmbientLightSH2 : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::Elements.Core.SphericalHarmonicsL2<UnityEngine.ColorX> AmbientLight;
public global::System.Boolean IsActive;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("AmbientLight", AmbientLight.ToResoniteLinkField());
members.Add("IsActive", IsActive.ToResoniteLinkField());
}

}
}
