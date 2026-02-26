
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.QuadMesh
// Generated on: čtvrtek 26. února 2026 10:03:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.QuadMesh")]
public partial class QuadMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Quaternion Rotation { get => Rotation_Element.Data; set => Rotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> Rotation_Element = new();
public UnityEngine.Vector2 Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Size_Element = new();
public UnityEngine.Vector2 UVOffset { get => UVOffset_Element.Data; set => UVOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVOffset_Element = new();
public UnityEngine.Vector2 UVScale { get => UVScale_Element.Data; set => UVScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVScale_Element = new();
public global::System.Boolean ScaleUVWithSize { get => ScaleUVWithSize_Element.Data; set => ScaleUVWithSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ScaleUVWithSize_Element = new();
public global::System.Boolean DualSided { get => DualSided_Element.Data; set => DualSided_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DualSided_Element = new();
public global::System.Boolean UseVertexColors { get => UseVertexColors_Element.Data; set => UseVertexColors_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseVertexColors_Element = new();
public UnityEngine.ColorX UpperLeftColor { get => UpperLeftColor_Element.Data; set => UpperLeftColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> UpperLeftColor_Element = new();
public UnityEngine.ColorX LowerLeftColor { get => LowerLeftColor_Element.Data; set => LowerLeftColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> LowerLeftColor_Element = new();
public UnityEngine.ColorX LowerRightColor { get => LowerRightColor_Element.Data; set => LowerRightColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> LowerRightColor_Element = new();
public UnityEngine.ColorX UpperRightColor { get => UpperRightColor_Element.Data; set => UpperRightColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> UpperRightColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Rotation", Rotation_Element.Data.ToResoniteLinkField());
members.Add("Size", Size_Element.Data.ToResoniteLinkField());
members.Add("UVOffset", UVOffset_Element.Data.ToResoniteLinkField());
members.Add("UVScale", UVScale_Element.Data.ToResoniteLinkField());
members.Add("ScaleUVWithSize", ScaleUVWithSize_Element.Data.ToResoniteLinkField());
members.Add("DualSided", DualSided_Element.Data.ToResoniteLinkField());
members.Add("UseVertexColors", UseVertexColors_Element.Data.ToResoniteLinkField());
members.Add("UpperLeftColor", UpperLeftColor_Element.Data.ToResoniteLinkField());
members.Add("LowerLeftColor", LowerLeftColor_Element.Data.ToResoniteLinkField());
members.Add("LowerRightColor", LowerRightColor_Element.Data.ToResoniteLinkField());
members.Add("UpperRightColor", UpperRightColor_Element.Data.ToResoniteLinkField());
}

}
}
