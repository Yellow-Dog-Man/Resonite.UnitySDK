
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserAudioStream<>
// Generated on: pátek 13. února 2026 23:23:19
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserAudioStream<>")]
public partial class UserAudioStream<S> : global::FrooxEngine.Component
	where S : struct, global::Elements.Assets.IAudioSample<S>

{
    public global::FrooxEngine.AudioStream<S> Stream;
public global::System.Boolean UseFilteredData;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Stream", new ResoniteLink.Reference() { });
members.Add("UseFilteredData", UseFilteredData.ToResoniteLinkField());
}

}
}
