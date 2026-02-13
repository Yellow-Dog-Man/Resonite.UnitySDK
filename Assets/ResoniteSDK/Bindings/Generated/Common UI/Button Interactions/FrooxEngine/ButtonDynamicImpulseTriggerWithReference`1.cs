
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonDynamicImpulseTriggerWithReference<>
// Generated on: pátek 13. února 2026 5:51:11
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonDynamicImpulseTriggerWithReference<>")]
public partial class ButtonDynamicImpulseTriggerWithReference<T> : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver, global::FrooxEngine.IButtonHoverReceiver
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.Slot Target;
public global::System.Boolean ExcludeDisabled;
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithReference<T>.EventData PressedData;
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithReference<T>.EventData PressingData;
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithReference<T>.EventData ReleasedData;
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithReference<T>.EventData HoverEnterData;
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithReference<T>.EventData HoverStayData;
public global::FrooxEngine.ButtonDynamicImpulseTriggerWithReference<T>.EventData HoverLeaveData;

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
