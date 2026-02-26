
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RadiantDashProjectionMapper
// Generated on: čtvrtek 26. února 2026 10:04:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RadiantDashProjectionMapper")]
public partial class RadiantDashProjectionMapper : global::FrooxEngine.Component, global::FrooxEngine.UIX.ICanvasPointProjector

{
    public global::FrooxEngine.RadiantDash Dash { get => Dash_Element.Data; set => Dash_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.RadiantDash>, global::FrooxEngine.RadiantDash> Dash_Element = new();
public global::FrooxEngine.Slot Root { get => Root_Element.Data; set => Root_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Root_Element = new();
public global::FrooxEngine.CurvedPlaneMesh Mesh { get => Mesh_Element.Data; set => Mesh_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CurvedPlaneMesh>, global::FrooxEngine.CurvedPlaneMesh> Mesh_Element = new();
public global::FrooxEngine.Camera Camera { get => Camera_Element.Data; set => Camera_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Camera>, global::FrooxEngine.Camera> Camera_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> UVScale { get => UVScale_Element.Data; set => UVScale_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.Vector2>>, global::FrooxEngine.IField<UnityEngine.Vector2>> UVScale_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> UVOffset { get => UVOffset_Element.Data; set => UVOffset_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.Vector2>>, global::FrooxEngine.IField<UnityEngine.Vector2>> UVOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Dash", Dash_Element.Data.ToResoniteReference(context));
members.Add("Root", Root_Element.Data.ToResoniteReference(context));
members.Add("Mesh", Mesh_Element.Data.ToResoniteReference(context));
members.Add("Camera", Camera_Element.Data.ToResoniteReference(context));
members.Add("UVScale", UVScale_Element.Data.ToResoniteReference(context));
members.Add("UVOffset", UVOffset_Element.Data.ToResoniteReference(context));
}

}
}
