
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.IsPlayingDriver
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.IsPlayingDriver")]
public partial class IsPlayingDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.SyncPlayback Playback { get => Playback_Element.Data; set => Playback_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncPlayback>, global::FrooxEngine.SyncPlayback> Playback_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.FieldDrive<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>, Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>>> Targets = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Playback", Playback_Element.ToLinkReference(context));
members.Add("Targets", Targets.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
