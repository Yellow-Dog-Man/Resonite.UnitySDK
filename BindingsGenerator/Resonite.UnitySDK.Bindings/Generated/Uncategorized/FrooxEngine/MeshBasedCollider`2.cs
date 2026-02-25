
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshBasedCollider<,>
// Generated on: středa 25. února 2026 16:13:11
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
