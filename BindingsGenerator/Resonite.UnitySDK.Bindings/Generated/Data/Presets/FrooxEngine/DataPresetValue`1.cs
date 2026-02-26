
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DataPresetValue<>
// Generated on: čtvrtek 26. února 2026 10:03:38
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DataPresetValue<>")]
public partial class DataPresetValue<T> : global::FrooxEngine.Component, global::FrooxEngine.IDataPresetEntry
	

{
    public T PresetValue { get => PresetValue_Element.Data; set => PresetValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> PresetValue_Element = new();
public global::FrooxEngine.IField<T> TargetField { get => TargetField_Element.Data; set => TargetField_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<T>>, global::FrooxEngine.IField<T>> TargetField_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PresetValue", PresetValue_Element.Data.ToResoniteLinkField());
members.Add("TargetField", TargetField_Element.Data.ToResoniteReference(context));
}

}
}
