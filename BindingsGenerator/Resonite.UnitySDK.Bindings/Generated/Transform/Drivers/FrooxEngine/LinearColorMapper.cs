
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LinearColorMapper
// Generated on: středa 25. února 2026 16:14:29
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LinearColorMapper")]
public partial class LinearColorMapper : global::FrooxEngine.Component

{
    public global::FrooxEngine.IValue<global::System.Single> Source;
public global::FrooxEngine.IField<UnityEngine.ColorX> Target;
public global::System.Single SourceMin;
public global::System.Single SourceMax;
public UnityEngine.ColorX TargetMin;
public UnityEngine.ColorX TargetMax;
public global::System.Boolean AllowReverseMapping;
public global::System.Boolean Clamp;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source.ToResoniteReference(context));
members.Add("Target", Target.ToResoniteReference(context));
members.Add("SourceMin", SourceMin.ToResoniteLinkField());
members.Add("SourceMax", SourceMax.ToResoniteLinkField());
members.Add("TargetMin", TargetMin.ToResoniteLinkField());
members.Add("TargetMax", TargetMax.ToResoniteLinkField());
members.Add("AllowReverseMapping", AllowReverseMapping.ToResoniteLinkField());
members.Add("Clamp", Clamp.ToResoniteLinkField());
}

}
}
