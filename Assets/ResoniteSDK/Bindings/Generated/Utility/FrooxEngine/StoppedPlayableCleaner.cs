
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StoppedPlayableCleaner
// Generated on: pátek 13. února 2026 23:23:20
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StoppedPlayableCleaner")]
public partial class StoppedPlayableCleaner : global::FrooxEngine.Component

{
    public global::FrooxEngine.IPlayable Playable;
public global::System.Single GracePeriod;
public global::FrooxEngine.User CheckingUser;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Playable", new ResoniteLink.Reference() { });
members.Add("GracePeriod", GracePeriod.ToResoniteLinkField());
members.Add("CheckingUser", new ResoniteLink.Reference() { });
}

}
}
