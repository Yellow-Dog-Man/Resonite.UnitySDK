
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LightOrb
// Generated on: čtvrtek 19. února 2026 8:00:29
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::System.Boolean FlipOnTouch;
public global::FrooxEngine.Light Light;
public global::FrooxEngine.IField<UnityEngine.ColorX> EmissionColor;
public global::System.Boolean AcceptPhysicalTouch;
public global::System.Boolean AcceptRemoteTouch;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FlipOnTouch", FlipOnTouch.ToResoniteLinkField());
members.Add("Light", Light.ToResoniteReference(context));
members.Add("EmissionColor", EmissionColor.ToResoniteReference(context));
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch.ToResoniteLinkField());
members.Add("AcceptRemoteTouch", AcceptRemoteTouch.ToResoniteLinkField());
}

}
}
