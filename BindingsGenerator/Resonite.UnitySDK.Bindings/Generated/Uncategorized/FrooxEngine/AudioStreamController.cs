
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioStreamController
// Generated on: čtvrtek 26. února 2026 12:28:09
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.IAudioStream Stream { get => Stream_Element.Data; set => Stream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IAudioStream>, global::FrooxEngine.IAudioStream> Stream_Element = new();
public global::FrooxEngine.AudioOutput AudioOutput { get => AudioOutput_Element.Data; set => AudioOutput_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioOutput>, global::FrooxEngine.AudioOutput> AudioOutput_Element = new();
public global::System.Boolean IsPlayingForOwner { get => IsPlayingForOwner_Element.Data; set => IsPlayingForOwner_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsPlayingForOwner_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Stream", Stream_Element.ToLinkReference(context));
members.Add("AudioOutput", AudioOutput_Element.ToLinkReference(context));
members.Add("IsPlayingForOwner", IsPlayingForOwner_Element.ToLinkField(context));
}

}
}
