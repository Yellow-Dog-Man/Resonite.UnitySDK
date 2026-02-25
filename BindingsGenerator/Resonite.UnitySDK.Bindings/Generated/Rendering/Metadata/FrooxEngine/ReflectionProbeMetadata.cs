
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReflectionProbeMetadata
// Generated on: středa 25. února 2026 16:14:17
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
