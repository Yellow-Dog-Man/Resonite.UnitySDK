
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceProxy
// Generated on: pátek 13. února 2026 5:52:34
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Reference", new ResoniteLink.Reference() { });
members.Add("SpawnInstanceOnTrigger", SpawnInstanceOnTrigger.ToResoniteLinkField());
}

}
}
