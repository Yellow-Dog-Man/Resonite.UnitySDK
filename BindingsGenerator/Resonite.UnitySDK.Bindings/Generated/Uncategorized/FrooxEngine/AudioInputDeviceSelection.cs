
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioInputDeviceSelection
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioInputDeviceSelection")]
public partial class AudioInputDeviceSelection : global::FrooxEngine.Component

{
    public global::System.Int32 SelectedDeviceIndex { get => SelectedDeviceIndex_Element.Data; set => SelectedDeviceIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> SelectedDeviceIndex_Element = new();
public global::System.String SelectedDeviceName { get => SelectedDeviceName_Element.Data; set => SelectedDeviceName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> SelectedDeviceName_Element = new();
public global::System.Boolean UseFilteredData { get => UseFilteredData_Element.Data; set => UseFilteredData_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseFilteredData_Element = new();
public global::FrooxEngine.Slot _deviceButtonRoot { get => _deviceButtonRoot_Element.Data; set => _deviceButtonRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _deviceButtonRoot_Element = new();
public global::FrooxEngine.LocalAudioDeviceStream _audioStream { get => _audioStream_Element.Data; set => _audioStream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LocalAudioDeviceStream>, global::FrooxEngine.LocalAudioDeviceStream> _audioStream_Element = new();
public global::FrooxEngine.AudioOutput _audioOutput { get => _audioOutput_Element.Data; set => _audioOutput_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioOutput>, global::FrooxEngine.AudioOutput> _audioOutput_Element = new();
public global::FrooxEngine.VolumeMeter _deviceVolume { get => _deviceVolume_Element.Data; set => _deviceVolume_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.VolumeMeter>, global::FrooxEngine.VolumeMeter> _deviceVolume_Element = new();
public global::FrooxEngine.UIX.ProgressBar _volumeBar { get => _volumeBar_Element.Data; set => _volumeBar_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.ProgressBar>, global::FrooxEngine.UIX.ProgressBar> _volumeBar_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SelectedDeviceIndex", SelectedDeviceIndex_Element.ToLinkField(context));
members.Add("SelectedDeviceName", SelectedDeviceName_Element.ToLinkField(context));
members.Add("UseFilteredData", UseFilteredData_Element.ToLinkField(context));
members.Add("_deviceButtonRoot", _deviceButtonRoot_Element.ToLinkReference(context));
members.Add("_audioStream", _audioStream_Element.ToLinkReference(context));
members.Add("_audioOutput", _audioOutput_Element.ToLinkReference(context));
members.Add("_deviceVolume", _deviceVolume_Element.ToLinkReference(context));
members.Add("_volumeBar", _volumeBar_Element.ToLinkReference(context));
}

}
}
