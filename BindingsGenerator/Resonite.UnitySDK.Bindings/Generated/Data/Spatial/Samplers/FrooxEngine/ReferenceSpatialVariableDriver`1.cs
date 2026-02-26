
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceSpatialVariableDriver<>
// Generated on: čtvrtek 26. února 2026 12:26:54
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceSpatialVariableDriver<>")]
public partial class ReferenceSpatialVariableDriver<T> : global::FrooxEngine.Component
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.SyncRef<T> Drive { get => Drive_Element.Data; set => Drive_Element.Data = value; }
public Field<global::FrooxEngine.RefDrive<T>, global::FrooxEngine.SyncRef<T>> Drive_Element = new();
public global::System.String VariableName { get => VariableName_Element.Data; set => VariableName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> VariableName_Element = new();
public T DefaultTarget { get => DefaultTarget_Element.Data; set => DefaultTarget_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<T>, T> DefaultTarget_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Drive", Drive_Element.ToLinkReference(context));
members.Add("VariableName", VariableName_Element.ToLinkField(context));
members.Add("DefaultTarget", DefaultTarget_Element.ToLinkReference(context));
}

}
}
