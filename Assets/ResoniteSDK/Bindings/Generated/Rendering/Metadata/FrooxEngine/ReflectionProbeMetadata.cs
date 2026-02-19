
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReflectionProbeMetadata
// Generated on: čtvrtek 19. února 2026 8:00:19
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReflectionProbeMetadata")]
public partial class ReflectionProbeMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.ReflectionProbe Probe;
public global::System.Int32 OnChangesRenderCount;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Probe", Probe.ToResoniteReference(context));
members.Add("OnChangesRenderCount", OnChangesRenderCount.ToResoniteLinkField());
}

}
}
