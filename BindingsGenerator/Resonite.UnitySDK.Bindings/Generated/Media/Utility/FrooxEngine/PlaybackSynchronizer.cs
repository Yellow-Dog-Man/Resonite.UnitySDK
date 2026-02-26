
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PlaybackSynchronizer
// Generated on: čtvrtek 26. února 2026 12:26:57
// Resonite version: 2026.2.26.702
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
    public global::FrooxEngine.SyncPlayback Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.SyncPlayback>, global::FrooxEngine.SyncPlayback> Target_Element = new();
public global::FrooxEngine.IPlayable Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IPlayable>, global::FrooxEngine.IPlayable> Source_Element = new();
public global::System.Boolean UseNormalizedPosition { get => UseNormalizedPosition_Element.Data; set => UseNormalizedPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseNormalizedPosition_Element = new();
public global::System.Single PositionOffset { get => PositionOffset_Element.Data; set => PositionOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PositionOffset_Element = new();
public global::System.Single PositionRate { get => PositionRate_Element.Data; set => PositionRate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PositionRate_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("UseNormalizedPosition", UseNormalizedPosition_Element.ToLinkField(context));
members.Add("PositionOffset", PositionOffset_Element.ToLinkField(context));
members.Add("PositionRate", PositionRate_Element.ToLinkField(context));
}

}
}
