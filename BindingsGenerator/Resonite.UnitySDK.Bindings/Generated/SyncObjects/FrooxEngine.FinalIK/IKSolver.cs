
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKSolver
// Generated on: čtvrtek 26. února 2026 10:04:45
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
    public UnityEngine.Vector3 IKPosition { get => IKPosition_Element.Data; set => IKPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> IKPosition_Element = new();
public global::System.Single IKPositionWeight { get => IKPositionWeight_Element.Data; set => IKPositionWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> IKPositionWeight_Element = new();
public global::FrooxEngine.Slot SimulationSpace { get => SimulationSpace_Element.Data; set => SimulationSpace_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> SimulationSpace_Element = new();
public global::FrooxEngine.Slot OffsetSpace { get => OffsetSpace_Element.Data; set => OffsetSpace_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> OffsetSpace_Element = new();
public global::System.Boolean _initiated { get => _initiated_Element.Data; set => _initiated_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _initiated_Element = new();
public global::FrooxEngine.Slot root { get => root_Element.Data; set => root_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> root_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IKPosition", IKPosition_Element.Data.ToResoniteLinkField());
members.Add("IKPositionWeight", IKPositionWeight_Element.Data.ToResoniteLinkField());
members.Add("SimulationSpace", SimulationSpace_Element.Data.ToResoniteReference(context));
members.Add("OffsetSpace", OffsetSpace_Element.Data.ToResoniteReference(context));
members.Add("_initiated", _initiated_Element.Data.ToResoniteLinkField());
members.Add("root", root_Element.Data.ToResoniteReference(context));
}

}
}
