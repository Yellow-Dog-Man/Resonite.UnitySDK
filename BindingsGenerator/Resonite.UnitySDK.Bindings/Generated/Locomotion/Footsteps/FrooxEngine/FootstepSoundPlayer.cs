
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FootstepSoundPlayer
// Generated on: pondělí 2. března 2026 17:52:30
// Resonite version: 2026.3.2.1000
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FootstepSoundPlayer")]
public partial class FootstepSoundPlayer : global::FrooxEngine.Component, global::FrooxEngine.IFootstepEventReceiver

{
    public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.IFootstepSoundMaterial>, global::FrooxEngine.IFootstepSoundMaterial, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IFootstepSoundMaterial>, global::FrooxEngine.IFootstepSoundMaterial>> SoundMaterials = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SoundMaterials", SoundMaterials.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
