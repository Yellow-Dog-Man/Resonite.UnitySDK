
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConstrainedDelaunayMesh+Hole
// Generated on: pondělí 2. března 2026 17:52:25
// Resonite version: 2026.3.2.1000
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class ConstrainedDelaunayMesh
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ConstrainedDelaunayMesh+Hole")]
public partial class Hole : global::FrooxEngine.SyncObject

{
    public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.ProceduralMeshVertex>, global::FrooxEngine.ProceduralMeshVertex> HoleVertices = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HoleVertices", HoleVertices.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
            }
}
