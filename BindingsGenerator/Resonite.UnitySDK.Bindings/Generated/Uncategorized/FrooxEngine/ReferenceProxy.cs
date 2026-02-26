
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceProxy
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceProxy")]
public partial class ReferenceProxy : global::FrooxEngine.Component, global::FrooxEngine.IReferenceSource<global::FrooxEngine.IWorldElement>, global::FrooxEngine.IReferenceSource, global::FrooxEngine.ITriggerActionReceiver

{
    public global::FrooxEngine.IWorldElement Reference { get => Reference_Element.Data; set => Reference_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef, global::FrooxEngine.IWorldElement> Reference_Element = new();
public global::System.Boolean SpawnInstanceOnTrigger { get => SpawnInstanceOnTrigger_Element.Data; set => SpawnInstanceOnTrigger_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SpawnInstanceOnTrigger_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Reference", Reference_Element.Data.ToResoniteReference(context));
members.Add("SpawnInstanceOnTrigger", SpawnInstanceOnTrigger_Element.Data.ToResoniteLinkField());
}

}
}
