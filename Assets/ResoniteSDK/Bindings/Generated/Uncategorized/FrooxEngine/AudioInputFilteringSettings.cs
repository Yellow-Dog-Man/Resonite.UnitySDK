
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioInputFilteringSettings
// Generated on: pátek 13. února 2026 5:52:29
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioInputFilteringSettings")]
public partial class AudioInputFilteringSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.AudioInputFilteringSettings>

{
    public global::System.Boolean UseVoiceNormalization;
public global::System.Single NormalizationThreshold;
public global::System.Boolean UseNoiseSuppression;
public global::System.Single NoiseGateThreshold;
public global::System.Single NoiseGateAttack;
public global::System.Single NoiseGateHold;
public global::System.Single NoiseGateRelease;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("UseVoiceNormalization", UseVoiceNormalization.ToResoniteLinkField());
members.Add("NormalizationThreshold", NormalizationThreshold.ToResoniteLinkField());
members.Add("UseNoiseSuppression", UseNoiseSuppression.ToResoniteLinkField());
members.Add("NoiseGateThreshold", NoiseGateThreshold.ToResoniteLinkField());
members.Add("NoiseGateAttack", NoiseGateAttack.ToResoniteLinkField());
members.Add("NoiseGateHold", NoiseGateHold.ToResoniteLinkField());
members.Add("NoiseGateRelease", NoiseGateRelease.ToResoniteLinkField());
}

}
}
