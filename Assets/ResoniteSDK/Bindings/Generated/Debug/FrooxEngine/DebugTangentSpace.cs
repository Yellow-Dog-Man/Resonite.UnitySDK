
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugTangentSpace
// Generated on: úterý 24. února 2026 18:17:48
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::FrooxEngine.MeshRenderer Mesh;
public global::System.Int32 Triangle;
public UnityEngine.Vector3 BaryCoord;
public global::System.Single RadiusRatio;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mesh", Mesh.ToResoniteReference(context));
members.Add("Triangle", Triangle.ToResoniteLinkField());
members.Add("BaryCoord", BaryCoord.ToResoniteLinkField());
members.Add("RadiusRatio", RadiusRatio.ToResoniteLinkField());
}

}
}
