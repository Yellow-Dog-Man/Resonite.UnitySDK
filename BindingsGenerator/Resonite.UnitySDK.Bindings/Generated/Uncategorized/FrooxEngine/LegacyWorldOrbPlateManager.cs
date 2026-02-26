
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyWorldOrbPlateManager
// Generated on: čtvrtek 26. února 2026 10:04:46
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyWorldOrbPlateManager")]
public abstract partial class LegacyWorldOrbPlateManager : global::FrooxEngine.Component

{
    public global::System.Single SpawnRadius { get => SpawnRadius_Element.Data; set => SpawnRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SpawnRadius_Element = new();
public global::System.Single SpawnHeight { get => SpawnHeight_Element.Data; set => SpawnHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SpawnHeight_Element = new();
public UnityEngine.Vector3 SpawnOffset { get => SpawnOffset_Element.Data; set => SpawnOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> SpawnOffset_Element = new();
public global::FrooxEngine.Slot _root { get => _root_Element.Data; set => _root_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _root_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpawnRadius", SpawnRadius_Element.Data.ToResoniteLinkField());
members.Add("SpawnHeight", SpawnHeight_Element.Data.ToResoniteLinkField());
members.Add("SpawnOffset", SpawnOffset_Element.Data.ToResoniteLinkField());
members.Add("_root", _root_Element.Data.ToResoniteReference(context));
}

}
}
