
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConstrainedDelaunayMesh+Hole
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
    public partial class ConstrainedDelaunayMesh
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ConstrainedDelaunayMesh+Hole")]
public partial class Hole : global::FrooxEngine.SyncObject

{
    public System.Collections.Generic.List<global::FrooxEngine.ProceduralMeshVertex> HoleVertices;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HoleVertices", new ResoniteLink.SyncList()
{
    Elements = HoleVertices.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
            }
}
