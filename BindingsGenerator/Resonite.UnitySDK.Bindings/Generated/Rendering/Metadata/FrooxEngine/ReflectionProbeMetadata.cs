
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReflectionProbeMetadata
// Generated on: čtvrtek 26. února 2026 10:04:37
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
    public global::FrooxEngine.ReflectionProbe Probe { get => Probe_Element.Data; set => Probe_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ReflectionProbe>, global::FrooxEngine.ReflectionProbe> Probe_Element = new();
public global::System.Int32 OnChangesRenderCount { get => OnChangesRenderCount_Element.Data; set => OnChangesRenderCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> OnChangesRenderCount_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Probe", Probe_Element.Data.ToResoniteReference(context));
members.Add("OnChangesRenderCount", OnChangesRenderCount_Element.Data.ToResoniteLinkField());
}

}
}
