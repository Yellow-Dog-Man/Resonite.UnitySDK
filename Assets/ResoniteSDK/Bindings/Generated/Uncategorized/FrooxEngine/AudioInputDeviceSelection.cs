
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioInputDeviceSelection
// Generated on: sobota 14. února 2026 8:58:41
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SelectedDeviceIndex", SelectedDeviceIndex.ToResoniteLinkField());
members.Add("SelectedDeviceName", SelectedDeviceName.ToResoniteLinkField());
members.Add("UseFilteredData", UseFilteredData.ToResoniteLinkField());
members.Add("_deviceButtonRoot", _deviceButtonRoot.ToResoniteReference(context));
members.Add("_audioStream", _audioStream.ToResoniteReference(context));
members.Add("_audioOutput", _audioOutput.ToResoniteReference(context));
members.Add("_deviceVolume", _deviceVolume.ToResoniteReference(context));
members.Add("_volumeBar", _volumeBar.ToResoniteReference(context));
}

}
}
