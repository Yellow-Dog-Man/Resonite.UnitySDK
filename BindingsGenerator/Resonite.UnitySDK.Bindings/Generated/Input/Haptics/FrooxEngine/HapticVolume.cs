
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HapticVolume
// Generated on: čtvrtek 26. února 2026 12:26:55
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HapticVolume")]
public partial class HapticVolume : global::FrooxEngine.Component, global::FrooxEngine.IHapticSource

{
    public global::FrooxEngine.SensationClass Sensation { get => Sensation_Element.Data; set => Sensation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.SensationClass>, global::FrooxEngine.SensationClass> Sensation_Element = new();
public global::System.Single Intensity { get => Intensity_Element.Data; set => Intensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Intensity_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.String>, global::System.String, Field<global::FrooxEngine.Sync<global::System.String>, global::System.String>> SensationHints = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Sensation", Sensation_Element.ToLinkField(context));
members.Add("Intensity", Intensity_Element.ToLinkField(context));
members.Add("SensationHints", SensationHints.ToLinkList(context, m => m.ToLinkField(context)));
}

}
}
