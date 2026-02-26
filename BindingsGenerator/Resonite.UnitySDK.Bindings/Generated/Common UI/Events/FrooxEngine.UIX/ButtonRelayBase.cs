
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ButtonRelayBase
// Generated on: čtvrtek 26. února 2026 15:07:58
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.Single DoublePressDelay { get => DoublePressDelay_Element.Data; set => DoublePressDelay_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DoublePressDelay_Element = new();
public global::System.Single ReleasePressInterval { get => ReleasePressInterval_Element.Data; set => ReleasePressInterval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ReleasePressInterval_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DoublePressDelay", DoublePressDelay_Element.ToLinkField(context));
members.Add("ReleasePressInterval", ReleasePressInterval_Element.ToLinkField(context));
}

}
}
