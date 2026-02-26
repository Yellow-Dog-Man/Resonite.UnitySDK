
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MinMaxValueSpatialVariableDriver<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MinMaxValueSpatialVariableDriver<>")]
public partial class MinMaxValueSpatialVariableDriver<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.IField<T> MinDrive { get => MinDrive_Element.Data; set => MinDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<T>, global::FrooxEngine.IField<T>> MinDrive_Element = new();
public global::FrooxEngine.IField<T> MaxDrive { get => MaxDrive_Element.Data; set => MaxDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<T>, global::FrooxEngine.IField<T>> MaxDrive_Element = new();
public global::System.String VariableName { get => VariableName_Element.Data; set => VariableName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> VariableName_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinDrive", MinDrive_Element.ToLinkReference(context));
members.Add("MaxDrive", MaxDrive_Element.ToLinkReference(context));
members.Add("VariableName", VariableName_Element.ToLinkField(context));
}

}
}
