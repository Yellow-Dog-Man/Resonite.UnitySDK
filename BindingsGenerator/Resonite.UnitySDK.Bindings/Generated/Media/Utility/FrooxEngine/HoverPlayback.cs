
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HoverPlayback
// Generated on: středa 25. února 2026 16:13:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HoverPlayback")]
public partial class HoverPlayback : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::FrooxEngine.SyncPlayback Target;
public global::FrooxEngine.HoverPlayback.PlayTrigger Trigger;
public global::System.Boolean FromBeginning;
public global::System.Boolean Loop;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("Trigger", Trigger.ToResoniteLinkField());
members.Add("FromBeginning", FromBeginning.ToResoniteLinkField());
members.Add("Loop", Loop.ToResoniteLinkField());
}

}
}
