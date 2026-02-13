
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VolumeMeterBase
// Generated on: pátek 13. února 2026 5:51:15
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VolumeMeterBase")]
public abstract partial class VolumeMeterBase : global::FrooxEngine.Component

{
    public global::System.Single Smoothing;
public global::System.Single Power;
public global::FrooxEngine.VolumeMeterMethod Method;
public global::FrooxEngine.IWorldAudioDataSource Source;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Smoothing", Smoothing.ToResoniteLinkField());
members.Add("Power", Power.ToResoniteLinkField());
members.Add("Method", Method.ToResoniteLinkField());
members.Add("Source", new ResoniteLink.Reference() { });
}

}
}
