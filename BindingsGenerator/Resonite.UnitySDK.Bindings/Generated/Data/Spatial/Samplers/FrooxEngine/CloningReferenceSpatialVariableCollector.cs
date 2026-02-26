
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CloningReferenceSpatialVariableCollector
// Generated on: čtvrtek 26. února 2026 10:03:39
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CloningReferenceSpatialVariableCollector")]
public abstract partial class CloningReferenceSpatialVariableCollector : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot CloneParent { get => CloneParent_Element.Data; set => CloneParent_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> CloneParent_Element = new();
public global::System.Boolean MakeClonesLocal { get => MakeClonesLocal_Element.Data; set => MakeClonesLocal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MakeClonesLocal_Element = new();
public global::System.String VariableName { get => VariableName_Element.Data; set => VariableName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> VariableName_Element = new();
public global::FrooxEngine.CloningReferenceSpatialVariableCollector.CloneMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CloningReferenceSpatialVariableCollector.CloneMode>, global::FrooxEngine.CloningReferenceSpatialVariableCollector.CloneMode> Mode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CloneParent", CloneParent_Element.Data.ToResoniteReference(context));
members.Add("MakeClonesLocal", MakeClonesLocal_Element.Data.ToResoniteLinkField());
members.Add("VariableName", VariableName_Element.Data.ToResoniteLinkField());
members.Add("Mode", Mode_Element.Data.ToResoniteLinkField());
}

}
}
