
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FootstepSoundDefinition
// Generated on: čtvrtek 19. února 2026 7:58:59
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FootstepSoundDefinition")]
public partial class FootstepSoundDefinition : global::FrooxEngine.Component, global::FrooxEngine.IFootstepSoundMaterial

{
    public global::FrooxEngine.Slot ParentUnder;
public global::System.Nullable<global::System.Single> MinDistance;
public global::System.Nullable<global::System.Single> MaxDistance;
public global::System.Nullable<global::Awwdio.AudioRolloffCurve> RolloffMode;
public System.Collections.Generic.List<global::FrooxEngine.FootstepSoundDefinition.FootstepClip> Clips;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ParentUnder", ParentUnder.ToResoniteReference(context));
members.Add("MinDistance", MinDistance.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance.ToResoniteLinkField());
members.Add("RolloffMode", RolloffMode.ToResoniteLinkField());
members.Add("Clips", new ResoniteLink.SyncList()
{
    Elements = Clips.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
