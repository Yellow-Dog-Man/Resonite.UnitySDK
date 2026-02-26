
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraOBS
// Generated on: čtvrtek 26. února 2026 10:04:46
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraOBS")]
public partial class InteractiveCameraOBS : global::FrooxEngine.LegacySwapCanvasPanel

{
    public global::FrooxEngine.InteractiveCameraControl CameraControl { get => CameraControl_Element.Data; set => CameraControl_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.InteractiveCameraControl>, global::FrooxEngine.InteractiveCameraControl> CameraControl_Element = new();
public global::FrooxEngine.UIX.TextField _connectAddress { get => _connectAddress_Element.Data; set => _connectAddress_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _connectAddress_Element = new();
public global::FrooxEngine.UIX.TextField _connectPassword { get => _connectPassword_Element.Data; set => _connectPassword_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _connectPassword_Element = new();
public global::FrooxEngine.UIX.Text _status { get => _status_Element.Data; set => _status_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _status_Element = new();
public global::System.Boolean _active { get => _active_Element.Data; set => _active_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _active_Element = new();
public global::FrooxEngine.UIX.Text _streamTime { get => _streamTime_Element.Data; set => _streamTime_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _streamTime_Element = new();
public global::FrooxEngine.UIX.Text _bytesPerSec { get => _bytesPerSec_Element.Data; set => _bytesPerSec_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _bytesPerSec_Element = new();
public global::FrooxEngine.UIX.Text _fps { get => _fps_Element.Data; set => _fps_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _fps_Element = new();
public global::FrooxEngine.UIX.Text _droppedFrames { get => _droppedFrames_Element.Data; set => _droppedFrames_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _droppedFrames_Element = new();
public global::FrooxEngine.UIX.Button _streamButton { get => _streamButton_Element.Data; set => _streamButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _streamButton_Element = new();
public global::FrooxEngine.UIX.Button _recordButton { get => _recordButton_Element.Data; set => _recordButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _recordButton_Element = new();
public global::FrooxEngine.UIX.Button _launchOBSbutton { get => _launchOBSbutton_Element.Data; set => _launchOBSbutton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _launchOBSbutton_Element = new();
public global::FrooxEngine.UIX.Checkbox _autoMirror { get => _autoMirror_Element.Data; set => _autoMirror_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _autoMirror_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CameraControl", CameraControl_Element.Data.ToResoniteReference(context));
members.Add("_connectAddress", _connectAddress_Element.Data.ToResoniteReference(context));
members.Add("_connectPassword", _connectPassword_Element.Data.ToResoniteReference(context));
members.Add("_status", _status_Element.Data.ToResoniteReference(context));
members.Add("_active", _active_Element.Data.ToResoniteLinkField());
members.Add("_streamTime", _streamTime_Element.Data.ToResoniteReference(context));
members.Add("_bytesPerSec", _bytesPerSec_Element.Data.ToResoniteReference(context));
members.Add("_fps", _fps_Element.Data.ToResoniteReference(context));
members.Add("_droppedFrames", _droppedFrames_Element.Data.ToResoniteReference(context));
members.Add("_streamButton", _streamButton_Element.Data.ToResoniteReference(context));
members.Add("_recordButton", _recordButton_Element.Data.ToResoniteReference(context));
members.Add("_launchOBSbutton", _launchOBSbutton_Element.Data.ToResoniteReference(context));
members.Add("_autoMirror", _autoMirror_Element.Data.ToResoniteReference(context));
}

}
}
