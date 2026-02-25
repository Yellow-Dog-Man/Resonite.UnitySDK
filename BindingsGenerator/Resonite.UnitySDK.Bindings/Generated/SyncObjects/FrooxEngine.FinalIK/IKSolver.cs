
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKSolver
// Generated on: středa 25. února 2026 16:14:38
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IKPosition", IKPosition.ToResoniteLinkField());
members.Add("IKPositionWeight", IKPositionWeight.ToResoniteLinkField());
members.Add("SimulationSpace", SimulationSpace.ToResoniteReference(context));
members.Add("OffsetSpace", OffsetSpace.ToResoniteReference(context));
members.Add("_initiated", _initiated.ToResoniteLinkField());
members.Add("root", root.ToResoniteReference(context));
}

}
}
