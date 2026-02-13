
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshBasedCollider<,>
// Generated on: pátek 13. února 2026 5:51:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeshBasedCollider<,>")]
public abstract partial class MeshBasedCollider<TShape,TData> : global::FrooxEngine.Collider<TShape>, global::FrooxEngine.IMeshPhysicsDataRequester
	where TData : class, global::FrooxEngine.IMeshPhysicsData
	where TShape : struct

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Mesh> Mesh;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Mesh", new ResoniteLink.Reference() { });
}

}
}
