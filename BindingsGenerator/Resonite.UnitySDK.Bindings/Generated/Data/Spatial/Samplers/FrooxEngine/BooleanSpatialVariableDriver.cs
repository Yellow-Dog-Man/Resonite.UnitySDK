
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BooleanSpatialVariableDriver
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BooleanSpatialVariableDriver")]
public partial class BooleanSpatialVariableDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.Boolean> Drive { get => Drive_Element.Data; set => Drive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> Drive_Element = new();
public global::System.String VariableName { get => VariableName_Element.Data; set => VariableName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> VariableName_Element = new();
public global::FrooxEngine.BooleanSpatialVariableMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BooleanSpatialVariableMode>, global::FrooxEngine.BooleanSpatialVariableMode> Mode_Element = new();
public global::System.Boolean DefaultValue { get => DefaultValue_Element.Data; set => DefaultValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DefaultValue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Drive", Drive_Element.ToLinkReference(context));
members.Add("VariableName", VariableName_Element.ToLinkField(context));
members.Add("Mode", Mode_Element.ToLinkField(context));
members.Add("DefaultValue", DefaultValue_Element.ToLinkField(context));
}

}
}
