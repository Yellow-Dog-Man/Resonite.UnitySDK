
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LightOrb
// Generated on: pátek 13. února 2026 23:23:16
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("FlipOnTouch", FlipOnTouch.ToResoniteLinkField());
members.Add("Light", new ResoniteLink.Reference() { });
members.Add("EmissionColor", new ResoniteLink.Reference() { });
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch.ToResoniteLinkField());
members.Add("AcceptRemoteTouch", AcceptRemoteTouch.ToResoniteLinkField());
}

}
}
