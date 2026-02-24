
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonDynamicImpulseTrigger
// Generated on: úterý 24. února 2026 18:17:45
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonDynamicImpulseTrigger")]
public partial class ButtonDynamicImpulseTrigger : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver, global::FrooxEngine.IButtonHoverReceiver

{
    public global::FrooxEngine.Slot Target;
public global::System.Boolean ExcludeDisabled;
public global::System.String PressedTag;
public global::System.String PressingTag;
public global::System.String ReleasedTag;
public global::System.String HoverEnterTag;
public global::System.String HoverStayTag;
public global::System.String HoverLeaveTag;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("ExcludeDisabled", ExcludeDisabled.ToResoniteLinkField());
members.Add("PressedTag", PressedTag.ToResoniteLinkField());
members.Add("PressingTag", PressingTag.ToResoniteLinkField());
members.Add("ReleasedTag", ReleasedTag.ToResoniteLinkField());
members.Add("HoverEnterTag", HoverEnterTag.ToResoniteLinkField());
members.Add("HoverStayTag", HoverStayTag.ToResoniteLinkField());
members.Add("HoverLeaveTag", HoverLeaveTag.ToResoniteLinkField());
}

}
}
