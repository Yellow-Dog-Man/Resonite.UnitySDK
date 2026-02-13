
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueGradientDriver<>
// Generated on: pátek 13. února 2026 23:23:10
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueGradientDriver<>")]
public partial class ValueGradientDriver<T> : global::FrooxEngine.Component
	

{
    public global::System.Single Progress;
public global::FrooxEngine.IField<T> Target;
public global::System.Boolean Interpolate;
public System.Collections.Generic.List<global::FrooxEngine.ValueGradientDriver<T>.Point> Points;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Progress", Progress.ToResoniteLinkField());
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("Interpolate", Interpolate.ToResoniteLinkField());
members.Add("Points", new ResoniteLink.SyncList()
{
    Elements = Points.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
}

}
}
