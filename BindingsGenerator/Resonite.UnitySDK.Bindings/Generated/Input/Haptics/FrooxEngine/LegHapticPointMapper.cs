
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegHapticPointMapper
// Generated on: čtvrtek 26. února 2026 15:08:00
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegHapticPointMapper")]
public partial class LegHapticPointMapper : global::FrooxEngine.LimbHapticPointMapper<global::FrooxEngine.LegHapticPosition>

{
    public global::System.Single UpperLegRadius { get => UpperLegRadius_Element.Data; set => UpperLegRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> UpperLegRadius_Element = new();
public global::System.Single KneeRadius { get => KneeRadius_Element.Data; set => KneeRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> KneeRadius_Element = new();
public global::System.Single AnkleRadius { get => AnkleRadius_Element.Data; set => AnkleRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AnkleRadius_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UpperLegRadius", UpperLegRadius_Element.ToLinkField(context));
members.Add("KneeRadius", KneeRadius_Element.ToLinkField(context));
members.Add("AnkleRadius", AnkleRadius_Element.ToLinkField(context));
}

}
}
