
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BoxMesh")]
public partial class BoxMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Vector3 Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Size_Element = new();
public UnityEngine.Vector3 UVScale { get => UVScale_Element.Data; set => UVScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> UVScale_Element = new();
public global::System.Boolean ScaleUVWithSize { get => ScaleUVWithSize_Element.Data; set => ScaleUVWithSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ScaleUVWithSize_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size_Element.ToLinkField(context));
members.Add("UVScale", UVScale_Element.ToLinkField(context));
members.Add("ScaleUVWithSize", ScaleUVWithSize_Element.ToLinkField(context));
}

}
}
