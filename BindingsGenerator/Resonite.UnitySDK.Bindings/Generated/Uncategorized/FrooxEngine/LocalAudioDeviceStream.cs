
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocalAudioDeviceStream
// Generated on: čtvrtek 26. února 2026 15:09:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocalAudioDeviceStream")]
public partial class LocalAudioDeviceStream : global::FrooxEngine.Component, global::FrooxEngine.IWorldAudioDataSource

{
    public global::System.Int32 AudioDeviceIndex { get => AudioDeviceIndex_Element.Data; set => AudioDeviceIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> AudioDeviceIndex_Element = new();
public global::System.Boolean UseFilteredData { get => UseFilteredData_Element.Data; set => UseFilteredData_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseFilteredData_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AudioDeviceIndex", AudioDeviceIndex_Element.ToLinkField(context));
members.Add("UseFilteredData", UseFilteredData_Element.ToLinkField(context));
}

}
}
