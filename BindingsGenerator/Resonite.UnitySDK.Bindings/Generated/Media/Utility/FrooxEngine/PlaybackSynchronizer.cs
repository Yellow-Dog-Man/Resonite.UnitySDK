
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PlaybackSynchronizer
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PlaybackSynchronizer")]
public partial class PlaybackSynchronizer : global::FrooxEngine.Component

{
    public global::FrooxEngine.SyncPlayback Target;
public global::FrooxEngine.IPlayable Source;
public global::System.Boolean UseNormalizedPosition;
public global::System.Single PositionOffset;
public global::System.Single PositionRate;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("Source", Source.ToResoniteReference(context));
members.Add("UseNormalizedPosition", UseNormalizedPosition.ToResoniteLinkField());
members.Add("PositionOffset", PositionOffset.ToResoniteLinkField());
members.Add("PositionRate", PositionRate.ToResoniteLinkField());
}

}
}
