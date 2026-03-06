
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugTangentSpace
// Generated on: pátek 6. března 2026 14:18:08
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugTangentSpace")]
public partial class DebugTangentSpace : global::FrooxEngine.Component

{
    public global::FrooxEngine.MeshRenderer Mesh { get => Mesh_Element.Data; set => Mesh_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer> Mesh_Element = new();
public global::System.Int32 Triangle { get => Triangle_Element.Data; set => Triangle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Triangle_Element = new();
public UnityEngine.Vector3 BaryCoord { get => BaryCoord_Element.Data; set => BaryCoord_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> BaryCoord_Element = new();
public global::System.Single RadiusRatio { get => RadiusRatio_Element.Data; set => RadiusRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RadiusRatio_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mesh", Mesh_Element.ToLinkReference(context));
members.Add("Triangle", Triangle_Element.ToLinkField(context));
members.Add("BaryCoord", BaryCoord_Element.ToLinkField(context));
members.Add("RadiusRatio", RadiusRatio_Element.ToLinkField(context));
}

}
}
