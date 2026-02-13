
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugTestMeshThroughput
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugTestMeshThroughput")]
public partial class DebugTestMeshThroughput : global::FrooxEngine.ProceduralMesh

{
    public global::System.Int32 Count;
public global::System.Single Progress;
public global::System.Single UpdateTime;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Count", Count.ToResoniteLinkField());
members.Add("Progress", Progress.ToResoniteLinkField());
members.Add("UpdateTime", UpdateTime.ToResoniteLinkField());
}

}
}
