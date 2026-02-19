
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugHapticPoint
// Generated on: čtvrtek 19. února 2026 7:58:58
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugHapticPoint")]
public partial class DebugHapticPoint : global::FrooxEngine.Component, global::FrooxEngine.IHapticSource

{
    public global::System.Single Intensity;
public global::System.Int32 Index;
public global::System.String Position;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Intensity", Intensity.ToResoniteLinkField());
members.Add("Index", Index.ToResoniteLinkField());
members.Add("Position", Position.ToResoniteLinkField());
}

}
}
