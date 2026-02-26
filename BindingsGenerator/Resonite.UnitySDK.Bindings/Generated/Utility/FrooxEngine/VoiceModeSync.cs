
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VoiceModeSync
// Generated on: čtvrtek 26. února 2026 15:09:17
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VoiceModeSync")]
public partial class VoiceModeSync : global::FrooxEngine.Component

{
    public global::FrooxEngine.VoiceMode FocusedWorldVoiceMode { get => FocusedWorldVoiceMode_Element.Data; set => FocusedWorldVoiceMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VoiceMode>, global::FrooxEngine.VoiceMode> FocusedWorldVoiceMode_Element = new();
public global::System.Boolean GlobalMute { get => GlobalMute_Element.Data; set => GlobalMute_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> GlobalMute_Element = new();
public global::FrooxEngine.VoiceMode FocusedWorldMaxAllowedVoiceMode { get => FocusedWorldMaxAllowedVoiceMode_Element.Data; set => FocusedWorldMaxAllowedVoiceMode_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::FrooxEngine.VoiceMode>, global::FrooxEngine.VoiceMode> FocusedWorldMaxAllowedVoiceMode_Element = new();
public global::System.Boolean BroadcastAllowed { get => BroadcastAllowed_Element.Data; set => BroadcastAllowed_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> BroadcastAllowed_Element = new();
public global::System.Boolean ShoutAllowed { get => ShoutAllowed_Element.Data; set => ShoutAllowed_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> ShoutAllowed_Element = new();
public global::System.Boolean NormalAllowed { get => NormalAllowed_Element.Data; set => NormalAllowed_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> NormalAllowed_Element = new();
public global::System.Boolean WhisperAllowed { get => WhisperAllowed_Element.Data; set => WhisperAllowed_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> WhisperAllowed_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FocusedWorldVoiceMode", FocusedWorldVoiceMode_Element.ToLinkField(context));
members.Add("GlobalMute", GlobalMute_Element.ToLinkField(context));
members.Add("FocusedWorldMaxAllowedVoiceMode", FocusedWorldMaxAllowedVoiceMode_Element.ToLinkField(context));
members.Add("BroadcastAllowed", BroadcastAllowed_Element.ToLinkField(context));
members.Add("ShoutAllowed", ShoutAllowed_Element.ToLinkField(context));
members.Add("NormalAllowed", NormalAllowed_Element.ToLinkField(context));
members.Add("WhisperAllowed", WhisperAllowed_Element.ToLinkField(context));
}

}
}
