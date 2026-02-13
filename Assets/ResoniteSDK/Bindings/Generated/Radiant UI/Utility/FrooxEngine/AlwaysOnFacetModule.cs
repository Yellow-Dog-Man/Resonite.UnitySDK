
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AlwaysOnFacetModule
// Generated on: pátek 13. února 2026 5:52:19
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AlwaysOnFacetModule")]
public partial class AlwaysOnFacetModule : global::FrooxEngine.Component

{
    public System.Collections.Generic.List<global::FrooxEngine.Slot> _targets;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_targets", new ResoniteLink.SyncList()
{
    Elements = _targets.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
}

}
}
