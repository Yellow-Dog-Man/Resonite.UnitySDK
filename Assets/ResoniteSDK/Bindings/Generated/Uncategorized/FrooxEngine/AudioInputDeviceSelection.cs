
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioInputDeviceSelection
// Generated on: pátek 13. února 2026 23:23:12
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioInputDeviceSelection")]
public partial class AudioInputDeviceSelection : global::FrooxEngine.Component

{
    public global::System.Int32 SelectedDeviceIndex;
public global::System.String SelectedDeviceName;
public global::System.Boolean UseFilteredData;
public global::FrooxEngine.Slot _deviceButtonRoot;
public global::FrooxEngine.LocalAudioDeviceStream _audioStream;
public global::FrooxEngine.AudioOutput _audioOutput;
public global::FrooxEngine.VolumeMeter _deviceVolume;
public global::FrooxEngine.UIX.ProgressBar _volumeBar;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SelectedDeviceIndex", SelectedDeviceIndex.ToResoniteLinkField());
members.Add("SelectedDeviceName", SelectedDeviceName.ToResoniteLinkField());
members.Add("UseFilteredData", UseFilteredData.ToResoniteLinkField());
members.Add("_deviceButtonRoot", new ResoniteLink.Reference() { });
members.Add("_audioStream", new ResoniteLink.Reference() { });
members.Add("_audioOutput", new ResoniteLink.Reference() { });
members.Add("_deviceVolume", new ResoniteLink.Reference() { });
members.Add("_volumeBar", new ResoniteLink.Reference() { });
}

}
}
