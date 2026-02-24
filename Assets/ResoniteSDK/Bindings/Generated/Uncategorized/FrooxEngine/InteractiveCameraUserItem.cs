
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraUserItem
// Generated on: úterý 24. února 2026 18:20:24
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraUserItem")]
public partial class InteractiveCameraUserItem : global::FrooxEngine.Component

{
    public global::FrooxEngine.InteractiveCameraControl Control;
public global::FrooxEngine.UIX.Text _username;
public global::FrooxEngine.UIX.Button _voiceDefault;
public global::FrooxEngine.UIX.Button _voiceMute;
public global::FrooxEngine.UIX.Button _voiceShout;
public global::FrooxEngine.UIX.Button _voiceBroadcast;
public global::FrooxEngine.UIX.Button _groupAuto;
public global::FrooxEngine.UIX.Button _groupExclude;
public global::FrooxEngine.UIX.Button _groupInclude;
public global::FrooxEngine.UIX.Button _cameraOperator;
public global::FrooxEngine.UIX.Button _framingTarget;
public global::FrooxEngine.UIX.Slider<global::System.Single> _volumeSlider;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Control", Control.ToResoniteReference(context));
members.Add("_username", _username.ToResoniteReference(context));
members.Add("_voiceDefault", _voiceDefault.ToResoniteReference(context));
members.Add("_voiceMute", _voiceMute.ToResoniteReference(context));
members.Add("_voiceShout", _voiceShout.ToResoniteReference(context));
members.Add("_voiceBroadcast", _voiceBroadcast.ToResoniteReference(context));
members.Add("_groupAuto", _groupAuto.ToResoniteReference(context));
members.Add("_groupExclude", _groupExclude.ToResoniteReference(context));
members.Add("_groupInclude", _groupInclude.ToResoniteReference(context));
members.Add("_cameraOperator", _cameraOperator.ToResoniteReference(context));
members.Add("_framingTarget", _framingTarget.ToResoniteReference(context));
members.Add("_volumeSlider", _volumeSlider.ToResoniteReference(context));
}

}
}
