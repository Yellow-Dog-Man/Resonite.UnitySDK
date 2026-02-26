
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProceduralMeshVertex
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProceduralMeshVertex")]
public partial class ProceduralMeshVertex : global::FrooxEngine.SyncObject

{
    public UnityEngine.Vector3 Position { get => Position_Element.Data; set => Position_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Position_Element = new();
public UnityEngine.Vector2 UV0 { get => UV0_Element.Data; set => UV0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UV0_Element = new();
public UnityEngine.Vector2 UV1 { get => UV1_Element.Data; set => UV1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UV1_Element = new();
public UnityEngine.Vector2 UV2 { get => UV2_Element.Data; set => UV2_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UV2_Element = new();
public UnityEngine.Vector2 UV3 { get => UV3_Element.Data; set => UV3_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UV3_Element = new();
public UnityEngine.ColorX Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color_Element = new();
public UnityEngine.Vector3 Normal { get => Normal_Element.Data; set => Normal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Normal_Element = new();
public UnityEngine.Vector4 Tangent { get => Tangent_Element.Data; set => Tangent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector4>, UnityEngine.Vector4> Tangent_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Position", Position_Element.ToLinkField(context));
members.Add("UV0", UV0_Element.ToLinkField(context));
members.Add("UV1", UV1_Element.ToLinkField(context));
members.Add("UV2", UV2_Element.ToLinkField(context));
members.Add("UV3", UV3_Element.ToLinkField(context));
members.Add("Color", Color_Element.ToLinkField(context));
members.Add("Normal", Normal_Element.ToLinkField(context));
members.Add("Tangent", Tangent_Element.ToLinkField(context));
}

}
}
