
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyAlignmentSizingAdapter
// Generated on: pátek 13. února 2026 5:52:33
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("LengthScale", LengthScale.ToResoniteLinkField());
members.Add("VelocityScale", VelocityScale.ToResoniteLinkField());
members.Add("Alignment", Alignment.ToResoniteLinkField());
members.Add("ParticleMesh", new ResoniteLink.Reference() { });
members.Add("UsingStretch", UsingStretch.ToResoniteLinkField());
members.Add("RotationSimulator", new ResoniteLink.Reference() { });
members.Add("OrientByVelocity", new ResoniteLink.Reference() { });
members.Add("PivotModule", new ResoniteLink.Reference() { });
members.Add("UseLocalRotation", new ResoniteLink.Reference() { });
members.Add("SizeModifierEnabled", new ResoniteLink.Reference() { });
members.Add("SizeOffsetByvelocityEnabled", new ResoniteLink.Reference() { });
members.Add("OrientUp", new ResoniteLink.Reference() { });
members.Add("LengthSizeMultiplier", new ResoniteLink.Reference() { });
members.Add("VelocitySizeMultiplier", new ResoniteLink.Reference() { });
members.Add("PivotMultiplier", new ResoniteLink.Reference() { });
members.Add("BillboardAlignment", new ResoniteLink.Reference() { });
members.Add("MeshAlignment", new ResoniteLink.Reference() { });
}

}
}
