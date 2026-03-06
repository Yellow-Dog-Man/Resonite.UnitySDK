
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugTestMeshThroughput
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugTestMeshThroughput")]
public partial class DebugTestMeshThroughput : global::FrooxEngine.ProceduralMesh

{
    public global::System.Int32 Count { get => Count_Element.Data; set => Count_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Count_Element = new();
public global::System.Single Progress { get => Progress_Element.Data; set => Progress_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Progress_Element = new();
public global::System.Single UpdateTime { get => UpdateTime_Element.Data; set => UpdateTime_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> UpdateTime_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Count", Count_Element.ToLinkField(context));
members.Add("Progress", Progress_Element.ToLinkField(context));
members.Add("UpdateTime", UpdateTime_Element.ToLinkField(context));
}

}
}
