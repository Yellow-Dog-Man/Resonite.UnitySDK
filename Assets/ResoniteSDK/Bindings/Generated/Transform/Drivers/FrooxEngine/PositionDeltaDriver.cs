
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PositionDeltaDriver
// Generated on: úterý 24. února 2026 18:20:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PositionDeltaDriver")]
public partial class PositionDeltaDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot Origin;
public global::FrooxEngine.Slot Target;
public global::FrooxEngine.RootSpace VectorSpace;
public global::System.Boolean Normalized;
public global::FrooxEngine.IField<UnityEngine.Vector3> Vector;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Origin", Origin.ToResoniteReference(context));
members.Add("Target", Target.ToResoniteReference(context));
members.Add("VectorSpace", new ResoniteLink.SyncObject() { Members = VectorSpace.CollectMembers(context) });
members.Add("Normalized", Normalized.ToResoniteLinkField());
members.Add("Vector", Vector.ToResoniteReference(context));
}

}
}
