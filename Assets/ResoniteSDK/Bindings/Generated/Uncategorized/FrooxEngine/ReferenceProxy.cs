
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceProxy
// Generated on: čtvrtek 19. února 2026 8:00:29
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceProxy")]
public partial class ReferenceProxy : global::FrooxEngine.Component, global::FrooxEngine.IReferenceSource<global::FrooxEngine.IWorldElement>, global::FrooxEngine.IReferenceSource, global::FrooxEngine.ITriggerActionReceiver

{
    public global::FrooxEngine.IWorldElement Reference;
public global::System.Boolean SpawnInstanceOnTrigger;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Reference", Reference.ToResoniteReference(context));
members.Add("SpawnInstanceOnTrigger", SpawnInstanceOnTrigger.ToResoniteLinkField());
}

}
}
