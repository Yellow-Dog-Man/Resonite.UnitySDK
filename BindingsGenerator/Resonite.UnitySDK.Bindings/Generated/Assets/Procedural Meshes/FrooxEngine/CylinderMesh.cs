
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CylinderMesh
// Generated on: čtvrtek 26. února 2026 12:26:50
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CylinderMesh")]
public partial class CylinderMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Height { get => Height_Element.Data; set => Height_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Height_Element = new();
public global::System.Single Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius_Element = new();
public global::System.Int32 Sides { get => Sides_Element.Data; set => Sides_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Sides_Element = new();
public global::System.Boolean Caps { get => Caps_Element.Data; set => Caps_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Caps_Element = new();
public global::System.Boolean FlatShading { get => FlatShading_Element.Data; set => FlatShading_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FlatShading_Element = new();
public UnityEngine.Vector2 UVScale { get => UVScale_Element.Data; set => UVScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVScale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Height", Height_Element.ToLinkField(context));
members.Add("Radius", Radius_Element.ToLinkField(context));
members.Add("Sides", Sides_Element.ToLinkField(context));
members.Add("Caps", Caps_Element.ToLinkField(context));
members.Add("FlatShading", FlatShading_Element.ToLinkField(context));
members.Add("UVScale", UVScale_Element.ToLinkField(context));
}

}
}
