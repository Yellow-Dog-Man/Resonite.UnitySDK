
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonDynamicImpulseTriggerWithValue<>+EventData
// Generated on: středa 25. února 2026 16:13:06
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
    public partial class ButtonDynamicImpulseTriggerWithValue<T>
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonDynamicImpulseTriggerWithValue<>+EventData")]
public partial class EventData : global::FrooxEngine.SyncObject

{
    public global::System.String Tag;
public T Value;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Tag", Tag.ToResoniteLinkField());
members.Add("Value", Value.ToResoniteLinkField());
}

}
            }
}
