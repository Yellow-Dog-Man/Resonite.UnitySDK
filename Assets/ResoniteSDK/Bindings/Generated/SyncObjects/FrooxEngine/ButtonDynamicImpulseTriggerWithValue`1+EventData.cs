
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonDynamicImpulseTriggerWithValue<>+EventData
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
    public partial class ButtonDynamicImpulseTriggerWithValue<T>
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonDynamicImpulseTriggerWithValue<>+EventData")]
public partial class EventData : global::FrooxEngine.SyncObject

{
    public global::System.String Tag;
public T Value;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Tag", Tag.ToResoniteLinkField());
members.Add("Value", Value.ToResoniteLinkField());
}

}
            }
}
