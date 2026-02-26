
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioInputFilteringSettings
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioInputFilteringSettings")]
public partial class AudioInputFilteringSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.AudioInputFilteringSettings>

{
    public global::System.Boolean UseVoiceNormalization { get => UseVoiceNormalization_Element.Data; set => UseVoiceNormalization_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseVoiceNormalization_Element = new();
public global::System.Single NormalizationThreshold { get => NormalizationThreshold_Element.Data; set => NormalizationThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalizationThreshold_Element = new();
public global::System.Boolean UseNoiseSuppression { get => UseNoiseSuppression_Element.Data; set => UseNoiseSuppression_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseNoiseSuppression_Element = new();
public global::System.Single NoiseGateThreshold { get => NoiseGateThreshold_Element.Data; set => NoiseGateThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NoiseGateThreshold_Element = new();
public global::System.Single NoiseGateAttack { get => NoiseGateAttack_Element.Data; set => NoiseGateAttack_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NoiseGateAttack_Element = new();
public global::System.Single NoiseGateHold { get => NoiseGateHold_Element.Data; set => NoiseGateHold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NoiseGateHold_Element = new();
public global::System.Single NoiseGateRelease { get => NoiseGateRelease_Element.Data; set => NoiseGateRelease_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NoiseGateRelease_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseVoiceNormalization", UseVoiceNormalization_Element.ToLinkField(context));
members.Add("NormalizationThreshold", NormalizationThreshold_Element.ToLinkField(context));
members.Add("UseNoiseSuppression", UseNoiseSuppression_Element.ToLinkField(context));
members.Add("NoiseGateThreshold", NoiseGateThreshold_Element.ToLinkField(context));
members.Add("NoiseGateAttack", NoiseGateAttack_Element.ToLinkField(context));
members.Add("NoiseGateHold", NoiseGateHold_Element.ToLinkField(context));
members.Add("NoiseGateRelease", NoiseGateRelease_Element.ToLinkField(context));
}

}
}
