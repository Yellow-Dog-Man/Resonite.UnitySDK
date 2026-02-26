
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyAlignmentSizingAdapter
// Generated on: čtvrtek 26. února 2026 15:09:12
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.LegacyAlignmentSizingAdapter")]
public partial class LegacyAlignmentSizingAdapter : global::FrooxEngine.Component

{
    public global::System.Single LengthScale { get => LengthScale_Element.Data; set => LengthScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LengthScale_Element = new();
public global::System.Single VelocityScale { get => VelocityScale_Element.Data; set => VelocityScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VelocityScale_Element = new();
public global::FrooxEngine.PhotonDust.LegacyParticleAlignment Alignment { get => Alignment_Element.Data; set => Alignment_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PhotonDust.LegacyParticleAlignment>, global::FrooxEngine.PhotonDust.LegacyParticleAlignment> Alignment_Element = new();
public global::FrooxEngine.AssetRef<global::FrooxEngine.Mesh> ParticleMesh { get => ParticleMesh_Element.Data; set => ParticleMesh_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.AssetRef<global::FrooxEngine.Mesh>>, global::FrooxEngine.AssetRef<global::FrooxEngine.Mesh>> ParticleMesh_Element = new();
public global::System.Boolean UsingStretch { get => UsingStretch_Element.Data; set => UsingStretch_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> UsingStretch_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> RotationSimulator { get => RotationSimulator_Element.Data; set => RotationSimulator_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> RotationSimulator_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> OrientByVelocity { get => OrientByVelocity_Element.Data; set => OrientByVelocity_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> OrientByVelocity_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> PivotModule { get => PivotModule_Element.Data; set => PivotModule_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> PivotModule_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> UseLocalRotation { get => UseLocalRotation_Element.Data; set => UseLocalRotation_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> UseLocalRotation_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> SizeModifierEnabled { get => SizeModifierEnabled_Element.Data; set => SizeModifierEnabled_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> SizeModifierEnabled_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> SizeOffsetByvelocityEnabled { get => SizeOffsetByvelocityEnabled_Element.Data; set => SizeOffsetByvelocityEnabled_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> SizeOffsetByvelocityEnabled_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> OrientUp { get => OrientUp_Element.Data; set => OrientUp_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> OrientUp_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> LengthSizeMultiplier { get => LengthSizeMultiplier_Element.Data; set => LengthSizeMultiplier_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> LengthSizeMultiplier_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> VelocitySizeMultiplier { get => VelocitySizeMultiplier_Element.Data; set => VelocitySizeMultiplier_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> VelocitySizeMultiplier_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> PivotMultiplier { get => PivotMultiplier_Element.Data; set => PivotMultiplier_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> PivotMultiplier_Element = new();
public global::FrooxEngine.IField<global::Renderite.Shared.BillboardAlignment> BillboardAlignment { get => BillboardAlignment_Element.Data; set => BillboardAlignment_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::Renderite.Shared.BillboardAlignment>, global::FrooxEngine.IField<global::Renderite.Shared.BillboardAlignment>> BillboardAlignment_Element = new();
public global::FrooxEngine.IField<global::Renderite.Shared.MeshAlignment> MeshAlignment { get => MeshAlignment_Element.Data; set => MeshAlignment_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::Renderite.Shared.MeshAlignment>, global::FrooxEngine.IField<global::Renderite.Shared.MeshAlignment>> MeshAlignment_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LengthScale", LengthScale_Element.ToLinkField(context));
members.Add("VelocityScale", VelocityScale_Element.ToLinkField(context));
members.Add("Alignment", Alignment_Element.ToLinkField(context));
members.Add("ParticleMesh", ParticleMesh_Element.ToLinkReference(context));
members.Add("UsingStretch", UsingStretch_Element.ToLinkField(context));
members.Add("RotationSimulator", RotationSimulator_Element.ToLinkReference(context));
members.Add("OrientByVelocity", OrientByVelocity_Element.ToLinkReference(context));
members.Add("PivotModule", PivotModule_Element.ToLinkReference(context));
members.Add("UseLocalRotation", UseLocalRotation_Element.ToLinkReference(context));
members.Add("SizeModifierEnabled", SizeModifierEnabled_Element.ToLinkReference(context));
members.Add("SizeOffsetByvelocityEnabled", SizeOffsetByvelocityEnabled_Element.ToLinkReference(context));
members.Add("OrientUp", OrientUp_Element.ToLinkReference(context));
members.Add("LengthSizeMultiplier", LengthSizeMultiplier_Element.ToLinkReference(context));
members.Add("VelocitySizeMultiplier", VelocitySizeMultiplier_Element.ToLinkReference(context));
members.Add("PivotMultiplier", PivotMultiplier_Element.ToLinkReference(context));
members.Add("BillboardAlignment", BillboardAlignment_Element.ToLinkReference(context));
members.Add("MeshAlignment", MeshAlignment_Element.ToLinkReference(context));
}

}
}
