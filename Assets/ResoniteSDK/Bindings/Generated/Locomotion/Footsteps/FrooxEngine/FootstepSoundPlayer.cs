
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FootstepSoundPlayer
// Generated on: úterý 24. února 2026 18:17:50
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public System.Collections.Generic.List<global::FrooxEngine.IFootstepSoundMaterial> SoundMaterials;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SoundMaterials", new ResoniteLink.SyncList()
{
    Elements = SoundMaterials.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
