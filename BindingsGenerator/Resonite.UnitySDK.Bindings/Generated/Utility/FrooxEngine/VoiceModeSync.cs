
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VoiceModeSync
// Generated on: středa 25. února 2026 16:14:47
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VoiceModeSync")]
public partial class VoiceModeSync : global::FrooxEngine.Component

{
    public global::FrooxEngine.VoiceMode FocusedWorldVoiceMode;
public global::System.Boolean GlobalMute;
public global::FrooxEngine.VoiceMode FocusedWorldMaxAllowedVoiceMode;
public global::System.Boolean BroadcastAllowed;
public global::System.Boolean ShoutAllowed;
public global::System.Boolean NormalAllowed;
public global::System.Boolean WhisperAllowed;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FocusedWorldVoiceMode", FocusedWorldVoiceMode.ToResoniteLinkField());
members.Add("GlobalMute", GlobalMute.ToResoniteLinkField());
members.Add("FocusedWorldMaxAllowedVoiceMode", FocusedWorldMaxAllowedVoiceMode.ToResoniteLinkField());
members.Add("BroadcastAllowed", BroadcastAllowed.ToResoniteLinkField());
members.Add("ShoutAllowed", ShoutAllowed.ToResoniteLinkField());
members.Add("NormalAllowed", NormalAllowed.ToResoniteLinkField());
members.Add("WhisperAllowed", WhisperAllowed.ToResoniteLinkField());
}

}
}
