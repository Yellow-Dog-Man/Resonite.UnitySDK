
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyTrailsRibbonAdapter
// Generated on: čtvrtek 26. února 2026 10:04:46
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.LegacyTrailsRibbonAdapter")]
public partial class LegacyTrailsRibbonAdapter : global::FrooxEngine.Component

{
    public global::FrooxEngine.PhotonDust.LegacyParticleTrailMode TrailsMode { get => TrailsMode_Element.Data; set => TrailsMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PhotonDust.LegacyParticleTrailMode>, global::FrooxEngine.PhotonDust.LegacyParticleTrailMode> TrailsMode_Element = new();
public global::System.Boolean ParticleSizeAffectsTrailWidth { get => ParticleSizeAffectsTrailWidth_Element.Data; set => ParticleSizeAffectsTrailWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ParticleSizeAffectsTrailWidth_Element = new();
public global::System.Boolean InheritTrailColorFromParticle { get => InheritTrailColorFromParticle_Element.Data; set => InheritTrailColorFromParticle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> InheritTrailColorFromParticle_Element = new();
public global::System.Boolean TrailWorldSpace { get => TrailWorldSpace_Element.Data; set => TrailWorldSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> TrailWorldSpace_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> TrailsModule { get => TrailsModule_Element.Data; set => TrailsModule_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> TrailsModule_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> RibbonModule { get => RibbonModule_Element.Data; set => RibbonModule_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> RibbonModule_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> RibbonUseParticleSize { get => RibbonUseParticleSize_Element.Data; set => RibbonUseParticleSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> RibbonUseParticleSize_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> RibbonUseParticleColor { get => RibbonUseParticleColor_Element.Data; set => RibbonUseParticleColor_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> RibbonUseParticleColor_Element = new();
public global::FrooxEngine.IField<global::PhotonDust.TrailParticleInheritance> TrailSizeInheritance { get => TrailSizeInheritance_Element.Data; set => TrailSizeInheritance_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::PhotonDust.TrailParticleInheritance>, global::FrooxEngine.IField<global::PhotonDust.TrailParticleInheritance>> TrailSizeInheritance_Element = new();
public global::FrooxEngine.IField<global::PhotonDust.TrailParticleInheritance> TrailColorInheritance { get => TrailColorInheritance_Element.Data; set => TrailColorInheritance_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::PhotonDust.TrailParticleInheritance>, global::FrooxEngine.IField<global::PhotonDust.TrailParticleInheritance>> TrailColorInheritance_Element = new();
public global::FrooxEngine.RootSpace TrailsSpace { get => TrailsSpace_Element.Data; set => TrailsSpace_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.RootSpace>, global::FrooxEngine.RootSpace> TrailsSpace_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TrailsMode", TrailsMode_Element.Data.ToResoniteLinkField());
members.Add("ParticleSizeAffectsTrailWidth", ParticleSizeAffectsTrailWidth_Element.Data.ToResoniteLinkField());
members.Add("InheritTrailColorFromParticle", InheritTrailColorFromParticle_Element.Data.ToResoniteLinkField());
members.Add("TrailWorldSpace", TrailWorldSpace_Element.Data.ToResoniteLinkField());
members.Add("TrailsModule", TrailsModule_Element.Data.ToResoniteReference(context));
members.Add("RibbonModule", RibbonModule_Element.Data.ToResoniteReference(context));
members.Add("RibbonUseParticleSize", RibbonUseParticleSize_Element.Data.ToResoniteReference(context));
members.Add("RibbonUseParticleColor", RibbonUseParticleColor_Element.Data.ToResoniteReference(context));
members.Add("TrailSizeInheritance", TrailSizeInheritance_Element.Data.ToResoniteReference(context));
members.Add("TrailColorInheritance", TrailColorInheritance_Element.Data.ToResoniteReference(context));
members.Add("TrailsSpace", TrailsSpace_Element.Data.ToResoniteReference(context));
}

}
}
