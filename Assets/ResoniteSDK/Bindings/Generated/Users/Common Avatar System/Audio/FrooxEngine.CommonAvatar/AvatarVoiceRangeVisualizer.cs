
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarVoiceRangeVisualizer
// Generated on: pátek 13. února 2026 23:23:20
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarVoiceRangeVisualizer")]
public partial class AvatarVoiceRangeVisualizer : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::FrooxEngine.IField<global::System.Single> VolumeSource;
public global::FrooxEngine.AudioOutput AudioOutput;
public UnityEngine.ColorX WhisperColorMin;
public UnityEngine.ColorX WhisperColorMax;
public UnityEngine.ColorX WhisperColorRecordingMessage;
public global::FrooxEngine.Slot VisualRoot;
public global::FrooxEngine.User _activeUser;
public global::FrooxEngine.IField<UnityEngine.Vector3> _visualSize;
public global::FrooxEngine.IField<UnityEngine.ColorX> _visualColor;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("VolumeSource", new ResoniteLink.Reference() { });
members.Add("AudioOutput", new ResoniteLink.Reference() { });
members.Add("WhisperColorMin", WhisperColorMin.ToResoniteLinkField());
members.Add("WhisperColorMax", WhisperColorMax.ToResoniteLinkField());
members.Add("WhisperColorRecordingMessage", WhisperColorRecordingMessage.ToResoniteLinkField());
members.Add("VisualRoot", new ResoniteLink.Reference() { });
members.Add("_activeUser", new ResoniteLink.Reference() { });
members.Add("_visualSize", new ResoniteLink.Reference() { });
members.Add("_visualColor", new ResoniteLink.Reference() { });
}

}
}
