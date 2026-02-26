
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BooleanReferenceDriver<>
// Generated on: čtvrtek 26. února 2026 10:04:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BooleanReferenceDriver<>")]
public partial class BooleanReferenceDriver<T> : global::FrooxEngine.Component
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::System.Boolean State { get => State_Element.Data; set => State_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> State_Element = new();
public global::FrooxEngine.SyncRef<T> TargetReference { get => TargetReference_Element.Data; set => TargetReference_Element.Data = value; }
public Field<global::FrooxEngine.RefDrive<T>, global::FrooxEngine.SyncRef<T>> TargetReference_Element = new();
public T FalseTarget { get => FalseTarget_Element.Data; set => FalseTarget_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<T>, T> FalseTarget_Element = new();
public T TrueTarget { get => TrueTarget_Element.Data; set => TrueTarget_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<T>, T> TrueTarget_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("State", State_Element.Data.ToResoniteLinkField());
members.Add("TargetReference", TargetReference_Element.Data.ToResoniteReference(context));
members.Add("FalseTarget", FalseTarget_Element.Data.ToResoniteReference(context));
members.Add("TrueTarget", TrueTarget_Element.Data.ToResoniteReference(context));
}

}
}
