
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.IcoSphereMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.IcoSphereMesh")]
public partial class IcoSphereMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius_Element = new();
public global::System.Int32 Subdivisions { get => Subdivisions_Element.Data; set => Subdivisions_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Subdivisions_Element = new();
public global::System.Boolean FlatShading { get => FlatShading_Element.Data; set => FlatShading_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FlatShading_Element = new();
public global::System.Single FlatFaceExtrude { get => FlatFaceExtrude_Element.Data; set => FlatFaceExtrude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FlatFaceExtrude_Element = new();
public global::System.Single FlatFaceScale { get => FlatFaceScale_Element.Data; set => FlatFaceScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FlatFaceScale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius_Element.ToLinkField(context));
members.Add("Subdivisions", Subdivisions_Element.ToLinkField(context));
members.Add("FlatShading", FlatShading_Element.ToLinkField(context));
members.Add("FlatFaceExtrude", FlatFaceExtrude_Element.ToLinkField(context));
members.Add("FlatFaceScale", FlatFaceScale_Element.ToLinkField(context));
}

}
}
