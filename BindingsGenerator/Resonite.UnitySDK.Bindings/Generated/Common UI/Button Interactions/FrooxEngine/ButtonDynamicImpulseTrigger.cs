
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonDynamicImpulseTrigger
// Generated on: čtvrtek 26. února 2026 15:07:57
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonDynamicImpulseTrigger")]
public partial class ButtonDynamicImpulseTrigger : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver, global::FrooxEngine.IButtonHoverReceiver

{
    public global::FrooxEngine.Slot Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Target_Element = new();
public global::System.Boolean ExcludeDisabled { get => ExcludeDisabled_Element.Data; set => ExcludeDisabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ExcludeDisabled_Element = new();
public global::System.String PressedTag { get => PressedTag_Element.Data; set => PressedTag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> PressedTag_Element = new();
public global::System.String PressingTag { get => PressingTag_Element.Data; set => PressingTag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> PressingTag_Element = new();
public global::System.String ReleasedTag { get => ReleasedTag_Element.Data; set => ReleasedTag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> ReleasedTag_Element = new();
public global::System.String HoverEnterTag { get => HoverEnterTag_Element.Data; set => HoverEnterTag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> HoverEnterTag_Element = new();
public global::System.String HoverStayTag { get => HoverStayTag_Element.Data; set => HoverStayTag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> HoverStayTag_Element = new();
public global::System.String HoverLeaveTag { get => HoverLeaveTag_Element.Data; set => HoverLeaveTag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> HoverLeaveTag_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("ExcludeDisabled", ExcludeDisabled_Element.ToLinkField(context));
members.Add("PressedTag", PressedTag_Element.ToLinkField(context));
members.Add("PressingTag", PressingTag_Element.ToLinkField(context));
members.Add("ReleasedTag", ReleasedTag_Element.ToLinkField(context));
members.Add("HoverEnterTag", HoverEnterTag_Element.ToLinkField(context));
members.Add("HoverStayTag", HoverStayTag_Element.ToLinkField(context));
members.Add("HoverLeaveTag", HoverLeaveTag_Element.ToLinkField(context));
}

}
}
