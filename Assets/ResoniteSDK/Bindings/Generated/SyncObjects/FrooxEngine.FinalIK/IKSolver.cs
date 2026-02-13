
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKSolver
// Generated on: pátek 13. února 2026 23:23:14
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FinalIK
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FinalIK.IKSolver")]
public abstract partial class IKSolver : global::FrooxEngine.SyncObject

{
    public UnityEngine.Vector3 IKPosition;
public global::System.Single IKPositionWeight;
public global::FrooxEngine.Slot SimulationSpace;
public global::FrooxEngine.Slot OffsetSpace;
public global::System.Boolean _initiated;
public global::FrooxEngine.Slot root;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("IKPosition", IKPosition.ToResoniteLinkField());
members.Add("IKPositionWeight", IKPositionWeight.ToResoniteLinkField());
members.Add("SimulationSpace", new ResoniteLink.Reference() { });
members.Add("OffsetSpace", new ResoniteLink.Reference() { });
members.Add("_initiated", _initiated.ToResoniteLinkField());
members.Add("root", new ResoniteLink.Reference() { });
}

}
}
