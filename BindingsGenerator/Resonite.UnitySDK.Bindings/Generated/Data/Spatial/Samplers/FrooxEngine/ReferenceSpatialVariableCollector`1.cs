
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceSpatialVariableCollector<>
// Generated on: pátek 6. března 2026 14:18:08
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::FrooxEngine.ISyncRefList<T> ReferenceList { get => ReferenceList_Element.Data; set => ReferenceList_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.ISyncRefList<T>>, global::FrooxEngine.ISyncRefList<T>> ReferenceList_Element = new();
public global::System.String VariableName { get => VariableName_Element.Data; set => VariableName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> VariableName_Element = new();
public T DefaultTarget { get => DefaultTarget_Element.Data; set => DefaultTarget_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<T>, T> DefaultTarget_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ReferenceList", ReferenceList_Element.ToLinkReference(context));
members.Add("VariableName", VariableName_Element.ToLinkField(context));
members.Add("DefaultTarget", DefaultTarget_Element.ToLinkReference(context));
}

}
}
