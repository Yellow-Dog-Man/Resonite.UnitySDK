
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RadiantDashProjectionMapper
// Generated on: středa 25. února 2026 16:14:42
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
    public global::FrooxEngine.RadiantDash Dash;
public global::FrooxEngine.Slot Root;
public global::FrooxEngine.CurvedPlaneMesh Mesh;
public global::FrooxEngine.Camera Camera;
public global::FrooxEngine.IField<UnityEngine.Vector2> UVScale;
public global::FrooxEngine.IField<UnityEngine.Vector2> UVOffset;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Dash", Dash.ToResoniteReference(context));
members.Add("Root", Root.ToResoniteReference(context));
members.Add("Mesh", Mesh.ToResoniteReference(context));
members.Add("Camera", Camera.ToResoniteReference(context));
members.Add("UVScale", UVScale.ToResoniteReference(context));
members.Add("UVOffset", UVOffset.ToResoniteReference(context));
}

}
}
