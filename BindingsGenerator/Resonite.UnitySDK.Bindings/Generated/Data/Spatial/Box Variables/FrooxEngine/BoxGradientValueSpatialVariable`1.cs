
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxGradientValueSpatialVariable<>
// Generated on: čtvrtek 26. února 2026 12:26:54
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BoxGradientValueSpatialVariable<>")]
public partial class BoxGradientValueSpatialVariable<T> : global::FrooxEngine.BoxSpatialVariable<T>
	

{
    public T StartValue { get => StartValue_Element.Data; set => StartValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> StartValue_Element = new();
public T EndValue { get => EndValue_Element.Data; set => EndValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> EndValue_Element = new();
public UnityEngine.Vector3 GradientDirection { get => GradientDirection_Element.Data; set => GradientDirection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> GradientDirection_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("StartValue", StartValue_Element.ToLinkField(context));
members.Add("EndValue", EndValue_Element.ToLinkField(context));
members.Add("GradientDirection", GradientDirection_Element.ToLinkField(context));
}

}
}
