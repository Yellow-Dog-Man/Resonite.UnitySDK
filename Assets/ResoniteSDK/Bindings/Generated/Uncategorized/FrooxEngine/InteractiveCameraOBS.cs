
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraOBS
// Generated on: čtvrtek 19. února 2026 8:00:28
// Resonite version: 2026.2.19.471
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraOBS")]
public partial class InteractiveCameraOBS : global::FrooxEngine.LegacySwapCanvasPanel

{
    public global::FrooxEngine.InteractiveCameraControl CameraControl;
public global::FrooxEngine.UIX.TextField _connectAddress;
public global::FrooxEngine.UIX.TextField _connectPassword;
public global::FrooxEngine.UIX.Text _status;
public global::System.Boolean _active;
public global::FrooxEngine.UIX.Text _streamTime;
public global::FrooxEngine.UIX.Text _bytesPerSec;
public global::FrooxEngine.UIX.Text _fps;
public global::FrooxEngine.UIX.Text _droppedFrames;
public global::FrooxEngine.UIX.Button _streamButton;
public global::FrooxEngine.UIX.Button _recordButton;
public global::FrooxEngine.UIX.Button _launchOBSbutton;
public global::FrooxEngine.UIX.Checkbox _autoMirror;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CameraControl", CameraControl.ToResoniteReference(context));
members.Add("_connectAddress", _connectAddress.ToResoniteReference(context));
members.Add("_connectPassword", _connectPassword.ToResoniteReference(context));
members.Add("_status", _status.ToResoniteReference(context));
members.Add("_active", _active.ToResoniteLinkField());
members.Add("_streamTime", _streamTime.ToResoniteReference(context));
members.Add("_bytesPerSec", _bytesPerSec.ToResoniteReference(context));
members.Add("_fps", _fps.ToResoniteReference(context));
members.Add("_droppedFrames", _droppedFrames.ToResoniteReference(context));
members.Add("_streamButton", _streamButton.ToResoniteReference(context));
members.Add("_recordButton", _recordButton.ToResoniteReference(context));
members.Add("_launchOBSbutton", _launchOBSbutton.ToResoniteReference(context));
members.Add("_autoMirror", _autoMirror.ToResoniteReference(context));
}

}
}
