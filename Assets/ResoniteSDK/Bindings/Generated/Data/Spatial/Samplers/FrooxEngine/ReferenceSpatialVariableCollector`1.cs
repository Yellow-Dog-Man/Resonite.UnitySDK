
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceSpatialVariableCollector<>
// Generated on: sobota 14. února 2026 8:57:05
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceSpatialVariableCollector<>")]
public partial class ReferenceSpatialVariableCollector<T> : global::FrooxEngine.Component
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.ISyncRefList<T> ReferenceList;
public global::System.String VariableName;
public T DefaultTarget;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ReferenceList", ReferenceList.ToResoniteReference(context));
members.Add("VariableName", VariableName.ToResoniteLinkField());
members.Add("DefaultTarget", DefaultTarget.ToResoniteReference(context));
}

}
}
