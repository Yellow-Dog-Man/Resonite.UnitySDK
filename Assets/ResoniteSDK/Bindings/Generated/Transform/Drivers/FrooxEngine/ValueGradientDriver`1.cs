
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueGradientDriver<>
// Generated on: čtvrtek 19. února 2026 8:00:24
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueGradientDriver<>")]
public partial class ValueGradientDriver<T> : global::FrooxEngine.Component
	

{
    public global::System.Single Progress;
public global::FrooxEngine.IField<T> Target;
public global::System.Boolean Interpolate;
public System.Collections.Generic.List<global::FrooxEngine.ValueGradientDriver<T>.Point> Points;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Progress", Progress.ToResoniteLinkField());
members.Add("Target", Target.ToResoniteReference(context));
members.Add("Interpolate", Interpolate.ToResoniteLinkField());
members.Add("Points", new ResoniteLink.SyncList()
{
    Elements = Points.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
