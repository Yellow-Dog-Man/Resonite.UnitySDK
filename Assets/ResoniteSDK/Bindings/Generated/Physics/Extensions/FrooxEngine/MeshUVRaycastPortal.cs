
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshUVRaycastPortal
// Generated on: pátek 13. února 2026 23:21:42
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeshUVRaycastPortal")]
public partial class MeshUVRaycastPortal : global::FrooxEngine.Component, global::FrooxEngine.IRaycastPortal

{
    public global::System.Single Offset;
public global::FrooxEngine.IUVToRayConverter RayExit;
public UnityEngine.Vector2 UVOffset;
public UnityEngine.Vector2 UVScale;
public global::System.Boolean RepeatUV;
public global::System.Nullable<global::System.Boolean> OverrideHitTriggers;
public global::FrooxEngine.FilterCombineMode FilterMode;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("RayExit", new ResoniteLink.Reference() { });
members.Add("UVOffset", UVOffset.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
members.Add("RepeatUV", RepeatUV.ToResoniteLinkField());
members.Add("OverrideHitTriggers", OverrideHitTriggers.ToResoniteLinkField());
members.Add("FilterMode", FilterMode.ToResoniteLinkField());
}

}
}
