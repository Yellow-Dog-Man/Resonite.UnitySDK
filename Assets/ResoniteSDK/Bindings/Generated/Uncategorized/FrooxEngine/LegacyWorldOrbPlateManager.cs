
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyWorldOrbPlateManager
// Generated on: úterý 24. února 2026 18:20:25
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyWorldOrbPlateManager")]
public abstract partial class LegacyWorldOrbPlateManager : global::FrooxEngine.Component

{
    public global::System.Single SpawnRadius;
public global::System.Single SpawnHeight;
public UnityEngine.Vector3 SpawnOffset;
public global::FrooxEngine.Slot _root;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpawnRadius", SpawnRadius.ToResoniteLinkField());
members.Add("SpawnHeight", SpawnHeight.ToResoniteLinkField());
members.Add("SpawnOffset", SpawnOffset.ToResoniteLinkField());
members.Add("_root", _root.ToResoniteReference(context));
}

}
}
