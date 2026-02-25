
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TimeIntDriver
// Generated on: středa 25. února 2026 16:14:31
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TimeIntDriver")]
public partial class TimeIntDriver : global::FrooxEngine.Component

{
    public global::System.Single Scale;
public global::System.Int32 Repeat;
public global::System.Boolean PingPong;
public global::FrooxEngine.IField<global::System.Int32> Target;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Scale", Scale.ToResoniteLinkField());
members.Add("Repeat", Repeat.ToResoniteLinkField());
members.Add("PingPong", PingPong.ToResoniteLinkField());
members.Add("Target", Target.ToResoniteReference(context));
}

}
}
