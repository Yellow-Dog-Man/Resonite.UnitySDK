
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColorWheelTriangleMesh
// Generated on: čtvrtek 26. února 2026 10:04:42
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ColorWheelTriangleMesh")]
public partial class ColorWheelTriangleMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Hue { get => Hue_Element.Data; set => Hue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Hue_Element = new();
public global::System.Single OuterRadius { get => OuterRadius_Element.Data; set => OuterRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OuterRadius_Element = new();
public global::System.Single InnerRadius { get => InnerRadius_Element.Data; set => InnerRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InnerRadius_Element = new();
public global::System.Int32 RingSegments { get => RingSegments_Element.Data; set => RingSegments_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RingSegments_Element = new();
public UnityEngine.Vector3 CursorPosition { get => CursorPosition_Element.Data; set => CursorPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> CursorPosition_Element = new();
public global::System.Int32 CursorSegments { get => CursorSegments_Element.Data; set => CursorSegments_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> CursorSegments_Element = new();
public UnityEngine.ColorX CursorColor { get => CursorColor_Element.Data; set => CursorColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> CursorColor_Element = new();
public global::System.Single CursorOuterRadius { get => CursorOuterRadius_Element.Data; set => CursorOuterRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CursorOuterRadius_Element = new();
public global::System.Single CursorInnerRadius { get => CursorInnerRadius_Element.Data; set => CursorInnerRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CursorInnerRadius_Element = new();
public global::System.Single CursorZOffset { get => CursorZOffset_Element.Data; set => CursorZOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CursorZOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Hue", Hue_Element.Data.ToResoniteLinkField());
members.Add("OuterRadius", OuterRadius_Element.Data.ToResoniteLinkField());
members.Add("InnerRadius", InnerRadius_Element.Data.ToResoniteLinkField());
members.Add("RingSegments", RingSegments_Element.Data.ToResoniteLinkField());
members.Add("CursorPosition", CursorPosition_Element.Data.ToResoniteLinkField());
members.Add("CursorSegments", CursorSegments_Element.Data.ToResoniteLinkField());
members.Add("CursorColor", CursorColor_Element.Data.ToResoniteLinkField());
members.Add("CursorOuterRadius", CursorOuterRadius_Element.Data.ToResoniteLinkField());
members.Add("CursorInnerRadius", CursorInnerRadius_Element.Data.ToResoniteLinkField());
members.Add("CursorZOffset", CursorZOffset_Element.Data.ToResoniteLinkField());
}

}
}
