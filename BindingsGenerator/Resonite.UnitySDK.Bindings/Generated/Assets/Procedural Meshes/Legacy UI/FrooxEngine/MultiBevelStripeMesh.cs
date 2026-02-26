
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiBevelStripeMesh
// Generated on: čtvrtek 26. února 2026 12:26:51
// Resonite version: 2026.2.26.702
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
