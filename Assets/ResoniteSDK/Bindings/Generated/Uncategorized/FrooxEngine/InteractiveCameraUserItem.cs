
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraUserItem
// Generated on: pátek 13. února 2026 5:52:33
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Control", new ResoniteLink.Reference() { });
members.Add("_username", new ResoniteLink.Reference() { });
members.Add("_voiceDefault", new ResoniteLink.Reference() { });
members.Add("_voiceMute", new ResoniteLink.Reference() { });
members.Add("_voiceShout", new ResoniteLink.Reference() { });
members.Add("_voiceBroadcast", new ResoniteLink.Reference() { });
members.Add("_groupAuto", new ResoniteLink.Reference() { });
members.Add("_groupExclude", new ResoniteLink.Reference() { });
members.Add("_groupInclude", new ResoniteLink.Reference() { });
members.Add("_cameraOperator", new ResoniteLink.Reference() { });
members.Add("_framingTarget", new ResoniteLink.Reference() { });
members.Add("_volumeSlider", new ResoniteLink.Reference() { });
}

}
}
