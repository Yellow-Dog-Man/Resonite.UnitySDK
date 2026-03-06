
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DataPresetReference<>
// Generated on: pátek 6. března 2026 14:18:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DataPresetReference<>")]
public partial class DataPresetReference<T> : global::FrooxEngine.Component, global::FrooxEngine.IDataPresetEntry
	where T : class, global::FrooxEngine.IWorldElement

{
    public T PresetReference { get => PresetReference_Element.Data; set => PresetReference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<T>, T> PresetReference_Element = new();
public global::FrooxEngine.SyncRef<T> TargetReference { get => TargetReference_Element.Data; set => TargetReference_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.SyncRef<T>>, global::FrooxEngine.SyncRef<T>> TargetReference_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PresetReference", PresetReference_Element.ToLinkReference(context));
members.Add("TargetReference", TargetReference_Element.ToLinkReference(context));
}

}
}
