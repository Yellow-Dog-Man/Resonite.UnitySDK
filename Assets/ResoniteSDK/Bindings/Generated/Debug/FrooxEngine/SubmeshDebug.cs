
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SubmeshDebug
// Generated on: pátek 13. února 2026 23:21:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SubmeshDebug")]
public partial class SubmeshDebug : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Offset;
public global::System.Int32 SubmeshCount;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("SubmeshCount", SubmeshCount.ToResoniteLinkField());
}

}
}
