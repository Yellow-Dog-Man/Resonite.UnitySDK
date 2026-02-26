
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarVoiceRangeVisualizer
// Generated on: čtvrtek 26. února 2026 15:09:16
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.IField<global::System.Single> VolumeSource { get => VolumeSource_Element.Data; set => VolumeSource_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> VolumeSource_Element = new();
public global::FrooxEngine.AudioOutput AudioOutput { get => AudioOutput_Element.Data; set => AudioOutput_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.AudioOutput>, global::FrooxEngine.AudioOutput> AudioOutput_Element = new();
public UnityEngine.ColorX WhisperColorMin { get => WhisperColorMin_Element.Data; set => WhisperColorMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> WhisperColorMin_Element = new();
public UnityEngine.ColorX WhisperColorMax { get => WhisperColorMax_Element.Data; set => WhisperColorMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> WhisperColorMax_Element = new();
public UnityEngine.ColorX WhisperColorRecordingMessage { get => WhisperColorRecordingMessage_Element.Data; set => WhisperColorRecordingMessage_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> WhisperColorRecordingMessage_Element = new();
public global::FrooxEngine.Slot VisualRoot { get => VisualRoot_Element.Data; set => VisualRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> VisualRoot_Element = new();
public global::FrooxEngine.User _activeUser { get => _activeUser_Element.Data; set => _activeUser_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> _activeUser_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _visualSize { get => _visualSize_Element.Data; set => _visualSize_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _visualSize_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _visualColor { get => _visualColor_Element.Data; set => _visualColor_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _visualColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VolumeSource", VolumeSource_Element.ToLinkReference(context));
members.Add("AudioOutput", AudioOutput_Element.ToLinkReference(context));
members.Add("WhisperColorMin", WhisperColorMin_Element.ToLinkField(context));
members.Add("WhisperColorMax", WhisperColorMax_Element.ToLinkField(context));
members.Add("WhisperColorRecordingMessage", WhisperColorRecordingMessage_Element.ToLinkField(context));
members.Add("VisualRoot", VisualRoot_Element.ToLinkReference(context));
members.Add("_activeUser", _activeUser_Element.ToLinkReference(context));
members.Add("_visualSize", _visualSize_Element.ToLinkReference(context));
members.Add("_visualColor", _visualColor_Element.ToLinkReference(context));
}

}
}
