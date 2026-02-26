
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Wobbler1D
// Generated on: čtvrtek 26. února 2026 12:28:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Wobbler1D")]
public partial class Wobbler1D : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.Single> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> Target_Element = new();
public global::System.Single Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Offset_Element = new();
public global::System.Single Speed { get => Speed_Element.Data; set => Speed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Speed_Element = new();
public global::System.Single Magnitude { get => Magnitude_Element.Data; set => Magnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Magnitude_Element = new();
public global::System.Single Seed { get => Seed_Element.Data; set => Seed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Seed_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("Offset", Offset_Element.ToLinkField(context));
members.Add("Speed", Speed_Element.ToLinkField(context));
members.Add("Magnitude", Magnitude_Element.ToLinkField(context));
members.Add("Seed", Seed_Element.ToLinkField(context));
}

}
}
