
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocalAudioDeviceStream
// Generated on: středa 25. února 2026 16:14:34
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocalAudioDeviceStream")]
public partial class LocalAudioDeviceStream : global::FrooxEngine.Component, global::FrooxEngine.IWorldAudioDataSource

{
    public global::System.Int32 AudioDeviceIndex;
public global::System.Boolean UseFilteredData;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AudioDeviceIndex", AudioDeviceIndex.ToResoniteLinkField());
members.Add("UseFilteredData", UseFilteredData.ToResoniteLinkField());
}

}
}
