
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LinearMapper2D
// Generated on: sobota 14. února 2026 8:58:39
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LinearMapper2D")]
public partial class LinearMapper2D : global::FrooxEngine.Component

{
    public global::FrooxEngine.IValue<global::System.Single> Source;
public global::FrooxEngine.IField<UnityEngine.Vector2> Target;
public global::System.Single SourceMin;
public global::System.Single SourceMax;
public UnityEngine.Vector2 TargetMin;
public UnityEngine.Vector2 TargetMax;
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
