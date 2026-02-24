
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DataPresetValue<>
// Generated on: úterý 24. února 2026 18:17:47
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public T PresetValue;
public global::FrooxEngine.IField<T> TargetField;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PresetValue", PresetValue.ToResoniteLinkField());
members.Add("TargetField", TargetField.ToResoniteReference(context));
}

}
}
