
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshUVRaycastPortal
// Generated on: čtvrtek 26. února 2026 15:08:03
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.Single Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Offset_Element = new();
public global::FrooxEngine.IUVToRayConverter RayExit { get => RayExit_Element.Data; set => RayExit_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IUVToRayConverter>, global::FrooxEngine.IUVToRayConverter> RayExit_Element = new();
public UnityEngine.Vector2 UVOffset { get => UVOffset_Element.Data; set => UVOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVOffset_Element = new();
public UnityEngine.Vector2 UVScale { get => UVScale_Element.Data; set => UVScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVScale_Element = new();
public global::System.Boolean RepeatUV { get => RepeatUV_Element.Data; set => RepeatUV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RepeatUV_Element = new();
public global::System.Nullable<global::System.Boolean> OverrideHitTriggers { get => OverrideHitTriggers_Element.Data; set => OverrideHitTriggers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Boolean>>, global::System.Nullable<global::System.Boolean>> OverrideHitTriggers_Element = new();
public global::FrooxEngine.FilterCombineMode FilterMode { get => FilterMode_Element.Data; set => FilterMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.FilterCombineMode>, global::FrooxEngine.FilterCombineMode> FilterMode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Offset", Offset_Element.ToLinkField(context));
members.Add("RayExit", RayExit_Element.ToLinkReference(context));
members.Add("UVOffset", UVOffset_Element.ToLinkField(context));
members.Add("UVScale", UVScale_Element.ToLinkField(context));
members.Add("RepeatUV", RepeatUV_Element.ToLinkField(context));
members.Add("OverrideHitTriggers", OverrideHitTriggers_Element.ToLinkField(context));
members.Add("FilterMode", FilterMode_Element.ToLinkField(context));
}

}
}
