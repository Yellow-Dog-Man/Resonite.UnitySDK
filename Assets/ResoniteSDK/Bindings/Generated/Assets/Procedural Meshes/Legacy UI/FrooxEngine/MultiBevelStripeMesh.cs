
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiBevelStripeMesh
// Generated on: čtvrtek 19. února 2026 7:58:53
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public System.Collections.Generic.List<global::FrooxEngine.MultiBevelStripeMesh.Stripe> Stripes;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Stripes", new ResoniteLink.SyncList()
{
    Elements = Stripes.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
