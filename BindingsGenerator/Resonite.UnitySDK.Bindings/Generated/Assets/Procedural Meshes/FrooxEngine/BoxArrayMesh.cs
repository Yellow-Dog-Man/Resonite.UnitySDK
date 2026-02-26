
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxArrayMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BoxArrayMesh")]
public partial class BoxArrayMesh : global::FrooxEngine.ProceduralMesh

{
    public global::SyncArray<global::FrooxEngine.SyncArray<UnityEngine.Vector3>, UnityEngine.Vector3> Points = new();
public global::SyncArray<global::FrooxEngine.SyncArray<UnityEngine.Vector3>, UnityEngine.Vector3> Sizes = new();
public global::SyncArray<global::FrooxEngine.SyncArray<UnityEngine.Quaternion>, UnityEngine.Quaternion> Rotations = new();
public global::SyncArray<global::FrooxEngine.SyncArray<UnityEngine.Color>, UnityEngine.Color> Colors = new();
public global::Renderite.Shared.ColorProfile ColorsProfile { get => ColorsProfile_Element.Data; set => ColorsProfile_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ColorProfile>, global::Renderite.Shared.ColorProfile> ColorsProfile_Element = new();
public global::SyncArray<global::FrooxEngine.SyncArray<UnityEngine.Vector3>, UnityEngine.Vector3> UV_Scales = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Points", Points.ToLinkArray(context));
members.Add("Sizes", Sizes.ToLinkArray(context));
members.Add("Rotations", Rotations.ToLinkArray(context));
members.Add("Colors", Colors.ToLinkArray(context));
members.Add("ColorsProfile", ColorsProfile_Element.ToLinkField(context));
members.Add("UV_Scales", UV_Scales.ToLinkArray(context));
}

}
}
