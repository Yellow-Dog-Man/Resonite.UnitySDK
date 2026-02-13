
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TimeSineDriver
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TimeSineDriver")]
public partial class TimeSineDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.Single> Target;
public global::System.Single Speed;
public global::System.Single Min;
public global::System.Single Max;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("Speed", Speed.ToResoniteLinkField());
members.Add("Min", Min.ToResoniteLinkField());
members.Add("Max", Max.ToResoniteLinkField());
}

}
}
