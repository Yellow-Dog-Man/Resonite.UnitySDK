
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReflectionProbeSH2
// Generated on: čtvrtek 26. února 2026 10:04:37
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
    public global::FrooxEngine.ReflectionProbe Probe { get => Probe_Element.Data; set => Probe_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.ReflectionProbe>, global::FrooxEngine.ReflectionProbe> Probe_Element = new();
public global::Elements.Core.SphericalHarmonicsL2<UnityEngine.ColorX> AmbientLight { get => AmbientLight_Element.Data; set => AmbientLight_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::Elements.Core.SphericalHarmonicsL2<UnityEngine.ColorX>>, global::Elements.Core.SphericalHarmonicsL2<UnityEngine.ColorX>> AmbientLight_Element = new();
public global::System.Single Order0Scale { get => Order0Scale_Element.Data; set => Order0Scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Order0Scale_Element = new();
public global::System.Single Order1Scale { get => Order1Scale_Element.Data; set => Order1Scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Order1Scale_Element = new();
public global::System.Single Order2Scale { get => Order2Scale_Element.Data; set => Order2Scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Order2Scale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Probe", Probe_Element.Data.ToResoniteReference(context));
members.Add("AmbientLight", AmbientLight_Element.Data.ToResoniteLinkField());
members.Add("Order0Scale", Order0Scale_Element.Data.ToResoniteLinkField());
members.Add("Order1Scale", Order1Scale_Element.Data.ToResoniteLinkField());
members.Add("Order2Scale", Order2Scale_Element.Data.ToResoniteLinkField());
}

}
}
