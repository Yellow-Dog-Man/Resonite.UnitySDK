
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DoubleToFloatCopy
// Generated on: čtvrtek 19. února 2026 8:00:23
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DoubleToFloatCopy")]
public partial class DoubleToFloatCopy : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.Double> Source;
public global::FrooxEngine.IField<global::System.Single> Target;
public global::System.Boolean WriteBack;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source.ToResoniteReference(context));
members.Add("Target", Target.ToResoniteReference(context));
members.Add("WriteBack", WriteBack.ToResoniteLinkField());
}

}
}
