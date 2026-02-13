
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BevelBoxMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BevelBoxMesh")]
public partial class BevelBoxMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Vector3 Size;
public global::System.Single Bevel;
public UnityEngine.Vector3 UVScale;
public global::System.Boolean ScaleUVWithSize;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Size", Size.ToResoniteLinkField());
members.Add("Bevel", Bevel.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
members.Add("ScaleUVWithSize", ScaleUVWithSize.ToResoniteLinkField());
}

}
}
