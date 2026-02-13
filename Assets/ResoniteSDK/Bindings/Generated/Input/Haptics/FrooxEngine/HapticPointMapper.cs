
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HapticPointMapper
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HapticPointMapper")]
public abstract partial class HapticPointMapper : global::FrooxEngine.Component

{
    public global::System.Int32 Priority;
public global::System.Boolean ShowDebugVisuals;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Priority", Priority.ToResoniteLinkField());
members.Add("ShowDebugVisuals", ShowDebugVisuals.ToResoniteLinkField());
}

}
}
