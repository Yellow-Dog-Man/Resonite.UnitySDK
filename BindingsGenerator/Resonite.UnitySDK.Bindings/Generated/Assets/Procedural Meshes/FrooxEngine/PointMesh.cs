
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PointMesh
// Generated on: čtvrtek 26. února 2026 15:07:55
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PointMesh")]
public partial class PointMesh : global::FrooxEngine.ProceduralMesh

{
    public global::SyncArray<global::FrooxEngine.SyncArray<UnityEngine.Vector3>, UnityEngine.Vector3> Points = new();
public global::SyncArray<global::FrooxEngine.SyncArray<UnityEngine.Vector2>, UnityEngine.Vector2> Sizes = new();
public global::SyncArray<global::FrooxEngine.SyncArray<global::System.Single>, global::System.Single> Rotations = new();
public global::SyncArray<global::FrooxEngine.SyncArray<UnityEngine.Color>, UnityEngine.Color> Colors = new();
public global::Renderite.Shared.ColorProfile ColorsProfile { get => ColorsProfile_Element.Data; set => ColorsProfile_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ColorProfile>, global::Renderite.Shared.ColorProfile> ColorsProfile_Element = new();
public global::SyncArray<global::FrooxEngine.SyncArray<UnityEngine.Vector4>, UnityEngine.Vector4> UVs = new();
public global::System.Boolean Sort { get => Sort_Element.Data; set => Sort_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Sort_Element = new();
public UnityEngine.Vector3 SortPoint { get => SortPoint_Element.Data; set => SortPoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> SortPoint_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Points", Points.ToLinkArray(context));
members.Add("Sizes", Sizes.ToLinkArray(context));
members.Add("Rotations", Rotations.ToLinkArray(context));
members.Add("Colors", Colors.ToLinkArray(context));
members.Add("ColorsProfile", ColorsProfile_Element.ToLinkField(context));
members.Add("UVs", UVs.ToLinkArray(context));
members.Add("Sort", Sort_Element.ToLinkField(context));
members.Add("SortPoint", SortPoint_Element.ToLinkField(context));
}

}
}
