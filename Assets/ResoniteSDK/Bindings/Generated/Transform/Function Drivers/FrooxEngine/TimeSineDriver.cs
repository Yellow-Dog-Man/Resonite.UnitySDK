
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TimeSineDriver
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TimeSineDriver")]
public partial class TimeSineDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.Single> Target;
public global::System.Single Speed;
public global::System.Single Min;
public global::System.Single Max;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("Speed", Speed.ToResoniteLinkField());
members.Add("Min", Min.ToResoniteLinkField());
members.Add("Max", Max.ToResoniteLinkField());
}

}
}
