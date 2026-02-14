
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BevelBoxMesh
// Generated on: sobota 14. února 2026 8:56:59
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size.ToResoniteLinkField());
members.Add("Bevel", Bevel.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
members.Add("ScaleUVWithSize", ScaleUVWithSize.ToResoniteLinkField());
}

}
}
