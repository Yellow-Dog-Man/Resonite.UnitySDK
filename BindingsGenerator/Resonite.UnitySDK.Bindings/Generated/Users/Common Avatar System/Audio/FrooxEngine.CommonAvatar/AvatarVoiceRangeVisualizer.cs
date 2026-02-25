
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarVoiceRangeVisualizer
// Generated on: středa 25. února 2026 16:14:45
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VolumeSource", VolumeSource.ToResoniteReference(context));
members.Add("AudioOutput", AudioOutput.ToResoniteReference(context));
members.Add("WhisperColorMin", WhisperColorMin.ToResoniteLinkField());
members.Add("WhisperColorMax", WhisperColorMax.ToResoniteLinkField());
members.Add("WhisperColorRecordingMessage", WhisperColorRecordingMessage.ToResoniteLinkField());
members.Add("VisualRoot", VisualRoot.ToResoniteReference(context));
members.Add("_activeUser", _activeUser.ToResoniteReference(context));
members.Add("_visualSize", _visualSize.ToResoniteReference(context));
members.Add("_visualColor", _visualColor.ToResoniteReference(context));
}

}
}
