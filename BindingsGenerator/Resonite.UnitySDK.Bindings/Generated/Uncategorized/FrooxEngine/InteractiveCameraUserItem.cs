
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraUserItem
// Generated on: čtvrtek 26. února 2026 15:09:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraUserItem")]
public partial class InteractiveCameraUserItem : global::FrooxEngine.Component

{
    public global::FrooxEngine.InteractiveCameraControl Control { get => Control_Element.Data; set => Control_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.InteractiveCameraControl>, global::FrooxEngine.InteractiveCameraControl> Control_Element = new();
public global::FrooxEngine.UIX.Text _username { get => _username_Element.Data; set => _username_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _username_Element = new();
public global::FrooxEngine.UIX.Button _voiceDefault { get => _voiceDefault_Element.Data; set => _voiceDefault_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _voiceDefault_Element = new();
public global::FrooxEngine.UIX.Button _voiceMute { get => _voiceMute_Element.Data; set => _voiceMute_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _voiceMute_Element = new();
public global::FrooxEngine.UIX.Button _voiceShout { get => _voiceShout_Element.Data; set => _voiceShout_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _voiceShout_Element = new();
public global::FrooxEngine.UIX.Button _voiceBroadcast { get => _voiceBroadcast_Element.Data; set => _voiceBroadcast_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _voiceBroadcast_Element = new();
public global::FrooxEngine.UIX.Button _groupAuto { get => _groupAuto_Element.Data; set => _groupAuto_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _groupAuto_Element = new();
public global::FrooxEngine.UIX.Button _groupExclude { get => _groupExclude_Element.Data; set => _groupExclude_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _groupExclude_Element = new();
public global::FrooxEngine.UIX.Button _groupInclude { get => _groupInclude_Element.Data; set => _groupInclude_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _groupInclude_Element = new();
public global::FrooxEngine.UIX.Button _cameraOperator { get => _cameraOperator_Element.Data; set => _cameraOperator_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _cameraOperator_Element = new();
public global::FrooxEngine.UIX.Button _framingTarget { get => _framingTarget_Element.Data; set => _framingTarget_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _framingTarget_Element = new();
public global::FrooxEngine.UIX.Slider<global::System.Single> _volumeSlider { get => _volumeSlider_Element.Data; set => _volumeSlider_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Slider<global::System.Single>>, global::FrooxEngine.UIX.Slider<global::System.Single>> _volumeSlider_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Control", Control_Element.ToLinkReference(context));
members.Add("_username", _username_Element.ToLinkReference(context));
members.Add("_voiceDefault", _voiceDefault_Element.ToLinkReference(context));
members.Add("_voiceMute", _voiceMute_Element.ToLinkReference(context));
members.Add("_voiceShout", _voiceShout_Element.ToLinkReference(context));
members.Add("_voiceBroadcast", _voiceBroadcast_Element.ToLinkReference(context));
members.Add("_groupAuto", _groupAuto_Element.ToLinkReference(context));
members.Add("_groupExclude", _groupExclude_Element.ToLinkReference(context));
members.Add("_groupInclude", _groupInclude_Element.ToLinkReference(context));
members.Add("_cameraOperator", _cameraOperator_Element.ToLinkReference(context));
members.Add("_framingTarget", _framingTarget_Element.ToLinkReference(context));
members.Add("_volumeSlider", _volumeSlider_Element.ToLinkReference(context));
}

}
}
