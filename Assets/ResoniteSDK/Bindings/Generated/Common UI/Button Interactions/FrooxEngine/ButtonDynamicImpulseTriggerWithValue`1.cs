
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonDynamicImpulseTriggerWithValue<>
// Generated on: čtvrtek 19. února 2026 7:58:56
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonDynamicImpulseTriggerWithValue<>")]
public partial class ButtonDynamicImpulseTriggerWithValue<T> : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver, global::FrooxEngine.IButtonHoverReceiver
	

{
    public global::FrooxEngine.Slot Target;
public global::System.Boolean ExcludeDisabled;
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithValue<T>.EventData PressedData;
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithValue<T>.EventData PressingData;
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithValue<T>.EventData ReleasedData;
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithValue<T>.EventData HoverEnterData;
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithValue<T>.EventData HoverStayData;
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithValue<T>.EventData HoverLeaveData;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("ExcludeDisabled", ExcludeDisabled.ToResoniteLinkField());
members.Add("PressedData", new ResoniteLink.SyncObject() { Members = PressedData.CollectMembers(context) });
members.Add("PressingData", new ResoniteLink.SyncObject() { Members = PressingData.CollectMembers(context) });
members.Add("ReleasedData", new ResoniteLink.SyncObject() { Members = ReleasedData.CollectMembers(context) });
members.Add("HoverEnterData", new ResoniteLink.SyncObject() { Members = HoverEnterData.CollectMembers(context) });
members.Add("HoverStayData", new ResoniteLink.SyncObject() { Members = HoverStayData.CollectMembers(context) });
members.Add("HoverLeaveData", new ResoniteLink.SyncObject() { Members = HoverLeaveData.CollectMembers(context) });
}

}
}
