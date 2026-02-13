
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraOBS
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("CameraControl", new ResoniteLink.Reference() { });
members.Add("_connectAddress", new ResoniteLink.Reference() { });
members.Add("_connectPassword", new ResoniteLink.Reference() { });
members.Add("_status", new ResoniteLink.Reference() { });
members.Add("_active", _active.ToResoniteLinkField());
members.Add("_streamTime", new ResoniteLink.Reference() { });
members.Add("_bytesPerSec", new ResoniteLink.Reference() { });
members.Add("_fps", new ResoniteLink.Reference() { });
members.Add("_droppedFrames", new ResoniteLink.Reference() { });
members.Add("_streamButton", new ResoniteLink.Reference() { });
members.Add("_recordButton", new ResoniteLink.Reference() { });
members.Add("_launchOBSbutton", new ResoniteLink.Reference() { });
members.Add("_autoMirror", new ResoniteLink.Reference() { });
}

}
}
