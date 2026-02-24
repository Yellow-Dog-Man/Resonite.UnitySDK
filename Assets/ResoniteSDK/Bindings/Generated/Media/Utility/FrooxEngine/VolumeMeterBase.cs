
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VolumeMeterBase
// Generated on: úterý 24. února 2026 18:17:52
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Smoothing", Smoothing.ToResoniteLinkField());
members.Add("Power", Power.ToResoniteLinkField());
members.Add("Method", Method.ToResoniteLinkField());
members.Add("Source", Source.ToResoniteReference(context));
}

}
}
