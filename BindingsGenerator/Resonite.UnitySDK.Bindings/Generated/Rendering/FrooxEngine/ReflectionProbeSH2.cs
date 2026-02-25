
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReflectionProbeSH2
// Generated on: středa 25. února 2026 16:14:17
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReflectionProbeSH2")]
public partial class ReflectionProbeSH2 : global::FrooxEngine.RenderableComponent

{
    public global::FrooxEngine.ReflectionProbe Probe;
public global::Elements.Core.SphericalHarmonicsL2<UnityEngine.ColorX> AmbientLight;
public global::System.Single Order0Scale;
public global::System.Single Order1Scale;
public global::System.Single Order2Scale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Probe", Probe.ToResoniteReference(context));
members.Add("AmbientLight", AmbientLight.ToResoniteLinkField());
members.Add("Order0Scale", Order0Scale.ToResoniteLinkField());
members.Add("Order1Scale", Order1Scale.ToResoniteLinkField());
members.Add("Order2Scale", Order2Scale.ToResoniteLinkField());
}

}
}
