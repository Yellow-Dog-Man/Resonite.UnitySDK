
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshBasedCollider<,>
// Generated on: úterý 24. února 2026 18:17:54
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeshBasedCollider<,>")]
public abstract partial class MeshBasedCollider<TShape,TData> : global::FrooxEngine.Collider<TShape>, global::FrooxEngine.IMeshPhysicsDataRequester
	where TData : class, global::FrooxEngine.IMeshPhysicsData
	where TShape : struct

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Mesh> Mesh;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mesh", Mesh.ToResoniteReference(context));
}

}
}
