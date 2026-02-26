
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueGradientDriver<>+Point
// Generated on: čtvrtek 26. února 2026 12:28:07
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
    public partial class ValueGradientDriver<T>
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueGradientDriver<>+Point")]
public partial class Point : global::FrooxEngine.SyncObject

{
    public global::System.Single Position { get => Position_Element.Data; set => Position_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Position_Element = new();
public T Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> Value_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Position", Position_Element.ToLinkField(context));
members.Add("Value", Value_Element.ToLinkField(context));
}

}
            }
}
