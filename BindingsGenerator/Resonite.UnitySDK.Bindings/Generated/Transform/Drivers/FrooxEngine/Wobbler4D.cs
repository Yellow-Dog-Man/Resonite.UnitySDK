
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Wobbler4D
// Generated on: čtvrtek 26. února 2026 15:09:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Wobbler4D")]
public partial class Wobbler4D : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Vector4> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector4>, global::FrooxEngine.IField<UnityEngine.Vector4>> Target_Element = new();
public UnityEngine.Vector4 Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector4>, UnityEngine.Vector4> Offset_Element = new();
public UnityEngine.Vector4 Speed { get => Speed_Element.Data; set => Speed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector4>, UnityEngine.Vector4> Speed_Element = new();
public UnityEngine.Vector4 Magnitude { get => Magnitude_Element.Data; set => Magnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector4>, UnityEngine.Vector4> Magnitude_Element = new();
public UnityEngine.Vector4 Seed { get => Seed_Element.Data; set => Seed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector4>, UnityEngine.Vector4> Seed_Element = new();

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
