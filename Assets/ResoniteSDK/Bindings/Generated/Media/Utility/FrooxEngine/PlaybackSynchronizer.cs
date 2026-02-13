
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PlaybackSynchronizer
// Generated on: pátek 13. února 2026 23:21:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PlaybackSynchronizer")]
public partial class PlaybackSynchronizer : global::FrooxEngine.Component

{
    public global::FrooxEngine.SyncPlayback Target;
public global::FrooxEngine.IPlayable Source;
public global::System.Boolean UseNormalizedPosition;
public global::System.Single PositionOffset;
public global::System.Single PositionRate;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("Source", new ResoniteLink.Reference() { });
members.Add("UseNormalizedPosition", UseNormalizedPosition.ToResoniteLinkField());
members.Add("PositionOffset", PositionOffset.ToResoniteLinkField());
members.Add("PositionRate", PositionRate.ToResoniteLinkField());
}

}
}
