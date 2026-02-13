
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiAudioClipPlayer+Track
// Generated on: pátek 13. února 2026 23:21:37
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Clip", new ResoniteLink.Reference() { });
members.Add("Volume", Volume.ToResoniteLinkField());
members.Add("RelativeSpeed", RelativeSpeed.ToResoniteLinkField());
}

}
            }
}
