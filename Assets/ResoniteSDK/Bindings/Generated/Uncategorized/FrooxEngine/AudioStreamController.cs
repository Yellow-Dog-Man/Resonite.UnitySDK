
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioStreamController
// Generated on: úterý 24. února 2026 18:20:18
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioStreamController")]
public partial class AudioStreamController : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAudioStream Stream;
public global::FrooxEngine.AudioOutput AudioOutput;
public global::System.Boolean IsPlayingForOwner;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Stream", Stream.ToResoniteReference(context));
members.Add("AudioOutput", AudioOutput.ToResoniteReference(context));
members.Add("IsPlayingForOwner", IsPlayingForOwner.ToResoniteLinkField());
}

}
}
