
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProceduralMeshVertex
// Generated on: pátek 13. února 2026 5:51:08
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
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
