
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StoppedPlayableCleaner
// Generated on: čtvrtek 19. února 2026 8:00:33
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
