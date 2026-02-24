
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyAlignmentSizingAdapter
// Generated on: úterý 24. února 2026 18:20:24
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::System.Single LengthScale;
public global::System.Single VelocityScale;
public global::FrooxEngine.PhotonDust.LegacyParticleAlignment Alignment;
public global::FrooxEngine.AssetRef<global::FrooxEngine.Mesh> ParticleMesh;
public global::System.Boolean UsingStretch;
public global::FrooxEngine.IField<global::System.Boolean> RotationSimulator;
public global::FrooxEngine.IField<global::System.Boolean> OrientByVelocity;
public global::FrooxEngine.IField<global::System.Boolean> PivotModule;
public global::FrooxEngine.IField<global::System.Boolean> UseLocalRotation;
public global::FrooxEngine.IField<global::System.Boolean> SizeModifierEnabled;
public global::FrooxEngine.IField<global::System.Boolean> SizeOffsetByvelocityEnabled;
public global::FrooxEngine.IField<UnityEngine.Vector3> OrientUp;
public global::FrooxEngine.IField<UnityEngine.Vector3> LengthSizeMultiplier;
public global::FrooxEngine.IField<UnityEngine.Vector3> VelocitySizeMultiplier;
public global::FrooxEngine.IField<UnityEngine.Vector3> PivotMultiplier;
public global::FrooxEngine.IField<global::Renderite.Shared.BillboardAlignment> BillboardAlignment;
public global::FrooxEngine.IField<global::Renderite.Shared.MeshAlignment> MeshAlignment;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LengthScale", LengthScale.ToResoniteLinkField());
members.Add("VelocityScale", VelocityScale.ToResoniteLinkField());
members.Add("Alignment", Alignment.ToResoniteLinkField());
members.Add("ParticleMesh", ParticleMesh.ToResoniteReference(context));
members.Add("UsingStretch", UsingStretch.ToResoniteLinkField());
members.Add("RotationSimulator", RotationSimulator.ToResoniteReference(context));
members.Add("OrientByVelocity", OrientByVelocity.ToResoniteReference(context));
members.Add("PivotModule", PivotModule.ToResoniteReference(context));
members.Add("UseLocalRotation", UseLocalRotation.ToResoniteReference(context));
members.Add("SizeModifierEnabled", SizeModifierEnabled.ToResoniteReference(context));
members.Add("SizeOffsetByvelocityEnabled", SizeOffsetByvelocityEnabled.ToResoniteReference(context));
members.Add("OrientUp", OrientUp.ToResoniteReference(context));
members.Add("LengthSizeMultiplier", LengthSizeMultiplier.ToResoniteReference(context));
members.Add("VelocitySizeMultiplier", VelocitySizeMultiplier.ToResoniteReference(context));
members.Add("PivotMultiplier", PivotMultiplier.ToResoniteReference(context));
members.Add("BillboardAlignment", BillboardAlignment.ToResoniteReference(context));
members.Add("MeshAlignment", MeshAlignment.ToResoniteReference(context));
}

}
}
