
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonDynamicImpulseTriggerWithValue<>
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("ExcludeDisabled", ExcludeDisabled.ToResoniteLinkField());
members.Add("PressedData", new ResoniteLink.SyncObject() { Members = PressedData.CollectMembers() });
members.Add("PressingData", new ResoniteLink.SyncObject() { Members = PressingData.CollectMembers() });
members.Add("ReleasedData", new ResoniteLink.SyncObject() { Members = ReleasedData.CollectMembers() });
members.Add("HoverEnterData", new ResoniteLink.SyncObject() { Members = HoverEnterData.CollectMembers() });
members.Add("HoverStayData", new ResoniteLink.SyncObject() { Members = HoverStayData.CollectMembers() });
members.Add("HoverLeaveData", new ResoniteLink.SyncObject() { Members = HoverLeaveData.CollectMembers() });
}

}
}
