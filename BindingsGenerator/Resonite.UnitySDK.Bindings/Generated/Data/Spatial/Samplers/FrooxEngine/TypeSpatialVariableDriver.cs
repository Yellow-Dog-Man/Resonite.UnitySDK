
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TypeSpatialVariableDriver
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TypeSpatialVariableDriver")]
public partial class TypeSpatialVariableDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.SyncType Drive { get => Drive_Element.Data; set => Drive_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.SyncType>, global::FrooxEngine.SyncType> Drive_Element = new();
public global::System.String VariableName { get => VariableName_Element.Data; set => VariableName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> VariableName_Element = new();
public System.String DefaultType { get => DefaultType_Element.Data; set => DefaultType_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> DefaultType_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Drive", Drive_Element.Data.ToResoniteReference(context));
members.Add("VariableName", VariableName_Element.Data.ToResoniteLinkField());
members.Add("DefaultType", DefaultType_Element.Data.ToResoniteLinkField());
}

}
}
