
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ArrowMesh
// Generated on: pátek 13. února 2026 5:51:07
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ArrowMesh")]
public partial class ArrowMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Vector3 Vector;
public global::System.Int32 Sides;
public global::System.Single BodyRadius;
public global::System.Single HeadRadius;
public global::System.Single HeadLength;
public global::System.Single MinimalBodyLength;
public global::System.Boolean SphereOnZero;
public UnityEngine.Vector2 BodyUVScale;
public UnityEngine.Vector2 BodyUVOffset;
public UnityEngine.Vector2 HeadUVScale;
public UnityEngine.Vector2 HeadUVOffset;
public UnityEngine.ColorX BaseColor;
public UnityEngine.ColorX TopColor;
public UnityEngine.ColorX HeadColor;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Vector", Vector.ToResoniteLinkField());
members.Add("Sides", Sides.ToResoniteLinkField());
members.Add("BodyRadius", BodyRadius.ToResoniteLinkField());
members.Add("HeadRadius", HeadRadius.ToResoniteLinkField());
members.Add("HeadLength", HeadLength.ToResoniteLinkField());
members.Add("MinimalBodyLength", MinimalBodyLength.ToResoniteLinkField());
members.Add("SphereOnZero", SphereOnZero.ToResoniteLinkField());
members.Add("BodyUVScale", BodyUVScale.ToResoniteLinkField());
members.Add("BodyUVOffset", BodyUVOffset.ToResoniteLinkField());
members.Add("HeadUVScale", HeadUVScale.ToResoniteLinkField());
members.Add("HeadUVOffset", HeadUVOffset.ToResoniteLinkField());
members.Add("BaseColor", BaseColor.ToResoniteLinkField());
members.Add("TopColor", TopColor.ToResoniteLinkField());
members.Add("HeadColor", HeadColor.ToResoniteLinkField());
}

}
}
