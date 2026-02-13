
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReflectionProbeSH2
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReflectionProbeSH2")]
public partial class ReflectionProbeSH2 : global::FrooxEngine.RenderableComponent

{
    public global::FrooxEngine.ReflectionProbe Probe;
public global::Elements.Core.SphericalHarmonicsL2<UnityEngine.ColorX> AmbientLight;
public global::System.Single Order0Scale;
public global::System.Single Order1Scale;
public global::System.Single Order2Scale;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Probe", new ResoniteLink.Reference() { });
members.Add("AmbientLight", AmbientLight.ToResoniteLinkField());
members.Add("Order0Scale", Order0Scale.ToResoniteLinkField());
members.Add("Order1Scale", Order1Scale.ToResoniteLinkField());
members.Add("Order2Scale", Order2Scale.ToResoniteLinkField());
}

}
}
