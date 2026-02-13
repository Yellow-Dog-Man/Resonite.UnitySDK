
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RadiantDashProjectionMapper
// Generated on: pátek 13. února 2026 5:52:36
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Dash", new ResoniteLink.Reference() { });
members.Add("Root", new ResoniteLink.Reference() { });
members.Add("Mesh", new ResoniteLink.Reference() { });
members.Add("Camera", new ResoniteLink.Reference() { });
members.Add("UVScale", new ResoniteLink.Reference() { });
members.Add("UVOffset", new ResoniteLink.Reference() { });
}

}
}
