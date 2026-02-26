
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TubeBoxMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TubeBoxMesh")]
public partial class TubeBoxMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Vector3 Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Size_Element = new();
public global::System.Single TubeRadius { get => TubeRadius_Element.Data; set => TubeRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TubeRadius_Element = new();
public global::System.Int32 SegmentPoints { get => SegmentPoints_Element.Data; set => SegmentPoints_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> SegmentPoints_Element = new();
public UnityEngine.Vector2 UVScale { get => UVScale_Element.Data; set => UVScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVScale_Element = new();
public UnityEngine.Vector2 UVOffset { get => UVOffset_Element.Data; set => UVOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size_Element.ToLinkField(context));
members.Add("TubeRadius", TubeRadius_Element.ToLinkField(context));
members.Add("SegmentPoints", SegmentPoints_Element.ToLinkField(context));
members.Add("UVScale", UVScale_Element.ToLinkField(context));
members.Add("UVOffset", UVOffset_Element.ToLinkField(context));
}

}
}
