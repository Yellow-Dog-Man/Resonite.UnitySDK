
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PositionDeltaDriver
// Generated on: pátek 13. února 2026 23:23:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PositionDeltaDriver")]
public partial class PositionDeltaDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot Origin;
public global::FrooxEngine.Slot Target;
public global::FrooxEngine.RootSpace VectorSpace;
public global::System.Boolean Normalized;
public global::FrooxEngine.IField<UnityEngine.Vector3> Vector;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Origin", new ResoniteLink.Reference() { });
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("VectorSpace", new ResoniteLink.SyncObject() { Members = VectorSpace.CollectMembers() });
members.Add("Normalized", Normalized.ToResoniteLinkField());
members.Add("Vector", new ResoniteLink.Reference() { });
}

}
}
