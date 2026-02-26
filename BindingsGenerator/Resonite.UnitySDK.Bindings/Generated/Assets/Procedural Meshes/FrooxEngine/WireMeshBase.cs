
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WireMeshBase
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WireMeshBase")]
public abstract partial class WireMeshBase : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Vector3 Point0 { get => Point0_Element.Data; set => Point0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Point0_Element = new();
public UnityEngine.Vector3 Point1 { get => Point1_Element.Data; set => Point1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Point1_Element = new();
public UnityEngine.Vector3 Tangent0 { get => Tangent0_Element.Data; set => Tangent0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Tangent0_Element = new();
public UnityEngine.Vector3 Tangent1 { get => Tangent1_Element.Data; set => Tangent1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Tangent1_Element = new();
public UnityEngine.Quaternion Orientation0 { get => Orientation0_Element.Data; set => Orientation0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> Orientation0_Element = new();
public UnityEngine.Quaternion Orientation1 { get => Orientation1_Element.Data; set => Orientation1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> Orientation1_Element = new();
public global::System.Int32 Steps { get => Steps_Element.Data; set => Steps_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Steps_Element = new();
public global::System.Single Exp { get => Exp_Element.Data; set => Exp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Exp_Element = new();
public UnityEngine.ColorX Color0 { get => Color0_Element.Data; set => Color0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color0_Element = new();
public UnityEngine.ColorX Color1 { get => Color1_Element.Data; set => Color1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color1_Element = new();
public UnityEngine.Vector2 UVScale { get => UVScale_Element.Data; set => UVScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVScale_Element = new();
public UnityEngine.Vector2 UVOffset { get => UVOffset_Element.Data; set => UVOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point0", Point0_Element.ToLinkField(context));
members.Add("Point1", Point1_Element.ToLinkField(context));
members.Add("Tangent0", Tangent0_Element.ToLinkField(context));
members.Add("Tangent1", Tangent1_Element.ToLinkField(context));
members.Add("Orientation0", Orientation0_Element.ToLinkField(context));
members.Add("Orientation1", Orientation1_Element.ToLinkField(context));
members.Add("Steps", Steps_Element.ToLinkField(context));
members.Add("Exp", Exp_Element.ToLinkField(context));
members.Add("Color0", Color0_Element.ToLinkField(context));
members.Add("Color1", Color1_Element.ToLinkField(context));
members.Add("UVScale", UVScale_Element.ToLinkField(context));
members.Add("UVOffset", UVOffset_Element.ToLinkField(context));
}

}
}
