
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonDynamicImpulseTriggerWithReference<>
// Generated on: čtvrtek 26. února 2026 10:03:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonDynamicImpulseTriggerWithReference<>")]
public partial class ButtonDynamicImpulseTriggerWithReference<T> : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver, global::FrooxEngine.IButtonHoverReceiver
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.Slot Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Target_Element = new();
public global::System.Boolean ExcludeDisabled { get => ExcludeDisabled_Element.Data; set => ExcludeDisabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ExcludeDisabled_Element = new();
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithReference<T>.EventData PressedData = new();
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithReference<T>.EventData PressingData = new();
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithReference<T>.EventData ReleasedData = new();
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithReference<T>.EventData HoverEnterData = new();
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithReference<T>.EventData HoverStayData = new();
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithReference<T>.EventData HoverLeaveData = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.Data.ToResoniteReference(context));
members.Add("ExcludeDisabled", ExcludeDisabled_Element.Data.ToResoniteLinkField());
members.Add("PressedData", new ResoniteLink.SyncObject() { Members = PressedData.CollectMembers(context) });
members.Add("PressingData", new ResoniteLink.SyncObject() { Members = PressingData.CollectMembers(context) });
members.Add("ReleasedData", new ResoniteLink.SyncObject() { Members = ReleasedData.CollectMembers(context) });
members.Add("HoverEnterData", new ResoniteLink.SyncObject() { Members = HoverEnterData.CollectMembers(context) });
members.Add("HoverStayData", new ResoniteLink.SyncObject() { Members = HoverStayData.CollectMembers(context) });
members.Add("HoverLeaveData", new ResoniteLink.SyncObject() { Members = HoverLeaveData.CollectMembers(context) });
}

}
}
