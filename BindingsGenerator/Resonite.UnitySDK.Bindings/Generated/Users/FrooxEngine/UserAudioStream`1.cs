
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserAudioStream<>
// Generated on: čtvrtek 26. února 2026 12:28:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserAudioStream<>")]
public partial class UserAudioStream<S> : global::FrooxEngine.Component
	where S : struct, global::Elements.Assets.IAudioSample<S>

{
    public global::FrooxEngine.AudioStream<S> Stream { get => Stream_Element.Data; set => Stream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioStream<S>>, global::FrooxEngine.AudioStream<S>> Stream_Element = new();
public global::System.Boolean UseFilteredData { get => UseFilteredData_Element.Data; set => UseFilteredData_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseFilteredData_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Stream", Stream_Element.ToLinkReference(context));
members.Add("UseFilteredData", UseFilteredData_Element.ToLinkField(context));
}

}
}
