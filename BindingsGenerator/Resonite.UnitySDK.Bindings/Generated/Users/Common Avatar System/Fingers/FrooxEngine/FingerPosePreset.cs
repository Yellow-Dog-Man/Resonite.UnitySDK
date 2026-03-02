
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FingerPosePreset
// Generated on: pondělí 2. března 2026 17:53:38
// Resonite version: 2026.3.2.1000
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FingerPosePreset")]
public partial class FingerPosePreset : global::FrooxEngine.Component, global::FrooxEngine.IFingerPoseSourceComponent

{
    public global::FrooxEngine.FingerPosePreset.Preset PresetPose { get => PresetPose_Element.Data; set => PresetPose_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.FingerPosePreset.Preset>, global::FrooxEngine.FingerPosePreset.Preset> PresetPose_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PresetPose", PresetPose_Element.ToLinkField(context));
}

}
}
