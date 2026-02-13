
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WrapperMesh
// Generated on: pátek 13. února 2026 23:21:36
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WrapperMesh")]
public partial class WrapperMesh : global::FrooxEngine.ProceduralMesh

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Mesh> Mesh;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Mesh", new ResoniteLink.Reference() { });
}

}
}
