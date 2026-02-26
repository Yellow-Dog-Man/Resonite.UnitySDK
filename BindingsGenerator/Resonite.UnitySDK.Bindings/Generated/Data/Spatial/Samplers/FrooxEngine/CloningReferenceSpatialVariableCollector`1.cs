
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CloningReferenceSpatialVariableCollector<>
// Generated on: čtvrtek 26. února 2026 15:07:59
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.ISyncRefList<T> ReferenceList { get => ReferenceList_Element.Data; set => ReferenceList_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.ISyncRefList<T>>, global::FrooxEngine.ISyncRefList<T>> ReferenceList_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ReferenceList", ReferenceList_Element.ToLinkReference(context));
}

}
}
