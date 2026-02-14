
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioClipPlayer
// Generated on: sobota 14. února 2026 8:57:01
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioClipPlayer")]
public partial class AudioClipPlayer : global::FrooxEngine.AudioClipPlayerBase, global::FrooxEngine.IItemMetadataSource

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> Clip;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Clip", Clip.ToResoniteReference(context));
}

}
}
