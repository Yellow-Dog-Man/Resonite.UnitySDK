
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RandomEventGenerator
// Generated on: pátek 13. února 2026 23:23:20
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RandomEventGenerator")]
public partial class RandomEventGenerator : global::FrooxEngine.Component

{
    public global::System.Single MinInterval;
public global::System.Single MaxInterval;
public global::FrooxEngine.IPointGenerator RandomPointGenerator;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("MinInterval", MinInterval.ToResoniteLinkField());
members.Add("MaxInterval", MaxInterval.ToResoniteLinkField());
members.Add("RandomPointGenerator", new ResoniteLink.Reference() { });
}

}
}
