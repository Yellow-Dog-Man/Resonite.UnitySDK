
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyLightsModuleAdapter
// Generated on: čtvrtek 26. února 2026 10:04:46
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.LegacyLightsModuleAdapter")]
public partial class LegacyLightsModuleAdapter : global::FrooxEngine.Component

{
    public global::FrooxEngine.Light LegacyLight { get => LegacyLight_Element.Data; set => LegacyLight_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.Light>, global::FrooxEngine.Light> LegacyLight_Element = new();
public global::FrooxEngine.Light ReferenceLight { get => ReferenceLight_Element.Data; set => ReferenceLight_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Light>, global::FrooxEngine.Light> ReferenceLight_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> LightsModuleEnabled { get => LightsModuleEnabled_Element.Data; set => LightsModuleEnabled_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> LightsModuleEnabled_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LegacyLight", LegacyLight_Element.Data.ToResoniteReference(context));
members.Add("ReferenceLight", ReferenceLight_Element.Data.ToResoniteReference(context));
members.Add("LightsModuleEnabled", LightsModuleEnabled_Element.Data.ToResoniteReference(context));
}

}
}
