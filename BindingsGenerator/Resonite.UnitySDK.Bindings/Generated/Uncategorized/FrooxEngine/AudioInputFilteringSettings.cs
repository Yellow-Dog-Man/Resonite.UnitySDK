
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioInputFilteringSettings
// Generated on: středa 25. února 2026 16:14:35
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
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
