
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiAudioClipPlayer+Track
// Generated on: čtvrtek 19. února 2026 7:58:55
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
    public partial class MultiAudioClipPlayer
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MultiAudioClipPlayer+Track")]
public partial class Track : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> Clip;
public global::System.Single Volume;
public global::System.Single RelativeSpeed;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Clip", Clip.ToResoniteReference(context));
members.Add("Volume", Volume.ToResoniteLinkField());
members.Add("RelativeSpeed", RelativeSpeed.ToResoniteLinkField());
}

}
            }
}
