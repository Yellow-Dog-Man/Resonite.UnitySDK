
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonDynamicImpulseTrigger
// Generated on: pátek 13. února 2026 23:21:38
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
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
