
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ParticleBrushTool
// Generated on: středa 25. února 2026 16:14:27
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ParticleBrushTool")]
public abstract partial class ParticleBrushTool : global::FrooxEngine.BrushTool

{
    public global::FrooxEngine.Slot TipAnchor;
public global::System.Single StrokePointRate;
public global::System.Single ConstantPointRate;
public global::System.Boolean PressureAffectsRate;
public global::System.Boolean PressureAffectsRadius;
public global::System.Single ParticleSpawnRadius;
public global::System.Boolean SnapPoints;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TipAnchor", TipAnchor.ToResoniteReference(context));
members.Add("StrokePointRate", StrokePointRate.ToResoniteLinkField());
members.Add("ConstantPointRate", ConstantPointRate.ToResoniteLinkField());
members.Add("PressureAffectsRate", PressureAffectsRate.ToResoniteLinkField());
members.Add("PressureAffectsRadius", PressureAffectsRadius.ToResoniteLinkField());
members.Add("ParticleSpawnRadius", ParticleSpawnRadius.ToResoniteLinkField());
members.Add("SnapPoints", SnapPoints.ToResoniteLinkField());
}

}
}
