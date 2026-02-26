
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HollowConeMesh
// Generated on: čtvrtek 26. února 2026 10:03:35
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HollowConeMesh")]
public partial class HollowConeMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Height { get => Height_Element.Data; set => Height_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Height_Element = new();
public global::System.Single OuterRadiusBase { get => OuterRadiusBase_Element.Data; set => OuterRadiusBase_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OuterRadiusBase_Element = new();
public global::System.Single InnerRadiusBase { get => InnerRadiusBase_Element.Data; set => InnerRadiusBase_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InnerRadiusBase_Element = new();
public global::System.Single OuterRadiusTop { get => OuterRadiusTop_Element.Data; set => OuterRadiusTop_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OuterRadiusTop_Element = new();
public global::System.Single InnerRadiusTop { get => InnerRadiusTop_Element.Data; set => InnerRadiusTop_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InnerRadiusTop_Element = new();
public global::System.Int32 Segments { get => Segments_Element.Data; set => Segments_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Segments_Element = new();
public UnityEngine.Vector2 UVScale { get => UVScale_Element.Data; set => UVScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVScale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Height", Height_Element.Data.ToResoniteLinkField());
members.Add("OuterRadiusBase", OuterRadiusBase_Element.Data.ToResoniteLinkField());
members.Add("InnerRadiusBase", InnerRadiusBase_Element.Data.ToResoniteLinkField());
members.Add("OuterRadiusTop", OuterRadiusTop_Element.Data.ToResoniteLinkField());
members.Add("InnerRadiusTop", InnerRadiusTop_Element.Data.ToResoniteLinkField());
members.Add("Segments", Segments_Element.Data.ToResoniteLinkField());
members.Add("UVScale", UVScale_Element.Data.ToResoniteLinkField());
}

}
}
