
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LightOrb
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LightOrb")]
public partial class LightOrb : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::System.Boolean FlipOnTouch { get => FlipOnTouch_Element.Data; set => FlipOnTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FlipOnTouch_Element = new();
public global::FrooxEngine.Light Light { get => Light_Element.Data; set => Light_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.Light>, global::FrooxEngine.Light> Light_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> EmissionColor { get => EmissionColor_Element.Data; set => EmissionColor_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> EmissionColor_Element = new();
public global::System.Boolean AcceptPhysicalTouch { get => AcceptPhysicalTouch_Element.Data; set => AcceptPhysicalTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptPhysicalTouch_Element = new();
public global::System.Boolean AcceptRemoteTouch { get => AcceptRemoteTouch_Element.Data; set => AcceptRemoteTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptRemoteTouch_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FlipOnTouch", FlipOnTouch_Element.Data.ToResoniteLinkField());
members.Add("Light", Light_Element.Data.ToResoniteReference(context));
members.Add("EmissionColor", EmissionColor_Element.Data.ToResoniteReference(context));
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch_Element.Data.ToResoniteLinkField());
members.Add("AcceptRemoteTouch", AcceptRemoteTouch_Element.Data.ToResoniteLinkField());
}

}
}
