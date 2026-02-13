
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FootstepSoundDefinition
// Generated on: pátek 13. února 2026 5:51:13
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FootstepSoundDefinition")]
public partial class FootstepSoundDefinition : global::FrooxEngine.Component, global::FrooxEngine.IFootstepSoundMaterial

{
    public global::FrooxEngine.Slot ParentUnder;
public global::System.Nullable<global::System.Single> MinDistance;
public global::System.Nullable<global::System.Single> MaxDistance;
public global::System.Nullable<global::Awwdio.AudioRolloffCurve> RolloffMode;
public System.Collections.Generic.List<global::FrooxEngine.FootstepSoundDefinition.FootstepClip> Clips;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ParentUnder", new ResoniteLink.Reference() { });
members.Add("MinDistance", MinDistance.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance.ToResoniteLinkField());
members.Add("RolloffMode", RolloffMode.ToResoniteLinkField());
members.Add("Clips", new ResoniteLink.SyncList()
{
    Elements = Clips.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
}

}
}
