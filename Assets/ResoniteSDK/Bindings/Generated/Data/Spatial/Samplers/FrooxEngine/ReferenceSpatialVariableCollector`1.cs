
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceSpatialVariableCollector<>
// Generated on: pátek 13. února 2026 23:21:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceSpatialVariableCollector<>")]
public partial class ReferenceSpatialVariableCollector<T> : global::FrooxEngine.Component
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.ISyncRefList<T> ReferenceList;
public global::System.String VariableName;
public T DefaultTarget;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ReferenceList", new ResoniteLink.Reference() { });
members.Add("VariableName", VariableName.ToResoniteLinkField());
members.Add("DefaultTarget", new ResoniteLink.Reference() { });
}

}
}
