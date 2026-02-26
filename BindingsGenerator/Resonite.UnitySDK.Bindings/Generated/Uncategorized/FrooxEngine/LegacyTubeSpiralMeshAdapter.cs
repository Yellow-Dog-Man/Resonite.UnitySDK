
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyTubeSpiralMeshAdapter
// Generated on: čtvrtek 26. února 2026 12:28:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyTubeSpiralMeshAdapter")]
public partial class LegacyTubeSpiralMeshAdapter : global::FrooxEngine.Component

{
    public global::System.Single UpwardTrend { get => UpwardTrend_Element.Data; set => UpwardTrend_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> UpwardTrend_Element = new();
public global::System.Single Length { get => Length_Element.Data; set => Length_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Length_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> EndPoint { get => EndPoint_Element.Data; set => EndPoint_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> EndPoint_Element = new();
public global::FrooxEngine.IField<global::System.Single> CoilCount { get => CoilCount_Element.Data; set => CoilCount_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> CoilCount_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UpwardTrend", UpwardTrend_Element.ToLinkField(context));
members.Add("Length", Length_Element.ToLinkField(context));
members.Add("EndPoint", EndPoint_Element.ToLinkReference(context));
members.Add("CoilCount", CoilCount_Element.ToLinkReference(context));
}

}
}
