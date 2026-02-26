
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ArrowMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ArrowMesh")]
public partial class ArrowMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Vector3 Vector { get => Vector_Element.Data; set => Vector_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Vector_Element = new();
public global::System.Int32 Sides { get => Sides_Element.Data; set => Sides_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Sides_Element = new();
public global::System.Single BodyRadius { get => BodyRadius_Element.Data; set => BodyRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BodyRadius_Element = new();
public global::System.Single HeadRadius { get => HeadRadius_Element.Data; set => HeadRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadRadius_Element = new();
public global::System.Single HeadLength { get => HeadLength_Element.Data; set => HeadLength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadLength_Element = new();
public global::System.Single MinimalBodyLength { get => MinimalBodyLength_Element.Data; set => MinimalBodyLength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinimalBodyLength_Element = new();
public global::System.Boolean SphereOnZero { get => SphereOnZero_Element.Data; set => SphereOnZero_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SphereOnZero_Element = new();
public UnityEngine.Vector2 BodyUVScale { get => BodyUVScale_Element.Data; set => BodyUVScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> BodyUVScale_Element = new();
public UnityEngine.Vector2 BodyUVOffset { get => BodyUVOffset_Element.Data; set => BodyUVOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> BodyUVOffset_Element = new();
public UnityEngine.Vector2 HeadUVScale { get => HeadUVScale_Element.Data; set => HeadUVScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> HeadUVScale_Element = new();
public UnityEngine.Vector2 HeadUVOffset { get => HeadUVOffset_Element.Data; set => HeadUVOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> HeadUVOffset_Element = new();
public UnityEngine.ColorX BaseColor { get => BaseColor_Element.Data; set => BaseColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> BaseColor_Element = new();
public UnityEngine.ColorX TopColor { get => TopColor_Element.Data; set => TopColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> TopColor_Element = new();
public UnityEngine.ColorX HeadColor { get => HeadColor_Element.Data; set => HeadColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> HeadColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Vector", Vector_Element.ToLinkField(context));
members.Add("Sides", Sides_Element.ToLinkField(context));
members.Add("BodyRadius", BodyRadius_Element.ToLinkField(context));
members.Add("HeadRadius", HeadRadius_Element.ToLinkField(context));
members.Add("HeadLength", HeadLength_Element.ToLinkField(context));
members.Add("MinimalBodyLength", MinimalBodyLength_Element.ToLinkField(context));
members.Add("SphereOnZero", SphereOnZero_Element.ToLinkField(context));
members.Add("BodyUVScale", BodyUVScale_Element.ToLinkField(context));
members.Add("BodyUVOffset", BodyUVOffset_Element.ToLinkField(context));
members.Add("HeadUVScale", HeadUVScale_Element.ToLinkField(context));
members.Add("HeadUVOffset", HeadUVOffset_Element.ToLinkField(context));
members.Add("BaseColor", BaseColor_Element.ToLinkField(context));
members.Add("TopColor", TopColor_Element.ToLinkField(context));
members.Add("HeadColor", HeadColor_Element.ToLinkField(context));
}

}
}
