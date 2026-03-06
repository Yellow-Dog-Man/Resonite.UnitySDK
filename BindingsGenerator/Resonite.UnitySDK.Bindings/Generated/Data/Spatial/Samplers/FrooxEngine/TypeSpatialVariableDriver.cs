
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TypeSpatialVariableDriver
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TypeSpatialVariableDriver")]
public partial class TypeSpatialVariableDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.SyncType Drive { get => Drive_Element.Data; set => Drive_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.SyncType>, global::FrooxEngine.SyncType> Drive_Element = new();
public global::System.String VariableName { get => VariableName_Element.Data; set => VariableName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> VariableName_Element = new();
public System.String DefaultType { get => DefaultType_Element.Data; set => DefaultType_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> DefaultType_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Drive", Drive_Element.ToLinkReference(context));
members.Add("VariableName", VariableName_Element.ToLinkField(context));
members.Add("DefaultType", DefaultType_Element.ToLinkField(context));
}

}
}
