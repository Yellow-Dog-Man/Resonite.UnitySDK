
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FootstepSoundDefinition
// Generated on: čtvrtek 26. února 2026 15:08:00
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FootstepSoundDefinition")]
public partial class FootstepSoundDefinition : global::FrooxEngine.Component, global::FrooxEngine.IFootstepSoundMaterial

{
    public global::FrooxEngine.Slot ParentUnder { get => ParentUnder_Element.Data; set => ParentUnder_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ParentUnder_Element = new();
public global::System.Nullable<global::System.Single> MinDistance { get => MinDistance_Element.Data; set => MinDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> MinDistance_Element = new();
public global::System.Nullable<global::System.Single> MaxDistance { get => MaxDistance_Element.Data; set => MaxDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> MaxDistance_Element = new();
public global::System.Nullable<global::Awwdio.AudioRolloffCurve> RolloffMode { get => RolloffMode_Element.Data; set => RolloffMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::Awwdio.AudioRolloffCurve>>, global::System.Nullable<global::Awwdio.AudioRolloffCurve>> RolloffMode_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.FootstepSoundDefinition.FootstepClip>, global::FrooxEngine.FootstepSoundDefinition.FootstepClip> Clips = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ParentUnder", ParentUnder_Element.ToLinkReference(context));
members.Add("MinDistance", MinDistance_Element.ToLinkField(context));
members.Add("MaxDistance", MaxDistance_Element.ToLinkField(context));
members.Add("RolloffMode", RolloffMode_Element.ToLinkField(context));
members.Add("Clips", Clips.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
