
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugTestMeshThroughput
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugTestMeshThroughput")]
public partial class DebugTestMeshThroughput : global::FrooxEngine.ProceduralMesh

{
    public global::System.Int32 Count;
public global::System.Single Progress;
public global::System.Single UpdateTime;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Count", Count.ToResoniteLinkField());
members.Add("Progress", Progress.ToResoniteLinkField());
members.Add("UpdateTime", UpdateTime.ToResoniteLinkField());
}

}
}
