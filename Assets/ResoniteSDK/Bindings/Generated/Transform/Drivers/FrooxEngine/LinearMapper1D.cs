
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LinearMapper1D
// Generated on: úterý 24. února 2026 18:20:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LinearMapper1D")]
public partial class LinearMapper1D : global::FrooxEngine.Component

{
    public global::FrooxEngine.IValue<global::System.Single> Source;
public global::FrooxEngine.IField<global::System.Single> Target;
public global::System.Single SourceMin;
public global::System.Single SourceMax;
public global::System.Single TargetMin;
public global::System.Single TargetMax;
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
