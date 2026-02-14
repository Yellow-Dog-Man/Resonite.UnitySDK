
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ButtonRelayBase
// Generated on: sobota 14. února 2026 8:57:04
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ButtonRelayBase")]
public abstract partial class ButtonRelayBase : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::System.Single DoublePressDelay;
public global::System.Single ReleasePressInterval;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DoublePressDelay", DoublePressDelay.ToResoniteLinkField());
members.Add("ReleasePressInterval", ReleasePressInterval.ToResoniteLinkField());
}

}
}
