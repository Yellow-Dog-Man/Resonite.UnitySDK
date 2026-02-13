
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugTangentSpace
// Generated on: pátek 13. února 2026 5:51:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugTangentSpace")]
public partial class DebugTangentSpace : global::FrooxEngine.Component

{
    public global::FrooxEngine.MeshRenderer Mesh;
public global::System.Int32 Triangle;
public UnityEngine.Vector3 BaryCoord;
public global::System.Single RadiusRatio;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Mesh", new ResoniteLink.Reference() { });
members.Add("Triangle", Triangle.ToResoniteLinkField());
members.Add("BaryCoord", BaryCoord.ToResoniteLinkField());
members.Add("RadiusRatio", RadiusRatio.ToResoniteLinkField());
}

}
}
