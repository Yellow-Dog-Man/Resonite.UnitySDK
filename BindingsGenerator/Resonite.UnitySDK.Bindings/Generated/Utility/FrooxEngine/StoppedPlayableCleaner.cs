
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StoppedPlayableCleaner
// Generated on: středa 25. února 2026 16:14:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StoppedPlayableCleaner")]
public partial class StoppedPlayableCleaner : global::FrooxEngine.Component

{
    public global::FrooxEngine.IPlayable Playable;
public global::System.Single GracePeriod;
public global::FrooxEngine.User CheckingUser;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Playable", Playable.ToResoniteReference(context));
members.Add("GracePeriod", GracePeriod.ToResoniteLinkField());
members.Add("CheckingUser", CheckingUser.ToResoniteReference(context));
}

}
}
