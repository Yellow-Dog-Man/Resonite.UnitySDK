
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiBevelStripeMesh
// Generated on: pátek 6. března 2026 14:18:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MultiBevelStripeMesh")]
public partial class MultiBevelStripeMesh : global::FrooxEngine.ProceduralMesh

{
    public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.MultiBevelStripeMesh.Stripe>, global::FrooxEngine.MultiBevelStripeMesh.Stripe> Stripes = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Stripes", Stripes.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
