
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ParticleBrushTool
// Generated on: čtvrtek 26. února 2026 12:28:06
// Resonite version: 2026.2.26.702
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
    public global::FrooxEngine.Slot TipAnchor { get => TipAnchor_Element.Data; set => TipAnchor_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> TipAnchor_Element = new();
public global::System.Single StrokePointRate { get => StrokePointRate_Element.Data; set => StrokePointRate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StrokePointRate_Element = new();
public global::System.Single ConstantPointRate { get => ConstantPointRate_Element.Data; set => ConstantPointRate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ConstantPointRate_Element = new();
public global::System.Boolean PressureAffectsRate { get => PressureAffectsRate_Element.Data; set => PressureAffectsRate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PressureAffectsRate_Element = new();
public global::System.Boolean PressureAffectsRadius { get => PressureAffectsRadius_Element.Data; set => PressureAffectsRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PressureAffectsRadius_Element = new();
public global::System.Single ParticleSpawnRadius { get => ParticleSpawnRadius_Element.Data; set => ParticleSpawnRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ParticleSpawnRadius_Element = new();
public global::System.Boolean SnapPoints { get => SnapPoints_Element.Data; set => SnapPoints_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SnapPoints_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TipAnchor", TipAnchor_Element.ToLinkReference(context));
members.Add("StrokePointRate", StrokePointRate_Element.ToLinkField(context));
members.Add("ConstantPointRate", ConstantPointRate_Element.ToLinkField(context));
members.Add("PressureAffectsRate", PressureAffectsRate_Element.ToLinkField(context));
members.Add("PressureAffectsRadius", PressureAffectsRadius_Element.ToLinkField(context));
members.Add("ParticleSpawnRadius", ParticleSpawnRadius_Element.ToLinkField(context));
members.Add("SnapPoints", SnapPoints_Element.ToLinkField(context));
}

}
}
