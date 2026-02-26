
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueSpatialVariablePartialDerivativeDriver<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueSpatialVariablePartialDerivativeDriver<>")]
public partial class ValueSpatialVariablePartialDerivativeDriver<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.IField<T> DriveX { get => DriveX_Element.Data; set => DriveX_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<T>, global::FrooxEngine.IField<T>> DriveX_Element = new();
public global::FrooxEngine.IField<T> DriveY { get => DriveY_Element.Data; set => DriveY_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<T>, global::FrooxEngine.IField<T>> DriveY_Element = new();
public global::FrooxEngine.IField<T> DriveZ { get => DriveZ_Element.Data; set => DriveZ_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<T>, global::FrooxEngine.IField<T>> DriveZ_Element = new();
public global::System.String VariableName { get => VariableName_Element.Data; set => VariableName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> VariableName_Element = new();
public global::FrooxEngine.ValueSpatialVariableMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ValueSpatialVariableMode>, global::FrooxEngine.ValueSpatialVariableMode> Mode_Element = new();
public T DefaultValue { get => DefaultValue_Element.Data; set => DefaultValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> DefaultValue_Element = new();
public global::System.Single SamplingDistance { get => SamplingDistance_Element.Data; set => SamplingDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SamplingDistance_Element = new();
public global::System.Boolean ComputeInLocalSpace { get => ComputeInLocalSpace_Element.Data; set => ComputeInLocalSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ComputeInLocalSpace_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DriveX", DriveX_Element.ToLinkReference(context));
members.Add("DriveY", DriveY_Element.ToLinkReference(context));
members.Add("DriveZ", DriveZ_Element.ToLinkReference(context));
members.Add("VariableName", VariableName_Element.ToLinkField(context));
members.Add("Mode", Mode_Element.ToLinkField(context));
members.Add("DefaultValue", DefaultValue_Element.ToLinkField(context));
members.Add("SamplingDistance", SamplingDistance_Element.ToLinkField(context));
members.Add("ComputeInLocalSpace", ComputeInLocalSpace_Element.ToLinkField(context));
}

}
}
