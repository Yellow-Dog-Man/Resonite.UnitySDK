
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CloningReferenceSpatialVariableCollector<>
// Generated on: úterý 24. února 2026 18:17:48
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CloningReferenceSpatialVariableCollector<>")]
public partial class CloningReferenceSpatialVariableCollector<T> : global::FrooxEngine.CloningReferenceSpatialVariableCollector
	where T : global::FrooxEngine.Component

{
    public global::FrooxEngine.ISyncRefList<T> ReferenceList;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ReferenceList", ReferenceList.ToResoniteReference(context));
}

}
}
