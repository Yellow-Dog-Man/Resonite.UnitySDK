
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RingMesh
// Generated on: čtvrtek 26. února 2026 12:26:51
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RingMesh")]
public partial class RingMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Quaternion Rotation { get => Rotation_Element.Data; set => Rotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> Rotation_Element = new();
public global::System.Int32 Segments { get => Segments_Element.Data; set => Segments_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Segments_Element = new();
public global::System.Single Arc { get => Arc_Element.Data; set => Arc_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Arc_Element = new();
public global::System.Single InnerRadius { get => InnerRadius_Element.Data; set => InnerRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InnerRadius_Element = new();
public global::System.Single OuterRadius { get => OuterRadius_Element.Data; set => OuterRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OuterRadius_Element = new();
public UnityEngine.Vector2 UVScale { get => UVScale_Element.Data; set => UVScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVScale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Rotation", Rotation_Element.ToLinkField(context));
members.Add("Segments", Segments_Element.ToLinkField(context));
members.Add("Arc", Arc_Element.ToLinkField(context));
members.Add("InnerRadius", InnerRadius_Element.ToLinkField(context));
members.Add("OuterRadius", OuterRadius_Element.ToLinkField(context));
members.Add("UVScale", UVScale_Element.ToLinkField(context));
}

}
}
