
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SequenceRibbonSplitter
// Generated on: čtvrtek 26. února 2026 12:28:05
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.SequenceRibbonSplitter")]
public partial class SequenceRibbonSplitter : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::System.Int32 MinSequenceCount { get => MinSequenceCount_Element.Data; set => MinSequenceCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MinSequenceCount_Element = new();
public global::System.Int32 MaxSequenceCount { get => MaxSequenceCount_Element.Data; set => MaxSequenceCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxSequenceCount_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinSequenceCount", MinSequenceCount_Element.ToLinkField(context));
members.Add("MaxSequenceCount", MaxSequenceCount_Element.ToLinkField(context));
}

}
}
