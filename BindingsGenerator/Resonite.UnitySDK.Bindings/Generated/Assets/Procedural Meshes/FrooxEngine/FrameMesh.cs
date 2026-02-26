
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FrameMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FrameMesh")]
public partial class FrameMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Vector2 ContentSize { get => ContentSize_Element.Data; set => ContentSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> ContentSize_Element = new();
public global::System.Single Thickness { get => Thickness_Element.Data; set => Thickness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Thickness_Element = new();
public UnityEngine.Vector2 UVScale { get => UVScale_Element.Data; set => UVScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVScale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ContentSize", ContentSize_Element.ToLinkField(context));
members.Add("Thickness", Thickness_Element.ToLinkField(context));
members.Add("UVScale", UVScale_Element.ToLinkField(context));
}

}
}
