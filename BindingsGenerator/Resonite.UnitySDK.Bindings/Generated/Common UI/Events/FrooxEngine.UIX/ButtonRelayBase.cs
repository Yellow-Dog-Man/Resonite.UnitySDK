
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ButtonRelayBase
// Generated on: středa 25. února 2026 16:13:07
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
