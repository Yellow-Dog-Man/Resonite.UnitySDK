
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraAudioSettings
// Generated on: čtvrtek 26. února 2026 12:28:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraAudioSettings")]
public partial class InteractiveCameraAudioSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.InteractiveCameraAudioSettings>

{
    public global::System.Boolean RenderOwnVoiceOnCamera { get => RenderOwnVoiceOnCamera_Element.Data; set => RenderOwnVoiceOnCamera_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RenderOwnVoiceOnCamera_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RenderOwnVoiceOnCamera", RenderOwnVoiceOnCamera_Element.ToLinkField(context));
}

}
}
