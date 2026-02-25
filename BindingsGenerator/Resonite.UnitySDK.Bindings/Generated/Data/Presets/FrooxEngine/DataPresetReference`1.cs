
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DataPresetReference<>
// Generated on: středa 25. února 2026 16:13:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DataPresetReference<>")]
public partial class DataPresetReference<T> : global::FrooxEngine.Component, global::FrooxEngine.IDataPresetEntry
	where T : class, global::FrooxEngine.IWorldElement

{
    public T PresetReference;
public global::FrooxEngine.SyncRef<T> TargetReference;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PresetReference", PresetReference.ToResoniteReference(context));
members.Add("TargetReference", TargetReference.ToResoniteReference(context));
}

}
}
