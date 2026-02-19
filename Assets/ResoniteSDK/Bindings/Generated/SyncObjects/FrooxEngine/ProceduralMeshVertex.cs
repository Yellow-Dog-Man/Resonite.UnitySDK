
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProceduralMeshVertex
// Generated on: čtvrtek 19. února 2026 7:58:53
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public UnityEngine.Vector3 Position;
public UnityEngine.Vector2 UV0;
public UnityEngine.Vector2 UV1;
public UnityEngine.Vector2 UV2;
public UnityEngine.Vector2 UV3;
public UnityEngine.ColorX Color;
public UnityEngine.Vector3 Normal;
public UnityEngine.Vector4 Tangent;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Position", Position.ToResoniteLinkField());
members.Add("UV0", UV0.ToResoniteLinkField());
members.Add("UV1", UV1.ToResoniteLinkField());
members.Add("UV2", UV2.ToResoniteLinkField());
members.Add("UV3", UV3.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("Normal", Normal.ToResoniteLinkField());
members.Add("Tangent", Tangent.ToResoniteLinkField());
}

}
}
