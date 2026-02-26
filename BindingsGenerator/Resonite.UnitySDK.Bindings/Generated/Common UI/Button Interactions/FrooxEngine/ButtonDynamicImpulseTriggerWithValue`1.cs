
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonDynamicImpulseTriggerWithValue<>
// Generated on: čtvrtek 26. února 2026 12:26:53
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonDynamicImpulseTriggerWithValue<>")]
public partial class ButtonDynamicImpulseTriggerWithValue<T> : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver, global::FrooxEngine.IButtonHoverReceiver
	

{
    public global::FrooxEngine.Slot Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Target_Element = new();
public global::System.Boolean ExcludeDisabled { get => ExcludeDisabled_Element.Data; set => ExcludeDisabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ExcludeDisabled_Element = new();
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithValue<T>.EventData PressedData = new();
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithValue<T>.EventData PressingData = new();
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithValue<T>.EventData ReleasedData = new();
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithValue<T>.EventData HoverEnterData = new();
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithValue<T>.EventData HoverStayData = new();
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithValue<T>.EventData HoverLeaveData = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("ExcludeDisabled", ExcludeDisabled_Element.ToLinkField(context));
members.Add("PressedData", PressedData.ToLinkSyncObject(context));
members.Add("PressingData", PressingData.ToLinkSyncObject(context));
members.Add("ReleasedData", ReleasedData.ToLinkSyncObject(context));
members.Add("HoverEnterData", HoverEnterData.ToLinkSyncObject(context));
members.Add("HoverStayData", HoverStayData.ToLinkSyncObject(context));
members.Add("HoverLeaveData", HoverLeaveData.ToLinkSyncObject(context));
}

}
}
