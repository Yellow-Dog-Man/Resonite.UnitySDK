
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueGradientDriver<>+Point
// Generated on: pátek 13. února 2026 5:52:26
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
    public partial class ValueGradientDriver<T>
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueGradientDriver<>+Point")]
public partial class Point : global::FrooxEngine.SyncObject

{
    public global::System.Single Position;
public T Value;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Position", Position.ToResoniteLinkField());
members.Add("Value", Value.ToResoniteLinkField());
}

}
            }
}
