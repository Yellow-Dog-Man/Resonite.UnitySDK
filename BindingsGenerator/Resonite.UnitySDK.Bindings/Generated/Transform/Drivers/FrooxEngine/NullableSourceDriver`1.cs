
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NullableSourceDriver<>
// Generated on: čtvrtek 26. února 2026 10:04:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NullableSourceDriver<>")]
public partial class NullableSourceDriver<T> : global::FrooxEngine.Component
	where T : struct

{
    public global::FrooxEngine.IField<global::System.Nullable<T>> Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<global::System.Nullable<T>>>, global::FrooxEngine.IField<global::System.Nullable<T>>> Source_Element = new();
public global::FrooxEngine.IField<T> Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<T>, global::FrooxEngine.IField<T>> Value_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> HasValue { get => HasValue_Element.Data; set => HasValue_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> HasValue_Element = new();
public T DefaultValue { get => DefaultValue_Element.Data; set => DefaultValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> DefaultValue_Element = new();
public global::System.Boolean WriteBack { get => WriteBack_Element.Data; set => WriteBack_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> WriteBack_Element = new();
public global::System.Boolean UpdateDefaultValue { get => UpdateDefaultValue_Element.Data; set => UpdateDefaultValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UpdateDefaultValue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.Data.ToResoniteReference(context));
members.Add("Value", Value_Element.Data.ToResoniteReference(context));
members.Add("HasValue", HasValue_Element.Data.ToResoniteReference(context));
members.Add("DefaultValue", DefaultValue_Element.Data.ToResoniteLinkField());
members.Add("WriteBack", WriteBack_Element.Data.ToResoniteLinkField());
members.Add("UpdateDefaultValue", UpdateDefaultValue_Element.Data.ToResoniteLinkField());
}

}
}
