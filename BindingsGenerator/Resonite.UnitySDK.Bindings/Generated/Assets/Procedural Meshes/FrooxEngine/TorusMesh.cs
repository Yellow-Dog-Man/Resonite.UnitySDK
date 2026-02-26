
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TorusMesh
// Generated on: čtvrtek 26. února 2026 15:07:56
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TorusMesh")]
public partial class TorusMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Int32 MinorSegments { get => MinorSegments_Element.Data; set => MinorSegments_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MinorSegments_Element = new();
public global::System.Int32 MajorSegments { get => MajorSegments_Element.Data; set => MajorSegments_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MajorSegments_Element = new();
public global::System.Single MajorRadius { get => MajorRadius_Element.Data; set => MajorRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MajorRadius_Element = new();
public global::System.Single MinorRadius { get => MinorRadius_Element.Data; set => MinorRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinorRadius_Element = new();
public UnityEngine.Vector2 UVScale { get => UVScale_Element.Data; set => UVScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVScale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinorSegments", MinorSegments_Element.ToLinkField(context));
members.Add("MajorSegments", MajorSegments_Element.ToLinkField(context));
members.Add("MajorRadius", MajorRadius_Element.ToLinkField(context));
members.Add("MinorRadius", MinorRadius_Element.ToLinkField(context));
members.Add("UVScale", UVScale_Element.ToLinkField(context));
}

}
}
