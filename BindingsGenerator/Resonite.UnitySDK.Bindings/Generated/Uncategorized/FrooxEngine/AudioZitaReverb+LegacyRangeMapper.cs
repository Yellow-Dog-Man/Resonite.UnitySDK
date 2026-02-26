
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioZitaReverb+LegacyRangeMapper
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
    public partial class AudioZitaReverb
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioZitaReverb+LegacyRangeMapper")]
public partial class LegacyRangeMapper : global::FrooxEngine.Component

{
    public global::System.Single MinDistance { get => MinDistance_Element.Data; set => MinDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinDistance_Element = new();
public global::System.Single MaxDistance { get => MaxDistance_Element.Data; set => MaxDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxDistance_Element = new();
public global::FrooxEngine.IField<global::System.Single> Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> Radius_Element = new();
public global::FrooxEngine.IField<global::System.Single> BlendDistance { get => BlendDistance_Element.Data; set => BlendDistance_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> BlendDistance_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinDistance", MinDistance_Element.Data.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance_Element.Data.ToResoniteLinkField());
members.Add("Radius", Radius_Element.Data.ToResoniteReference(context));
members.Add("BlendDistance", BlendDistance_Element.Data.ToResoniteReference(context));
}

}
            }
}
